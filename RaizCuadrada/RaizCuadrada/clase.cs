using System;

namespace RaizCuadrada
{
    internal class RaizCuadrada
    {
        public double Numero { get; set; }

        public double CalcularRaizCuadrada()
        {
            return Math.Sqrt(Numero);
        }
    }
}
