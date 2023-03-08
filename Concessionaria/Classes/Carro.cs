using ConcessionariaXCars.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaXCars.Classes
{
    public class Carro : Veiculo
    {
        public Carro(int quantidadePortas, 
            bool arCondicionado, 
            TipoCarro tipo,
            bool automatico, 
            string motor, 
            string modelo,
            string placa,
            string cor,
            decimal precoOriginal,
            int ano,
            string marca,
            TipoCombustivel combustivel) : base (modelo, placa, cor, precoOriginal, ano, marca, combustivel, TipoVeiculo.Carro)
        {
            QuantidadePortas = quantidadePortas;
            ArCondicionado = arCondicionado;
            Tipo = tipo;
            Automatico = automatico;
            Motor = motor;

        }

        public int QuantidadePortas { get; private set; }
        public bool ArCondicionado { get; private set; }
        public TipoCarro Tipo { get; private set; }
        public bool Automatico { get; private set; }
        public string Motor { get; private set; }
        public Direcao Direcao { get; private set; }
    }
}
