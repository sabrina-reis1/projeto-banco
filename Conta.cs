public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        if(valor > Saldo)
        {
            throw new ArgumentException("");
        }
        Saldo = Saldo - valor;
    }

    public void Depositar(double valor)
    {
        Saldo = Saldo + valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        if(valor > Saldo)
        {
            throw new ArgumentException("");
        }

        Saldo = Saldo - valor; 
        conta.Saldo = conta.Saldo + valor;
    }
}