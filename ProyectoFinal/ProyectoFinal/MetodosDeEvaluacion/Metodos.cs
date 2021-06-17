using System;
using System.Collections.Generic;
using System.Linq;
using System.Numeric;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.MetodosDeEvaluacion
{
    public class Metodos
    {
        public static double TIR(double [] FNE)
        {
            return Financial.Irr(FNE, 0.1);
        }

        public static double VPN(double[] FNE, double tasa)
        {
            int size = FNE.Length;
            double vpn = 0;
            for (int i = 0; i < size; i++)
            {
                if (FNE[i] == 0)
                {
                    continue;
                }
                vpn += ValorPresente(FNE[i], i, tasa);
            }
            return vpn;
        }

        private static double ValorPresente(double FNE, int n, double tasa)
        {
            return FNE / Math.Pow(1 + tasa, n);
        }
    }
}
