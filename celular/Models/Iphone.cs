namespace Celular.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        public override void instalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo no Iphone: " + nomeApp);
        }
    }
}