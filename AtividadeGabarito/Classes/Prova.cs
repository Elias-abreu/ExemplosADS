using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGabarito.Classes
{
    internal class Prova
    {
        public Gabarito Gab { get; set; }
        public List<char> AlternativasAluno  { get; set; }

        public Prova(Gabarito gabarito)
        {
            Gab = gabarito;
            AlternativasAluno = new List<char>();
        }

        public bool RespostaAluno(char res)
        {
            if(AlternativasAluno.Count < Gab.AlternativasCorretas.Count)
            {
                AlternativasAluno.Add(res);
                return true;
            }
            return false;
        }

        public int Acertos()
        {
            int qtdAcertos = 0;
            for(int i = 0; i < Gab.AlternativasCorretas.Count; i++) 
            {
                if (AlternativasAluno[i].ToString().ToUpper() == 
                    Gab.AlternativasCorretas[i].ToString().ToUpper())
                {
                    qtdAcertos++;
                }
            } 
            return qtdAcertos;
        }

        public double Nota()
        {
            double nota = (100 / Gab.AlternativasCorretas.Count) * this.Acertos();
            return nota;
        }

        public Prova Maior(Prova v)
        {
            if (v.Nota() > this.Nota())
            {
                return v;
            }
            else{ return this;}
        }

        public static (double,int) MaiorLista(List<Prova> lista)
        {
            Prova v = lista.OrderByDescending(x => x.Nota()).FirstOrDefault();
            return (v.Nota(),v.Acertos());
        }
    }
}
