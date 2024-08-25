namespace NotaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaFinal estudiante = new NotaFinal();

            Console.Write("Ingresa la primera nota: ");
            estudiante.Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la segunda nota: ");
            estudiante.Nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la tercera nota: ");
            estudiante.Nota3 = double.Parse(Console.ReadLine());

            double notaFinal = estudiante.CalcularNotaFinal();
            Console.WriteLine($"\nLa nota final del estudiante es: {notaFinal}");
        }
    }
}
