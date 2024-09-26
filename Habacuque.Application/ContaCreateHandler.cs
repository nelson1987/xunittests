using Habacuque.Application.Features.Contas;
using Habacuque.Domain;
using Habacuque.Infra;

namespace Habacuque.Application;

public class ContaCreateHandler
{
    public async Task<Conta> Handle(CriacaoContaCommand command)
    {
        Conta poupanca = new Conta(0, command.Numero);
        await new ContaRepository().Add(poupanca);
        return poupanca;
    }
}

public class ContaUpdateHandler
{
    public async Task<Conta> Handle()
    {
        Conta poupanca = new Conta(0, "1234");
        await new ContaRepository().Update(poupanca);
        return poupanca;
    }
}
public class ContaQueryHandler
{
    public async Task<Conta> Handle(int id)
    {
        return await new ContaRepository().Find(id);
    }
}