using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_While_e_Do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Questão 1

            //char caract;

            do
            {
                Console.Write("Digite um caracter: ");
                caract = Console.ReadKey().KeyChar;
            } while (caract != 's');

            Console.ReadKey();


            // Questão 2


            string nome;
            int quant;
            int cont = 1;
            int contCem = 1;
            double produto;

            Console.Write("Digite a quantidade de produtos: ");
            quant = int.Parse(Console.ReadLine());

            while (quant >= cont)
            {
                Console.Write("Digite o valor do produto: ");
                produto = double.Parse(Console.ReadLine());

                if (produto > 100)
                {
                    contCem += 1;
                }

                cont += 1;
            }

            Console.Write("A quantidade de produtos que custam acima de R$100 é de: " + contCem);

            Console.ReadKey();


            // Questão 3


            int cont = 0;
            int parar;
            int cont36 = 0;
            int cont38 = 0;
            int cont40 = 0;
            int cont42 = 0;
            int cont44 = 0;

            do
            {
                Console.Write("Digite o numero dos calçados 36, 38, 40, 42 e 44 ou a tecla 1 para parar: ");
                parar = int.Parse(Console.ReadLine());

                if (parar == 36)
                {
                    cont36 += 1;
                }

                else if (parar == 38)
                {
                    cont38 += 1;
                }

                else if (parar == 40)
                {
                    cont40 += 1;
                }

                else if (parar == 42)
                {
                    cont42 += 1;
                }

                else if (parar == 44)
                {
                    cont44 += 1;
                }

                cont += 1;
            } while (parar != 1);

            Console.Write("");

            Console.ReadKey(); 

            // Questão 4


            double parar;
            double cont17 = 0;
            double cont18 = 0;

            do
            {
                Console.Write("Digite a altura dos alunos ou digite 0 para parar: ");
                parar = double.Parse(Console.ReadLine());

                if (parar > 1.7)
                {
                    cont17 += 1;
                }

                else if (parar < 1.8 && parar > 0)
                {
                    cont18 += 1;
                }

            } while (parar != 0);

            Console.WriteLine("altura superior a 1.70: " + cont17);
            Console.WriteLine("altura  menor que 1.80: " + cont18);

            Console.ReadKey();
        }
    }
}

