

public class Aluno
{
    public string nome;
    public string cpf;
    public string matricula;
    public DateOnly dataNasc;
   
    public Aluno(string nome, string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
    }


    public double Media(double n1, double n2)
    {
        double media = (n1 + n2) / 2;
        return media;
    }
}
