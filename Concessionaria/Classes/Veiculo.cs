using ConcessionariaXCars.Enums;

namespace ConcessionariaXCars.Classes
{
    public class Veiculo
    {
        public Veiculo(string modelo,
            string placa,
            string cor,
            decimal precoOriginal,
            int ano,
            string marca,
            TipoCombustivel combustivel,
            TipoVeiculo tipoVeiculo)
        {
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            PrecoOriginal = precoOriginal;
            Ano = ano;
            Marca = marca;
            Combustivel = combustivel;
            TipoVeiculo = tipoVeiculo;
        }

        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public decimal PrecoOriginal { get; private set; }
        public int Ano { get; private set; }
        public string Marca { get; private set; }
        public TipoCombustivel Combustivel { get; private set; }
        public TipoVeiculo TipoVeiculo { get; private set; }
    }
}
