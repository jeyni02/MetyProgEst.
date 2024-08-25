using System;

namespace CuboDeUnNumero
{
    internal class CuboDeUnNumero
    {
        public double Numero { get; set; }

        public double CalcularCubo()
        {
            return Math.Pow(Numero, 3);
        }
    }
}
