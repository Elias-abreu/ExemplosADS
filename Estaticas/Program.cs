
using System.Threading.Channels;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o CPF:");
        string cpf = Console.ReadLine();

        bool retorno = Validacao.ValidarCPF(cpf);
        Console.WriteLine(retorno);
    }
}