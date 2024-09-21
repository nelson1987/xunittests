using FluentAssertions;
using Habacuque.Domain;

namespace Habacuque.Tests;

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