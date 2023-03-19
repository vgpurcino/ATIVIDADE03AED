using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE03AED
{
    internal class Vendedor
    {
        private string nome;
        private double salarioFixo;
        private double totalVendas;
        private double valorComissao = 0.15;



        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        public double SalarioFixo
        {
            get 
            { 
            return salarioFixo; 
            }
            set
            {
                salarioFixo = value;
            }
        }
        public double TotalVendas 
        {
            get
            {
                return totalVendas;
            }
            set
            {
                totalVendas = value;
            }
        }
        public void imprimirDados()
        {
            double salarioFinal = salarioFixo + (totalVendas * valorComissao);
            Console.WriteLine($"{nome} recebeu de salário + comissão R$ {salarioFinal:0.00}");
        }
    }

}
