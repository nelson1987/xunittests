using FluentAssertions;
using Habacuque.Domain;

namespace Habacuque.Tests;
public class EntitiesUnitTests
{
    private readonly IFixture _fixture = new Fixture().Customize(new AutoMoqCustomization { ConfigureMembers = true });
    private readonly Conta _poupanca;

    [Fact(DisplayName = "Teste inicial de Adicao de Conta")]
    public async Task Post_AddConta()
    {
        // _poupanca = _fixture.Build<Conta>()
        //     .With(x => x.Id, 0)
        //     .With(x => x.Numero,"1234")
        //     .Create();
        Conta poupanca = new Conta(0, "1234");

        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(0);
        poupanca.Numero.Should().Be("1234");
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