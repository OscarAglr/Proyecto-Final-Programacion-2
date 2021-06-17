using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Amortizacion
{
    public class CuotaNivelada
    {
        public decimal[] CalcularCuota(decimal saldoInsoluto, decimal tasa, int numPagos)
        {
            double anualidad = PAGO((double)saldoInsoluto, (double)tasa, numPagos);
            return Enumerable.Repeat((decimal)anualidad, numPagos).ToArray();
        }

        public decimal[] CalcularInteres(decimal saldoInsoluto, decimal tasa, int numPagos)
        {
            decimal[] intereses = new decimal[numPagos];
            decimal cuota =(decimal) PAGO((double)saldoInsoluto, (double) tasa, numPagos);
            decimal interes = saldoInsoluto * tasa;
            decimal abono = 0;
            for (int i = 0; i < numPagos; i++)
            {
                intereses[i] = interes;
                abono = CalcularAbono(cuota, interes);
                saldoInsoluto -= abono;
                interes = saldoInsoluto * tasa;
            }
            return intereses;
        }
        decimal CalcularAbono(decimal cuota, decimal interes)
        {
            return cuota - interes;
        }
        public decimal[] CalcularAbono(decimal saldoInsoluto, decimal tasa, int numPagos)
        {
            decimal[] abono = new decimal[numPagos];
            decimal[] cuota = CalcularCuota(saldoInsoluto, tasa, numPagos);
            decimal[] interes = CalcularInteres(saldoInsoluto, tasa, numPagos);
            for (int i = 0; i < numPagos; i++)
            {
                abono[i] = cuota[i] - interes[i];
            }
            return abono;
        }
        double PAGO(double vp, double tasa, int n)
        {
            return (vp * (tasa * Math.Pow(1.00 + tasa, n))) / (Math.Pow(1.00 + tasa, n) - 1);
        }
    }
}
