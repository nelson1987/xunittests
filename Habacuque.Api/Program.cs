using Habacuque.Application;
using Habacuque.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/conta", () =>
{
     return new ContaController().Post();
})
.WithName("PostConta")
.WithOpenApi();

app.Run();

public class ContaController
{
    public async Task<Conta> Post()
    {
        ContaCreateHandler handler = new ContaCreateHandler();
        return await handler.Handle();
    }
}