namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 8;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
    
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            Console.WriteLine("Digite a Quantidade de Horas");
                horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial+(precoPorHora*horas);
                veiculos.Remove(placa);                

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               foreach( string carros  in veiculos)
{
                Console.WriteLine(carros);
}
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
