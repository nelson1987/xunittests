using FluentAssertions;
using Habacuque.Domain;

namespace Habacuque.Tests;

public class ContaControllerUnitTest
{
    private readonly IFixture _fixture = new Fixture().Customize(new AutoMoqCustomization { ConfigureMembers = true });
    private readonly ContaController _sut;
    public ContaControllerUnitTest()
    {
        _sut = _fixture.Build<ContaController>()
            .OmitAutoProperties()
            .Create();
    }

    [Fact]
    public async Task Post_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = await _sut.Post();
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(1);
    }
}