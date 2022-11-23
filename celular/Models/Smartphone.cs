namespace Celular.Models
{
    public abstract class Smartphone
    {
        public string? numero { get; set; }
        public string? imei { get; set; }
        public string? modelo { get; set; }
        public int? mentoria { get; set; }

        public Smartphone(string numero)
        {
            this.numero = numero;
        }

        public void ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void receberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void instalarAplicativo(string nomeApp);
    }
}