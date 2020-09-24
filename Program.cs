using System;
using System.Collections.Generic;
using System.Xml;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace MediaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;  //Declaração das variáveis.

            p1 = new Pessoa();   //Atribuição de classe.
            p2 = new Pessoa();

            Console.Write("Informe o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Informe o salário: ");
            p1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Informe o salário: ");
            p2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("A média dos salários é: " + ((p1.Salario + p2.Salario) / 2).ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
