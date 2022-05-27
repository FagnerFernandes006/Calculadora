using System.Globalization;

namespace Desafio2
{
    public class Operacoes
    {
        public static void Adicao()
        {
            Console.Clear();
            Console.WriteLine("Operação Adição");
            Console.WriteLine("-----------------");
            Console.Write("Digite Dois números: ");
            string[] vect = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double resultado = n1 + n2;
            Console.WriteLine("Resultado: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Operação Subtração");
            Console.WriteLine("-----------------");
            Console.Write("Digite Dois números: ");
            string[] vect = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double resultado = n1 - n2;
            Console.WriteLine("Resultado: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Operação Multiplicação");
            Console.WriteLine("-----------------");
            Console.Write("Digite Dois números: ");
            string[] vect = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double resultado = n1 * n2;
            Console.WriteLine("Resultado: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Operação Divisão");
            Console.WriteLine("-----------------");
            Console.Write("Digite Dois números: ");
            string[] vect = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double resultado = n1 / n2;
            Console.WriteLine("Resultado: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void Raiz()
        {
            Console.Clear();
            Console.WriteLine("Operação Raiz Quadrada");
            Console.WriteLine("-----------------");
            Console.Write("Digite um número: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = Math.Sqrt(n);
            Console.WriteLine("Resultado: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void Potenciacao()
        {
            Console.Clear();
            Console.WriteLine("Operação Potenciação");
            Console.WriteLine("-----------------");
            Console.Write("Digite dois números: ");
            string[] vect = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double resultado = Math.Pow(n1, n2);
            Console.WriteLine("Resultado: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
