
using System;
public  static class Validacao
{
    public static bool ValidarCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace(",","");
        cpf = cpf.Replace("-", "");

        if(cpf.Length != 11)
        {
           return false;
        }
        //Validar 1º digito
        int soma = 0;
        for (int i = 0; i< 9;i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * (10-i);
        }

        int res = soma % 11;

        if(res < 2)
        {
            if (Convert.ToInt32(cpf[9].ToString()) != 0)
            {
                return false;
            }
        }
        else
        {
            if (Convert.ToInt32(cpf[9].ToString()) != (11-res))
            {
                return false;
            }
        }


        //Validar 2º digito
        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += Convert.ToInt32(cpf[i].ToString()) * (11 - i);
        }

        res = soma % 11;

        if (res < 2)
        {
            if (Convert.ToInt32(cpf[10].ToString()) != 0)
            {
                return false;
            }
        }
        else
        {
            if (Convert.ToInt32(cpf[10].ToString()) != (11 - res))
            {
                return false;
            }
        }
        return true;
    }
}