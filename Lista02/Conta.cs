/*Criei uma classe conta que possui os seguintes atributos: Nome do
titular, um número da agencia, o número da conta e o saldo da conta.*/
/*Crie um construtor da classe conta, obrigando o fornecimento dos
valores de todos os atributos.*/

public class Conta
{
    public Titular titularConta;


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




    public Conta()
    {
        
    }
    public Conta(string nomeTitular, string numeroAgencia, 
        string numeroConta, double saldoConta)
    {

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

}