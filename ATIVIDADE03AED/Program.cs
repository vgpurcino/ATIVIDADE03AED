using ATIVIDADE03AED;
using System;
using System.Globalization;
namespace atividade03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor v = new Vendedor();

            Console.WriteLine("Digite o nome do vendedor: ");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário fixo do vendedor: ");
            v.SalarioFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total em vendas: ");
            v.TotalVendas = double.Parse(Console.ReadLine());
            v.imprimirDados();
        }
    }
}