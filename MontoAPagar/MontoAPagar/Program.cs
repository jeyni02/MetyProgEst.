namespace MontoAPagar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monto_a_pagar compra = new Monto_a_pagar();

            Console.Write("Ingresa el precio del producto: ");
            compra.Precio = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la cantidad de productos: ");
            compra.Cantidad = int.Parse(Console.ReadLine());

            double montoTotal = compra.CalcularMontoTotal();
            Console.WriteLine($"\nEl monto total a pagar es: {montoTotal}");
        }
    }
}