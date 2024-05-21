using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleFormaFuncao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a forma geométrica:(Quadrado, Retângulo, Trapézio, Losango): ");
            string forma = (Console.ReadLine());

            switch (forma)
            {
                case "Quadrado":
                    Console.Clear();
                    Console.WriteLine("Você escolheu: Quadrado");
                    quadrado();
                    Console.ReadKey();
                    break;

                case "Retângulo":
                    Console.Clear();
                    Console.WriteLine("Você escolheu: Retângulo");
                    retangulo();
                    Console.ReadKey();
                    break;

                case "Trapézio":
                    Console.Clear();
                    Console.WriteLine("Você escolheu: Trapézio");
                    trapezio();
                    Console.ReadKey();
                    break;

                case "Losango":
                    Console.Clear();
                    Console.WriteLine("Você escolheu: Losango");
                    losango();
                    Console.ReadKey();
                    break;

                default:
                    Console.Clear();
                    Console.Write("Opção inválida");
                    Console.ReadKey();
                    break;
            }
        }
        static void quadrado()
        {
            Console.Write("Insira o valor do lado do quadrado: ");
            double qlado = Convert.ToDouble(Console.ReadLine());
            Double qarea = qlado * qlado;
            Console.Write("A área do quadrado é: " + qarea);
        }

        static void retangulo()
        {
            Console.Write("Insira o valor do primeiro lado do retângulo: ");
            double rlado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor do segundo lado do retângulo: ");
            double rlado2 = Convert.ToDouble(Console.ReadLine());
            Double rarea = rlado1 * rlado2;
            Console.Write("A área do retângulo é: " + rarea);
        }

        static void trapezio()
        {
            Console.Write("Insira o valor da base maior do trapézio: ");
            double tmaior = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor da base menor do trapézio: ");
            double tmenor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor da altura do trapézio: ");
            double taltura = Convert.ToDouble(Console.ReadLine());
            Double tarea = ((tmaior + tmenor) * taltura) / 2;
            Console.Write("A área do trapézio é: " + tarea);
        }

        static void losango()
        {
            Console.Write("Insira o valor da diagonal maior do losango: ");
            double lmaior = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor da diagonal menor do losango: ");
            double lmenor = Convert.ToDouble(Console.ReadLine());
            Double larea = (lmaior * lmenor) / 2;
            Console.Write("A área do losango é: " + larea);
        }
    }
}