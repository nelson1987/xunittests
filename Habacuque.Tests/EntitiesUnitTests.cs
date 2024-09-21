using FluentAssertions;
using Habacuque.Domain;

namespace Habacuque.Tests;
public class EntitiesUnitTests
{
    [Fact(DisplayName = "Teste inicial de Adicao de Conta")]
    public async Task Post_AddConta()
    {
        Conta poupanca = new Conta(0, "1234");

        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(0);
    }

    [Fact]
    public void Get_FindConta()
    {
        // int id = 1;
        // Conta poupanca = 
        // poupanca.Should().NotBeNull();
    }

    [Fact]
    public void Get_FindSaldo()
    {

    }

    [Fact]
    public void Post_AddTransferencia()
    {

    }

}

//Add Conta
//Get Conta
//Get Saldo
//Create Transferencia