namespace NumeroParOImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
    }
}
