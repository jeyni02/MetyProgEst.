using System;

namespace ÁreaDeUnCirculo
{
    internal class ÁreaDeUnCirculo
    {
        public double Radio { get; set; }

        public double CalcularAreaCirculo()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}