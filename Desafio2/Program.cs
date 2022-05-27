using System.Globalization;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação você deseja fazer? ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Raiz Quadrada");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("-------------------");
            Console.Write("Operação: ");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Operacoes.Adicao();
            }
            else if (op == 2)
            {
                Operacoes.Subtracao();
            }
            else if (op == 3)
            {
                Operacoes.Multiplicacao();
            }
            else if (op == 4)
            {
                Operacoes.Divisao();
            }
            else if (op == 5)
            {
                Operacoes.Raiz();
            }
            else if (op == 6)
            {
                Operacoes.Potenciacao();
            }
            else Console.WriteLine("Programa encerrado");
        }
    }
}