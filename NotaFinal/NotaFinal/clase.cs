using System;

namespace NotaFinal
{
    internal class NotaFinal
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double CalcularNotaFinal()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
    }
}
