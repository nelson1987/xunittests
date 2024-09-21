namespace Habacuque.Domain;

public class Conta
{
    public Conta(int id, string numero)
    {
        Id = id;
        Numero = numero;
    }

    public int Id { get; private set; }
    public string Numero { get; private set; }

    public void AlterarId()
    {
        Id = 1;
    }
}

