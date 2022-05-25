using System.Globalization;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes operacoes = new Operacoes();

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
                operacoes.Adicao();
            }
            else if (op == 2)
            {
                operacoes.Subtracao();
            }
            else if (op == 3)
            {
                operacoes.Multiplicacao();
            }
            else if (op == 4)
            {
                operacoes.Divisao();
            }
            else if (op == 5)
            {
                operacoes.Raiz();
            }
            else if (op == 6)
            {
                operacoes.Potenciacao();
            }
            else Console.WriteLine("Programa encerrado");
        }
    }
}