using Habacuque.Domain;
using Habacuque.Infra;

namespace Habacuque.Application;

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
