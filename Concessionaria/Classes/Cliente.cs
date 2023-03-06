namespace ConcessionariaXCars.Classes
{
    public class Cliente
    {
        public Cliente(string nome, string cPF, Endereco endereco, string telefone)
        {
            Nome = nome;
            CPF = cPF;
            Endereco = endereco;
            Telefone = telefone;
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Telefone { get; private set; }

    }
}
