using ConcessionariaXCars.Classes;

namespace ConcessionariaXCars.Interfaces
{
    public interface IVenda
    {
        Venda SetVenda(Veiculo veiculo, Cliente cliente, decimal desconto);
    }
}
