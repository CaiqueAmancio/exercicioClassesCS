using System;
using System.Globalization;

namespace exercicio3MembrosEClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Nome do Aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do Aluno: ");
            x.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("NOTA FINAL: " + x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            if (x.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + x.NotaFalta().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS.");
            }
        }
    }
}
