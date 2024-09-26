using Habacuque.Application;
using Habacuque.Application.Features.Contas;
using Habacuque.Domain;
using Habacuque.Infra;

namespace Habacuque.Tests;

public class ContaCreateHandlerUnitTest
{
    private readonly IFixture _fixture = new Fixture().Customize(new AutoMoqCustomization { ConfigureMembers = true });
    private readonly ContaCreateHandler _sut;
    private readonly CriacaoContaCommand _command;
    public ContaCreateHandlerUnitTest()
    {
        _command = _fixture.Create<CriacaoContaCommand>();
        _sut = _fixture.Build<ContaCreateHandler>()
            .OmitAutoProperties()
            .Create();        
    }

    [Fact]
    public async Task Handle_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = await _sut.Handle(_command);
        //
        poupanca.Should().NotBeNull();
        poupanca.Id.Should().Be(1);
    }
}

public class ContaUpdateHandlerUnitTest
{
    private readonly IFixture _fixture = new Fixture().Customize(new AutoMoqCustomization { ConfigureMembers = true });
    private readonly ContaUpdateHandler _sut;
    public ContaUpdateHandlerUnitTest()
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
        poupanca.Id.Should().Be(1);
    }
}
public class ContaFindHandlerUnitTest
{
    [Fact]
    public async Task Handle_ContaComDadosCorreto_RetornaId()
    {
        Conta poupanca = new Conta(0, "1234");
        poupanca = await new ContaRepository().Add(poupanca);
        Conta poupancabuscada = await new ContaQueryHandler().Handle(poupanca.Id);
        
        poupancabuscada.Should().NotBeNull();
        poupancabuscada.Id.Should().Be(poupanca.Id);
        poupancabuscada.Id.Should().Be(1);
    }
}
