using FluentAssertions;

namespace Habacuque.Tests;
public class Conta
{
    public Conta(int id, string numero)
    {
        Id = id;
        Numero = numero;
    }

    public int Id { get; private set; }
    public string Numero { get; private set; }

    internal void AlterarId()
    {
        Id = 1;
    }
}
public class ContaRepository
{
    public async Task<Conta> Add(Conta conta)
    {
        conta.AlterarId();
        return conta;
    }
}
public class ContaCreateHandler
{
    public async Task<Conta> Handle()
    {
        Conta poupanca = new Conta(0, "1234");
        ContaRepository contaRepository = new ContaRepository();
        await contaRepository.Add(poupanca);
        return poupanca;
    }
}
public class ContaController
{
    public async Task<Conta> Post()
    {
        ContaCreateHandler handler = new ContaCreateHandler();
        return await handler.Handle();
    }
}
public class UnitTest1
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
}
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
public class ContaControllerUnitTest
{
    [Fact]
    public async Task Post_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = await new ContaController().Post();
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(1);
    }
}