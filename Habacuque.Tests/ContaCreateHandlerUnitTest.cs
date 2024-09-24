using FluentAssertions;
using Habacuque.Application;
using Habacuque.Domain;

namespace Habacuque.Tests;

public class ContaCreateHandlerUnitTest
{
    private readonly IFixture _fixture = new Fixture().Customize(new AutoMoqCustomization { ConfigureMembers = true });
    private readonly ContaCreateHandler _sut;
    public ContaCreateHandlerUnitTest()
    {
        _sut = _fixture.Build<ContaCreateHandler>()
            .OmitAutoProperties()
            .Create();        
    }

    [Fact]
    public async Task Handle_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = await _sut.Handle();
        //
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(1);
    }
}

public class ContaUpdateHandlerUnitTest
{
    private readonly IFixture _fixture = new Fixture().Customize(new AutoMoqCustomization { ConfigureMembers = true });
    private readonly ContaUpdateHandler _sut;
    public ContaCreateHandlerUnitTest()
    {
        _sut = _fixture.Build<ContaUpdateHandler>()
            .OmitAutoProperties()
            .Create();
    }

    [Fact]
    public async Task Handle_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = await _sut.Handle();
        //
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(0);
    }
}
