using System;

namespace MontoAPagar
{
    internal class Monto_a_pagar
    {
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public double CalcularMontoTotal()
        {
            return Precio * Cantidad;
        }
    }
}
