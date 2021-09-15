using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {          
            Aluno[] vAluno = new Aluno[3];
            for (int i = 0; i < vAluno.Length; i++)
            {
                Console.Write("\nInforme o nome do aluno: ");
                string Nome = Console.ReadLine();
                Console.Write("Informe a idade do aluno: ");
                int Idade = Convert.ToInt32(Console.ReadLine());
                long Ra = Aluno.Contador;
                vAluno[i] = new Aluno(Ra, Nome, Idade);
                Console.WriteLine("RA: " + Aluno.Contador);
            }
            Console.WriteLine(" ");
            foreach (Aluno va in vAluno)
                va.MostrarAtributos();
            Console.WriteLine();
            Console.WriteLine("Quantidade de instâncias? " + (Aluno.Contador - 1570482121000));
            Console.ReadKey();
        }
    }
}
