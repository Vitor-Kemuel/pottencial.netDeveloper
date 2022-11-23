namespace Estacionamento.Models
{
    public class EstacionamentoModel
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public EstacionamentoModel(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = "";
            while (placa == "")
            {
                placa = Console.ReadLine() ?? "";
                if (placa == ""){
                    Console.Clear();
                    Console.WriteLine("Digite uma placa valida:");
                }
            }
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";
            while (placa == "")
            {
                placa = Console.ReadLine() ?? "";
                if (placa == ""){
                    Console.Clear();
                    Console.WriteLine("Digite uma placa valida:");
                }
            }

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                while (horas == 0)
                {
                    int.TryParse( Console.ReadLine(), out horas);
                    if (horas == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite apenas numeros");
                    }
                }
                decimal valorTotal = 0;

                valorTotal = this.precoInicial + precoPorHora*horas;

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
                foreach (var element in veiculos)
                {
                    Console.WriteLine(element);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}