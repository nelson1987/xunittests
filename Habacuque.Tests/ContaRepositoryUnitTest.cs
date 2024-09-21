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
}
