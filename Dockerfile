FROM mcr.microsoft.com/dotnet/aspnet:8.0 as base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 as build
WORKDIR /src
COPY ["Habacuque.csproj","Habacuque/"]
RUN dotnet restore "Habacuque/Habacuque.csproj"
COPY [".","Habacuque/"]
WORKDIR /src/Habacuque
RUN dotnet build "Habacuque.csproj" --no-restore -c Release -o /app/build

FROM build as publish
RUN dotnet publish "Habacuque.csproj" --no-restore -c Release -o /app/publish

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT [ "dotnet", "Habacuque.dll" ]