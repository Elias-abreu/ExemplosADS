
public class Program
{
    static void Main(string[] args)
    {
        List<Aluno> listaAlunos = new List<Aluno>();
        while (true)
        {
            Console.WriteLine("1 - Cadastrar novo aluno, 2 - parar");
            int opcao = Convert.ToInt32(Console.ReadLine());
            if(opcao == 2)
            {
                break;
            }
            else
            {
                string nome = Console.ReadLine();
                string cpf = Console.ReadLine();
                Aluno aluno1 = new Aluno(nome, cpf);
                listaAlunos.Add(aluno1);
            }
        }
        foreach (Aluno aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.nome} {aluno.cpf}");
        }

    }
}