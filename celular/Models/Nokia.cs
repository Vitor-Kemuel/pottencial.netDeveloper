namespace Celular.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
        }

        public override void instalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo no Nokia: " + nomeApp);
        }
    }
}