const string NOMBRE_COMERCIO = "KIOSCO EL RECREO";

const decimal DESCUENTO_ALTO = 0.10m;
const decimal DESCUENTO_MEDIO = 0.05m;
const decimal DESCUENTO_EFECTIVO = 0.10m;
const decimal RECARGO_CREDITO = 0.15m;
const int ANCHO_TICKET = 30;

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

decimal subtotal = total;
decimal descuento = 0;

if (subtotal > 50000)
{
    descuento = subtotal * DESCUENTO_ALTO;
}
else if (subtotal > 20000)
{
    descuento = subtotal * DESCUENTO_MEDIO;
}

total = subtotal - descuento;

decimal recargo = 0;
int medioPago;

do
{
    Console.WriteLine();
    Console.WriteLine("Medio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Débito");
    Console.WriteLine("3 - Crédito");
    Console.Write("Opción: ");
    medioPago = int.Parse(Console.ReadLine());

    switch (medioPago)
    {
        case 1:
            decimal descuentoEfectivo = total * DESCUENTO_EFECTIVO;
            descuento = descuento + descuentoEfectivo;
            total = total - descuentoEfectivo;
            break;

        case 2:
            break;

        case 3:
            recargo = total * RECARGO_CREDITO;
            total = total + recargo;
            break;

        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            break;
    }
} while (medioPago < 1 || medioPago > 3);

string linea = "";
for (int i = 0; i < ANCHO_TICKET; i++)
{
    linea = linea + "-";
}

Console.WriteLine();
Console.WriteLine(linea);
Console.WriteLine($"{NOMBRE_COMERCIO,23}");
Console.WriteLine(linea);
Console.WriteLine($"Cajero: {nombreCajero}");
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {subtotal:0.##}");
Console.WriteLine($"Descuento: {descuento:0.##}");
Console.WriteLine($"Recargo: {recargo:0.##}");
Console.WriteLine(linea);
Console.WriteLine($"TOTAL: {total:0.##}");
Console.WriteLine(linea);

Console.ReadLine();