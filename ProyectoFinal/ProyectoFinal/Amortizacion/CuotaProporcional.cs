using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Amortizacion
{
    public class CuotaProporcional
    {
        public decimal[] CalcularCuota(decimal saldoInsoluto, decimal tasa, int numPagos)
        {
            decimal[] cuota = new decimal[numPagos];
            decimal[] abonos = CalcularAbono(saldoInsoluto, numPagos);
            decimal[] intereses = CalcularInteres(saldoInsoluto, tasa, numPagos);
            for (int i = 0; i < numPagos; i++)
            {
                cuota[i] = abonos[i] + intereses[i];
            }
            return cuota;
        }

        public decimal[] CalcularInteres(decimal saldoInsoluto, decimal tasa, int numPagos)
        {
            decimal[] intereses = new decimal[numPagos];
            decimal abono = CalcularAbonoIndividual(saldoInsoluto, numPagos);
            decimal interes = saldoInsoluto * tasa;
            for (int i = 0; i < numPagos; i++)
            {
                intereses[i] = interes;
                saldoInsoluto -= abono;
                interes = saldoInsoluto * tasa;
            }
            return intereses;
        }
        decimal CalcularAbonoIndividual(decimal prestamo, decimal numPagos)
        {
            return prestamo / numPagos;
        }
        public decimal[] CalcularAbono(decimal saldoInsoluto, int numPagos)
        {
            decimal abono = CalcularAbonoIndividual(saldoInsoluto, numPagos);
            return Enumerable.Repeat(abono, numPagos).ToArray();
        }
        
    }
}
