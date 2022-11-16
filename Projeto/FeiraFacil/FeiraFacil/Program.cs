using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraFacil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor escolha a opção:\n1.Login \n2.Sair\nOpção: ");
            String l = Console.ReadLine();

            switch (l)
            {
                case "1":
                    Console.Write("Escolheu 1");
                    Console.Read();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Escolha não suportada");
                    Console.Read();
                    break;
            }


        }
    }
}
