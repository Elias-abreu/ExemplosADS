
Titular t = new Titular();
t.nome = "Elias";
t.cpf = "053";
t.email = "elias.silva";
t.sexo = "M";

Conta c = new Conta();
c.numeroConta = "01";
c.numeroAgencia = "0184-8";
c.SetSaldoConta(0);
c.titularConta = t;

List<Conta> contas = new List<Conta>();
contas.Add(c);


foreach(Conta conta in contas)
{
    //Console.WriteLine(conta.titularConta.nome);
}

List<string> list = new List<string>();
list.Add("A");
list.Add("B");
list.Add("A");
list.Add("E");
int questao = 3;
Console.WriteLine(list[questao-1]);
