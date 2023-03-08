using ConcessionariaXCars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaXCars.Classes
{
    public class Venda : IVenda
    {
        public Cliente Cliente { get; private set; }
        public string NotaFiscal { get; private set; }
        public DateTime DataVenda { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public decimal ValorDesconto { get; private set; }

        public decimal ValorVenda
        {
            get
            {
                return Veiculo.PrecoOriginal - ValorDesconto;
            }
        }

        public Venda SetVenda(Veiculo veiculo, Cliente cliente, decimal desconto)
        {
            Veiculo = veiculo;
            Cliente = cliente;
            ValorDesconto = desconto;
            DataVenda = DateTime.Now;
            NotaFiscal = GetNotaFiscal();

            return this;
        }

        public string GetNotaFiscal()
        {
            string caracteres = @"abcdefghijkklmnopqrstuvwxyz1234567890";

            Random random = new Random();
            string notaFiscal = caracteres[random.Next(35)].ToString() +
                caracteres[random.Next(35)].ToString() +
                caracteres[random.Next(35)].ToString() +
                caracteres[random.Next(35)].ToString() +
                caracteres[random.Next(35)].ToString() +
                caracteres[random.Next(35)].ToString();

            return notaFiscal;
        }
    }
}
