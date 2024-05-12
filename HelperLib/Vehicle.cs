namespace HelperLib;


public class Vehicle {
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Valor { get; set; }


    public void Datos(){
        Console.WriteLine($"la marca de este vehiculo es: {Marca} su modelo es: {Modelo} y su valor es {Valor}");
    }
}