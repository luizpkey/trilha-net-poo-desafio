namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria; 
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"{Modelo}:Ligando...{numero}");
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"{Modelo}:Recebendo ligação...{numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}