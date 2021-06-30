using System;
using System.Globalization;

namespace exercicio2Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios a, b;

            a = new Funcionarios();
            b = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (a.Salario + b.Salario) / 2;

            Console.Write($"Salário médio: {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
