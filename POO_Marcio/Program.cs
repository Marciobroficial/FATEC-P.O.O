using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Marcio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bom Dia!");
            //Console.ReadKey();
           /* Console.WriteLine("Informe o Ano de Nascimento");
            int anoNascimento = Convert.ToInt32(Console.ReadLine()); 
            int idade = 2021 - anoNascimento; 
            Console.WriteLine("\nSua idade é: " + idade   );
            if (idade >= 18)
            {
                Console.WriteLine("Você é. ");
                Console.WriteLine("Maior de idade ");
            }
            else // if (Condição)
                
                Console.WriteLine("Menor de idade. ");
           */
            int mes = 5;
            switch(mes) // mes == 1
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;

                default: // else
                    Console.WriteLine("Mês Inválido");
                    break;
            }
            int mess = 5;
            if (mess == 5)
                Console.WriteLine("Janeiro");
            else if (mess == 2)
                Console.WriteLine("Fevereiro");
            else 
                Console.WriteLine("Mês invalido... if");

            Console.WriteLine("\nExemplo do comando for");
            int i;
            for ( i = 0; i < 5; i++)// i++ = i + 1 incremento 
                Console.WriteLine("Valor de i; " + i);

            Console.WriteLine("\nExmplo de comando while");
            i = 0; // inicialização
            while (i < 5) // condição de parada, ou critério de parada
            {
                Console.WriteLine("Valor de i: " + i);
                i++; //incremento sempre deve ser implementado na ÚTIMA LINHA.
            }
            Console.WriteLine("\nExmplo de comando do .. while");
            i = 0; // inicialização
            do
            {
                Console.Write("Valor de i: " + i);
                i++; //incremento sempre deve ser implementado na ÚTIMA LINHA.
            } while (i < 5);


            Console.Write("Digite uma idade: ");
            int idade = Convert.toInt32(Console.ReadLine()); // inicialização
            int soma = 0;
            i = 0;

            while (idade > 0) // condição de parada, ou critério de parada
            {
                soma += idade;
                i += 1;
                Console.WriteLine("Digite uma idade: ");
                idade = Convert.toInt32(Console.ReadLine()); // inicialização
            }
            Console.WriteLine(" O Resultado é = "+)
            Console.ReadKey();
        }
    }
}
  