using Habacuque.Domain;

namespace Habacuque.Infra;

public class ContaRepository
{
    public async Task<Conta> Add(Conta conta)
    {
        conta.AlterarId();
        return conta;
    }

    public async Task<Conta> Find(Conta conta)
    {
        return conta;
    }

    public async Task<Conta> Update(Conta conta)
    {
        return conta;
    }
}