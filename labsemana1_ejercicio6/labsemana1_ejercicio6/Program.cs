Jugador j1 = new Jugador("Guerrero", "Conan", 100, 20, 5);
Jugador j2 = new Jugador("Mago", "Dynamo", 80, 15, 10);


System.Console.WriteLine("Jugador 1:\nTipo: {0}\nNombre: {1}\nVida: {2}\nPoder: {3}\nVelocidad: {4}",
j1.tipo, j1.nombre, j1.vida, j1.poder, j1.velocidad);
System.Console.WriteLine();

System.Console.WriteLine("Jugador 2:\nTipo: {0}\nNombre: {1}\nVida: {2}\nPoder: {3}\nVelocidad: {4}",
j2.tipo, j2.nombre, j2.vida, j2.poder, j2.velocidad);
System.Console.WriteLine();

j1.Descansar();
j1.Atacar(j2);
j2.CargarPoder();