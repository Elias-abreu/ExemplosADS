


using AtividadeGabarito.Classes;

public class Program
{
    static void Main(string[] args)
    {
        //Criar uma lista das alternativas corretas para passar para o
        //Construtor da classe Gabarito
        List<char> gab = new List<char>{'A','E','C','D',
        'A','C','D','E','E','A'};

        //Cria uma instância da classe gabarito (objeto)
        //Essa classe possui um construtor que recebe por parâmetro
        //uma lista de char, que representa as alternativas corretas das 
        //questões
        Gabarito g = new Gabarito(gab);

        Prova pAdressa = new Prova(g);
      

        for (int i = 0; i< gab.Count; i++)
        {
            Console.WriteLine($"Informe a resposta da questão {i+1}");
            pAdressa.RespostaAluno(Convert.ToChar(Console.ReadLine()));
        }

        Console.WriteLine($"A quantidade de acertos é {pAdressa.Acertos()}");
        Console.WriteLine($"A nota é {pAdressa.Nota()}");
    }
}

