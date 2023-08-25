
public class Pessoa
{
    public string nome;
    public string cpf;
    public string email;
    public DateOnly dataN;

    public int CalcularIdade()
    {
        int idade = DateTime.Now.Year - dataN.Year;
        return idade;
    }
}