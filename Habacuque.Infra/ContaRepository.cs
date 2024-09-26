using Habacuque.Domain;

namespace Habacuque.Infra;

public class ContaRepository
{
    public async Task<Conta> Add(Conta conta)
    {
        conta.AlterarId();
        return await Task.FromResult(conta);
    }

    public async Task<Conta> Find(int id)
    {
        return await Task.FromResult(new Conta(id, string.Empty));
    }

    public async Task<Conta> Update(Conta conta)
    {
        Conta alterada = new Conta(conta.Numero);
        alterada.AlterarId();
        return await Task.FromResult(alterada);
    }
}