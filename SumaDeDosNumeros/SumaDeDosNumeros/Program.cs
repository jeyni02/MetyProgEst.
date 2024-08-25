namespace SumaDeDosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;

            Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");

        }
    }
}
