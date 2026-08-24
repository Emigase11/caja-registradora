const string NOMBRE_COMERCIO = "KIOSCO EL RECREO";

Console.WriteLine($" {NOMBRE_COMERCIO} ");

Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta.");

Console.Write("Nombre del producto: ");
string nombreProducto = Console.ReadLine();

Console.Write("Precio: ");
decimal precio = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Producto cargado: {nombreProducto} - ${precio}");

Console.ReadLine();