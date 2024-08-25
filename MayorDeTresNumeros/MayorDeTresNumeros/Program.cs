namespace MayorDeTresNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());

            int mayor;

            if (numero1 > numero2 && numero1 > numero3)
            {
                mayor = numero1;
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3;
            }

            Console.WriteLine($"\nEl mayor de los tres números es: {mayor}");
        }
    }
}
