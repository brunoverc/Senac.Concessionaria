using ConcessionariaXCars.Enums;

namespace ConcessionariaXCars.Classes
{
    public class Caminhao : Veiculo
    {
        public Caminhao(int eixos,
            decimal carga,
            int marchas,
            string modelo,
            string placa,
            string cor,
            decimal precoOriginal,
            int ano,
            string marca,
            TipoCombustivel combustivel) : base(modelo, placa, cor, precoOriginal, ano, marca, combustivel, TipoVeiculo.Caminhao)
        {
            Eixos = eixos;
            Carga = carga;
            Marchas = marchas;
        }

        public int Eixos { get; private set; }
        public decimal Carga { get; private set; }
        public int Marchas { get; private set; }
    }
}
