using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Anualidades.ValorFuturo
{
    public class AnudalidadOrdinaria
    {
        public static float TasaAnual(float i, float f, float n, float m)
        {
            float a = 0;
            i = i / 100;

            if (m == 1)
            {

                a = f * (i / (((float)Math.Pow(1 + i, n)) - 1));

            }
            else if (m > 1)
            {

                float raiz = 1 / m;

                float ip = (float)Math.Pow((1 + i), raiz) - 1;

                a = f * (ip / (((float)Math.Pow(1 + ip, n)) - 1));
            }

            return a;
        }

        public static float TasaPeriodica(float ip, float f, float n, float m1, float m2)
        {
            float a = 0;
            if (m1 != m2 && m2 != 1)
            {

                float raiz = 1 / m2;

                float ip1 = ip / 100;

                float ip2 = (float)Math.Pow((float)Math.Pow(1 + ip1, m1), raiz) - 1;

                a = f * (ip2 / (((float)Math.Pow(1 + ip2, n)) - 1));

            }
            else if (m1 == m2)
            {

                ip = ip / 100;

                a = f * (ip / (((float)Math.Pow(1 + ip, n)) - 1));

            }
            else if (m2 == 1)
            {

                ip = ip / 100;

                float i = (float)Math.Pow(ip + 1, m1) - 1;

                a = f * (i / (((float)Math.Pow(1 + i, n)) - 1));
            }

            return a;
        }
    }
}
