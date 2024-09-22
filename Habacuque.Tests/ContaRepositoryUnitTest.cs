using FluentAssertions;
using Habacuque.Domain;
using Habacuque.Infra;

namespace Habacuque.Tests;

public class ContaRepositoryUnitTest
{
    [Fact]
    public async Task Add_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = new Conta(0, "1234");

        poupanca = await new ContaRepository().Add(poupanca);
        
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(1);
    }

    [Fact]
    public async Task Update_ContaComDadosCorreto_RetornaNumero()
    {
        Conta poupanca = new Conta(1, "12345");

        poupanca = await new ContaRepository().Update(poupanca);
        
        poupanca.Should().NotBeNull();
        poupanca.Numero.Should().Be("12345");
    }
    
    [Fact]
    public async Task Find_ContaComDadosCorreto_RetornaNumero()
    {
        Conta poupanca = new Conta(1, "1234");

        poupanca = await new ContaRepository().Find(poupanca);
        
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(1);
    }
}
