using ConcessionariaXCars.Enums;

namespace ConcessionariaXCars.Classes
{
    public class Moto : Veiculo
    {
        public Moto(int cilindrada,
            int quantidadeMarchas,
            TipoMoto tipoMoto,
            string modelo,
            string placa,
            string cor,
            decimal precoOriginal,
            int ano,
            string marca,
            TipoCombustivel combustivel) : base(modelo,
                placa,
                cor,
                precoOriginal,
                ano,
                marca,
                combustivel,
                TipoVeiculo.Moto)
        {
            Cilindrada = cilindrada;
            QuantidadeMarchas = quantidadeMarchas;
            TipoMoto = tipoMoto;
        }

        public int Cilindrada { get; private set; }
        public int QuantidadeMarchas { get; private set; }
        public TipoMoto TipoMoto { get; private set; }
    }
}
