using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTownSQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------- SORVETERIA TownSQ --------------------");
            Console.WriteLine("Estamos fazendo uma pesquisa para descobrir qual dos cinco sabores " +
                "que servimos é o mais popular." +
                "\nAs opções de sabor são: Flocos, Chocolate, Morango, Creme e Napolitano.");


            Console.WriteLine("\nOs sabores são mapeados para códigos de acordo com a seguinte tabela:" +
                "\n0 - Flocos\n1 - Chocolate\n2 - Morango\n3 - Creme\n4 - Napolitano");

            bool votoIncorreto = false;

            do
            {
                Console.WriteLine("Insira um array de acordo com o exemplo a seguir: 0, 1, 2, 3...");

                string input = Console.ReadLine();

                string[] arrS = input.Split(',');

                int[] arr = new int[arrS.Length];

                for (int i = 0; i < arrS.Length; i++)
                {
                    
                    if (!int.TryParse(arrS[i], out arr[i]) || arr[i] < 0 || arr[i] > 4)
                    {
                        Console.WriteLine("Você digitou um voto incorreto. Vamos tentar novamente.");
                        votoIncorreto = true;
                        break;
                    }
                    else
                        votoIncorreto=false;
                }

                if (!votoIncorreto)
                    Console.WriteLine(MaisPopular(arr, arr.Length));


            } while (votoIncorreto);

            Console.ReadKey();
        }


        public static int MaisPopular(int[] arr, int tam)
        {
            int max = 0;
            int maisPopular = 0;

            for (int i = 0; i < tam; i++)
            {
                int contador = 0;
                for (int j = 0; j < tam; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        contador++;
                    }
                }

                if (contador > max)
                {
                    max = contador;
                    maisPopular = arr[i];
                }
                else if (contador == max && maisPopular > arr[i])
                {
                    maisPopular = arr[i];
                }
            }

            return maisPopular;
        }
    }
}
