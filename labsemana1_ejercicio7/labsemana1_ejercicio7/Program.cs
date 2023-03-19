internal class Program
{
    public int Opcion = 0;
    private static void Main(string[] args)
    {
        Vehiculo V1 = new Vehiculo();
        V1.Fabricante = "Toyota";
        V1.Modelo = "Corolla";
        V1.Año = "2010";
        V1.Velocidad = "180 km/h";
        V1.Maniobrabilidad = "80%";

        Vehiculo V2 = new Vehiculo();
        V2.Fabricante = "Ferrari";
        V2.Modelo = "Purosangue";
        V2.Año = "2022";
        V2.Velocidad = "310 km/h";
        V2.Maniobrabilidad = "40%";

        Vehiculo V3 = new Vehiculo();
        V3.Fabricante = "Lamborghini";
        V3.Modelo = "Gallardo";
        V3.Año = "2013";
        V3.Velocidad = "215 km/h";
        V3.Maniobrabilidad = "50%";


        System.Console.WriteLine("Tipos de Vehiculos:\nVehiculo 1:");
        System.Console.WriteLine(V1.Fabricante);
        System.Console.WriteLine(V1.Modelo);
        System.Console.WriteLine(V1.Año);
        System.Console.WriteLine(V1.Velocidad);
        System.Console.WriteLine(V1.Maniobrabilidad);
        System.Console.WriteLine();

        System.Console.WriteLine("Vehiculo 2");
        System.Console.WriteLine(V2.Fabricante);
        System.Console.WriteLine(V2.Modelo);
        System.Console.WriteLine(V2.Año);
        System.Console.WriteLine(V2.Velocidad);
        System.Console.WriteLine(V2.Maniobrabilidad);
        System.Console.WriteLine();

        System.Console.WriteLine("Vehiculo 3");
        System.Console.WriteLine(V3.Fabricante);
        System.Console.WriteLine(V3.Modelo);
        System.Console.WriteLine(V3.Año);
        System.Console.WriteLine(V3.Velocidad);
        System.Console.WriteLine(V3.Maniobrabilidad);

    }
}