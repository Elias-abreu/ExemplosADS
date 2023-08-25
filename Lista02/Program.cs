
string nomeT = Console.ReadLine();

Conta c = new Conta(nomeT, "01","001",0);

string novoNome = Console.ReadLine();
c.SetNomeTitular(novoNome);

Console.WriteLine(c.GetNomeTitular());





/*
List<Conta> contas = new List<Conta>();
Conta c2 = new Conta();
c2.SetNomeTitular("Elias");
c2.numeroConta = "01";
contas.Add(c2);

Conta c3 = new Conta();
c3.SetNomeTitular("Elias 2");
c3.numeroConta = "02";
contas.Add(c3);

int index = contas.FindIndex(x => x.numeroConta == "02");
Conta c4 = contas.ElementAt(index);
Console.WriteLine("N "+ c4.nomeTitular);
*/
/*
List <Conta> contas = new List<Conta>();
while (true)
{
    Console.WriteLine("Digite 1 para cadastrar uma conta, 2 para listar todos");
    int opcao = Convert.ToInt32(Console.ReadLine());    
    if(opcao == 1)
    {
        Console.WriteLine("Informe o titular, agência, conta e o saldo");
        string titular = Console.ReadLine();
        string agencia = Console.ReadLine();
        string conta = Console.ReadLine();
        double saldo = Convert.ToDouble(Console.ReadLine());
        Conta c = new Conta(titular,agencia,conta,saldo);
        contas.Add(c);
    }else if(opcao == 2)
    {
        foreach(Conta conta in contas)
        {
            //Console.WriteLine($"Titular {conta.nomeTitular}, saldo {conta.saldoConta}");
            Console.WriteLine(conta.ToString());
        }
    }
    else
    {
        break;
    }

}

*/