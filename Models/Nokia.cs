namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' da Play Store.");
        }

        public override void EspecificacoesFabrica()
        {
            Console.WriteLine($"Modelo: {Modelo}. \n" +
                              $"IMEI: {Imei}. \n" +
                              $"Memória: {Memoria} GB.");
        }
    }
}