using Habacuque.Api.Controllers;
using Habacuque.Application.Features.Contas;
using Habacuque.Domain;

namespace Habacuque.Tests;

public class ContaControllerUnitTest
{
    private readonly IFixture _fixture = new Fixture().Customize(new AutoMoqCustomization { ConfigureMembers = true });
    private readonly ContaController _sut;
    private readonly CriacaoContaCommand _command;

    public ContaControllerUnitTest()
    {
        _command = _fixture.Create<CriacaoContaCommand>();
        _sut = _fixture.Build<ContaController>()
            .OmitAutoProperties()
            .Create();
    }

    [Fact]
    public async Task Post_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = await _sut.Post(_command);
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(1);
    }
}