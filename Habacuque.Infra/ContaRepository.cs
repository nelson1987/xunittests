using Habacuque.Domain;

namespace Habacuque.Infra;

public class ContaRepository
{
    public async Task<Conta> Add(Conta conta)
    {
        conta.AlterarId();
        return conta;
    }
}