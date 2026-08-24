const string NOMBRE_COMERCIO = "KIOSCO EL RECREO";

Console.WriteLine($" {NOMBRE_COMERCIO} ");

Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta.");

decimal total = 0;
int cantidadProductos = 0;
int opcion;

do
{
    Console.WriteLine();
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            total = total + precio;
            cantidadProductos = cantidadProductos + 1;

            Console.WriteLine($"Producto cargado: {nombreProducto} - ${precio}");
            break;

        case 2:
            Console.WriteLine("Cerrando la venta...");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            break;
    }
} while (opcion != 2);

Console.WriteLine();
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Total: {total}");

Console.ReadLine();