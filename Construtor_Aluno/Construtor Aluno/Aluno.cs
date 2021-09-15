using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor_Aluno
{
    class Aluno
    {
        private long ra;
        private string nome;
        private double idade;
        private static long contador = 1570482121000;

        public static long Contador
        {
            get
            {
                return contador;
            }
        }
        public Aluno() 
        {
            contador = 1570482121001;
        }
        public Aluno(long ra)
        {
            this.ra = ra;
            contador ++;
        }
        public Aluno(double idade)
        {
            this.idade = idade;
            contador ++;
        }
        public Aluno(string nome)
        {
            this.nome = nome;
            contador ++;
        }
        public Aluno(long ra, string nome, double idade)
        {
            this.ra = ra;
            this.nome = nome;
            this.idade = idade;
            contador ++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("RA: " + ra + "\tNome: " + nome + "\tIdade: " + idade + "");
        }
    }
}
