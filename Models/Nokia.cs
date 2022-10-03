namespace DesafioPOO.Models
{
  public class Nokia : Smartphone
  {
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine("");
      Console.WriteLine($"{Modelo} Conectando");
      Console.WriteLine($"{Modelo} Acessando:");
      Console.WriteLine($"{Modelo} https://play.google.com/store/apps");
      Console.WriteLine($"{Modelo} Buscando:{nomeApp}");
      Console.WriteLine($"{Modelo} baixando:{nomeApp}");
      Console.WriteLine($"{Modelo} instalando:{nomeApp}");
      Console.WriteLine($"{Modelo} {nomeApp}[abrir]");
    }
  }
}