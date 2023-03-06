namespace ConcessionariaXCars.Classes
{
    public class Endereco
    {
        public Endereco(string logradouro, 
            string cep, 
            string complemento, 
            string numero, 
            string bairro, 
            string cidade, 
            string uF)
        {
            Logradouro = logradouro;
            CEP = cep;
            Complemento = complemento;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }

        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Complemento { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }

    }
}