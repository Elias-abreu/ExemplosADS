using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGabarito.Classes
{
    internal class Gabarito
    {
        //Essa lista de char será responsável por armazenar as 
        //alternativas corretas
        public List<char> AlternativasCorretas;

        //Criação do método construtor
        //Esse método vai "obrigar" informar as alternativas corretas
        public  Gabarito(List<char> altCorretas) { 
           AlternativasCorretas = altCorretas;
        }

        //O méodo vai receber o int que representa o número da questão
        //e irá retornar a alternativa correta da questão;
        //Cuidado! caso o int seja informado pelo usuário, deve-se fazer 
        //nquestao - 1. Não codifiquei aqui, pois esse método será utilizado
        //na classe prova.
        public char RespostaQuestao(int nquestao)
        {
            return AlternativasCorretas[nquestao];
        }

    }
}
