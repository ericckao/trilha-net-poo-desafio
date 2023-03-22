namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' da Apple Store.");
        }
        

        public override void EspecificacoesFabrica()
        {
            Console.WriteLine($"Modelo: {Modelo}. \n" +
                              $"IMEI: {Imei}. \n" +
                              $"Memória: {Memoria} GB.");
        }
    }
}