namespace AumentarSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa nombre del trabajador: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa el cargo del trabajador: ");
            string cargo = Console.ReadLine();

            Console.Write("Ingresa el salario del trabajador: ");
            double salario = double.Parse(Console.ReadLine());

            double aumento = salario * 0.10;
            double nuevoSalario = salario + aumento;

            Console.WriteLine("\nDatos del trabajador:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Salario actual: {salario}");
            Console.WriteLine($"Aumento del 10%: {aumento}");
            Console.WriteLine($"Nuevo salario: {nuevoSalario}");
        }
    }
}
