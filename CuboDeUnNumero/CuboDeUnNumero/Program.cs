namespace CuboDeUnNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuboDeUnNumero calculadora = new CuboDeUnNumero();

            Console.Write("Ingresa un número: ");
            calculadora.Numero = double.Parse(Console.ReadLine());

            double cubo = calculadora.CalcularCubo();
            Console.WriteLine($"\nEl cubo del número {calculadora.Numero} es: {cubo}");
        }
    }
}
