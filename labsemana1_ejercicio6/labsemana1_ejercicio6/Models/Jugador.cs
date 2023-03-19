class Jugador
{
    public string tipo{get; set;} = string.Empty;
    public string nombre{get; set;} = string.Empty;
    public int vida;
    public int poder;
    public int velocidad;

    public Jugador(string tipo, string nombre, int vida, int poder, int velocidad)
    {
        this.tipo = tipo;
        this.nombre = nombre;
        this.vida = vida;
        this.poder = poder;
        this.velocidad = velocidad;
    }

    public void Descansar()
    {
        vida += 10;
        System.Console.WriteLine("{0} se encuentra descansando, su vida ha aumentado a: {1}", nombre, vida);
    }

    public void Atacar(Jugador otroJugador)
    {
        otroJugador.vida -= poder;
        System.Console.WriteLine("{0} esta atacando a {1}, su poder ha disminuido en: {2}", 
        nombre, otroJugador.nombre, poder);
    }

    public void CargarPoder()
    {
        poder += 5;
        System.Console.WriteLine("{0} esta cargando su poder. Ha aumentado a {1}", nombre, poder);
    }
}