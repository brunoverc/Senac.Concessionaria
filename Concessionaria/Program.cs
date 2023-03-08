using ConcessionariaXCars.Classes;
using ConcessionariaXCars.Enums;
using System.Text;

List<Veiculo> veiculos = new List<Veiculo>();
List<Venda> vendasFeitas = new List<Venda>();

CarregarDados();

var opcao = 1000;

while (opcao != 0)
{
    Console.WriteLine(@"Digite a opção desejada:
1 para exibir veículos disponíveis.
2 para efetuar venda.
3 para verificar lista de vendas.
0 para sair");

    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine(@"Digite o tipo do veículo:
1 Motos
2 Carros
3 Caminhões");
            var opcaoTipoVeiculo = Convert.ToInt32(Console.ReadLine());
            switch (opcaoTipoVeiculo)
            {
                case 1:
                    Console.Write(ExibirVeiculos(TipoVeiculo.Moto));
                    break;
                case 2:
                    Console.Write(ExibirVeiculos(TipoVeiculo.Carro));
                    break;
                case 3:
                    Console.Write(ExibirVeiculos(TipoVeiculo.Caminhao));
                    break;
            }
            break;
        case 2:
            Console.WriteLine("Digite a placa do veículo");
            string placa = Console.ReadLine();

            var veiculo = veiculos.Where(v => v.Placa == placa).FirstOrDefault();

            Console.WriteLine("Digite o desconto");
            decimal desconto = Convert.ToDecimal(Console.ReadLine());

            var cliente =  SetCliente();

            var venda = new Venda().SetVenda(veiculo, cliente, desconto);

            //Colocar o veiculo na lista de vendas
            vendasFeitas.Add(venda);

            veiculos.Remove(veiculo);
            break;
        case 3:
            Console.WriteLine(GetVeiculosVendidos());
            break;
    }

}


void CarregarDados()
{

    //Carros
    veiculos.Add(new Carro(quantidadePortas: 5, arCondicionado: false, tipo: TipoCarro.Passeio, automatico: false,
        motor: "1.6", modelo: "Gol", placa: "P3G2143", cor: "Azul", precoOriginal: 50000,
        ano: 2010, marca: "Volkswagen", combustivel: TipoCombustivel.Gasolina));

    veiculos.Add(new Carro(quantidadePortas: 5, arCondicionado: true, tipo: TipoCarro.Passeio, automatico: true,
        motor: "1.3 turbo", modelo: "Cruze", placa: "0000000", cor: "Branco", precoOriginal: 150000,
        ano: 2022, marca: "Chevrolet", combustivel: TipoCombustivel.Flex));

    veiculos.Add(new Carro(quantidadePortas: 4, arCondicionado: true, tipo: TipoCarro.Utilitario, automatico: true,
        motor: "3.2", modelo: "Ranger", placa: "1111111", cor: "Preta", precoOriginal: 300000,
        ano: 2021, marca: "Ford", combustivel: TipoCombustivel.Diesel));

    //Motos
    veiculos.Add(new Moto(cilindrada: 300, quantidadeMarchas: 6, tipoMoto: TipoMoto.Naked, modelo: "CB300",
        placa: "2222222", cor: "Vermelha", precoOriginal: 40000, ano: 2023, marca: "Honda", combustivel: TipoCombustivel.Flex));

    veiculos.Add(new Moto(cilindrada: 125, quantidadeMarchas: 5, tipoMoto: TipoMoto.Street, modelo: "CG",
        placa: "3333333", cor: "Preta", precoOriginal: 18000, ano: 2022, marca: "Honda", combustivel: TipoCombustivel.Flex));

    veiculos.Add(new Moto(cilindrada: 125, quantidadeMarchas: 5, tipoMoto: TipoMoto.Street, modelo: "Factor",
        placa: "4444444", cor: "Preta", precoOriginal: 20000, ano: 2022, marca: "Yamaha", combustivel: TipoCombustivel.Flex));

    //Caminhões
    veiculos.Add(new Caminhao(eixos: 3, carga: 1200, marchas: 12, modelo: "Caminhao 1", placa: "5555555",
        cor: "Branco", precoOriginal: 500000, ano: 2020, marca: "Scania", combustivel: TipoCombustivel.Diesel));
}

string ExibirVeiculos(TipoVeiculo tipo)
{
    var listaAuxiliar = veiculos.Where(v => v.TipoVeiculo == tipo);

    StringBuilder result = new StringBuilder();

    foreach (var veiculo in listaAuxiliar)
    {
        result.AppendLine($"Placa: {veiculo.Placa} - Veiculo: {veiculo.Modelo}");
    }

    return result.ToString();
}

static Cliente SetCliente()
{
    Console.WriteLine("Digite o nome do cliente");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o CPF do cliente");
    string cpf = Console.ReadLine();

    Console.WriteLine("Digite telefone do cliente");
    string telefone = Console.ReadLine();

    //Endereço
    Console.WriteLine("Digite o logradouro do cliente");
    string logradouro = Console.ReadLine();

    Console.WriteLine("Digite o CEP do cliente");
    string cep = Console.ReadLine();

    Console.WriteLine("Digite o complemento do cliente");
    string complemento = Console.ReadLine();

    Console.WriteLine("Digite o número do cliente");
    string numero = Console.ReadLine();

    Console.WriteLine("Digite o brairro do cliente");
    string bairro = Console.ReadLine();

    Console.WriteLine("Digite a cidade do cliente");
    string cidade = Console.ReadLine();

    Console.WriteLine("Digite o estado do cliente");
    string uf = Console.ReadLine();

    var endereco = new Endereco(logradouro, cep, complemento, numero, bairro, cidade, uf);
    var cliente = new Cliente(nome, cpf, endereco, telefone);

    return cliente;
}

string GetVeiculosVendidos()
{
    StringBuilder sb = new StringBuilder();
    sb.AppendLine("---------- Vendas ----------");
    sb.AppendLine("Data venda \t\t\t Cliente \t Veículo \t Placa \t Valor");
    
    foreach(var venda in vendasFeitas)
    {
        sb.AppendLine($"{venda.DataVenda.ToShortDateString()}\t\t\t{venda.Cliente.Nome}\t\t" +
            $"{venda.Veiculo.Modelo}\t\t{venda.Veiculo.Placa}\tR$ {venda.ValorVenda}");
    }

    return sb.ToString();
}