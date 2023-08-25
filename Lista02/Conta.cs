/*Criei uma classe conta que possui os seguintes atributos: Nome do
titular, um número da agencia, o número da conta e o saldo da conta.*/
/*Crie um construtor da classe conta, obrigando o fornecimento dos
valores de todos os atributos.*/

public class Conta
{
    public string nomeTitular;
    public string numeroAgencia;
    public string numeroConta;
    private double saldoConta;

    public double GetSaldoConta()
    {
        return saldoConta;
    }
    public void SetSaldoConta(double saldoConta)
    {
        if(saldoConta > 0)
        {
            this.saldoConta = saldoConta;
        }
        
    }

    public void SetNomeTitular(string titular)
    {
        if (!String.IsNullOrWhiteSpace(titular))
        {
            this.nomeTitular = titular;
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }
    }

    public String GetNomeTitular()
    {
        return nomeTitular;
    }

    public Conta()
    {

    }
    public Conta(string nomeTitular, string numeroAgencia, string numeroConta, double saldoConta)
    {
        this.SetNomeTitular(nomeTitular);
        this.numeroAgencia = numeroAgencia;
        this.numeroConta = numeroConta;
        this.saldoConta = saldoConta;
    }

    public double Depositar(double valor)
    {
        if(valor > 0)
        {
            this.saldoConta += valor;
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }
        return saldoConta;
    }

    public double Sacar(double valor)
    {
        if(valor <= this.saldoConta && valor > 0)
        {
            this.saldoConta -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor negativo");
        }
        return this.saldoConta;
    }

    public override string ToString()
    {
        return this.nomeTitular+" "+this.saldoConta;
    }
}