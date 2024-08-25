namespace RaizCuadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RaizCuadrada calculadora = new RaizCuadrada();

            Console.Write("Ingresa un número: ");
            calculadora.Numero = double.Parse(Console.ReadLine());

            double raizCuadrada = calculadora.CalcularRaizCuadrada();
            Console.WriteLine($"\nLa raíz cuadrada de {calculadora.Numero} es: {raizCuadrada}");
        }
    }
}
