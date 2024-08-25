namespace ÁreaDeUnCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ÁreaDeUnCirculo calculadora = new ÁreaDeUnCirculo();

            Console.Write("Ingresa el radio del círculo: ");
            calculadora.Radio = double.Parse(Console.ReadLine());

            double area = calculadora.CalcularAreaCirculo();
            Console.WriteLine($"\nEl área del círculo con radio {calculadora.Radio} es: {area}");
        }
    }
}