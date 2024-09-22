using FluentAssertions;
using Habacuque.Application;
using Habacuque.Domain;

namespace Habacuque.Tests;

public class ContaCreateHandlerUnitTest
{
    [Fact]
    public async Task Handle_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = await new ContaCreateHandler().Handle();
        
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(1);
    }
}

public class ContaUpdateHandlerUnitTest
{
    [Fact]
    public async Task Handle_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = await new ContaUpdateHandler().Handle();
        
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(0);
    }
}
