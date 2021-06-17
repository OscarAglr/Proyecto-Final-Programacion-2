using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProyectoFinal.Anualidades.ValorPresente
{
    public class AnudalidadOrdinaria
    {
        public static float TasaAnual(float i, float p, float n, float m)
        {

            float a = 0;
            i = i / 100;

            if (m == 1)
            {

                a = p * (i * (float)(Math.Pow((1 + i), n)) / (((float)Math.Pow(1 + i, n)) - 1));

            }
            else if (m > 1)
            {

                float raiz = 1 / m;

                float ip = (float)Math.Pow((1 + i), raiz) - 1;

                a = p * (ip * (float)(Math.Pow((1 + ip), n)) / (((float)Math.Pow(1 + ip, n)) - 1));
            }

            return a;
        }

        public static float TasaPeriodica(float ip, float p, float n, float m1, float m2)
        {
            float a = 0;
            if (m1 != m2 && m2 != 1)
            {

                float raiz = 1 / m2;

                float ip1 = ip / 100;

                float ip2 = (float)Math.Pow((float)Math.Pow(1 + ip1, m1), raiz) - 1;

                a = p * (ip2 * (float)(Math.Pow((1 + ip2), n)) / (((float)Math.Pow(1 + ip2, n)) - 1));

            }
            else if (m1 == m2)
            {

                ip = ip / 100;

                a = p * (ip * (float)(Math.Pow((1 + ip), n)) / (((float)Math.Pow(1 + ip, n)) - 1));

            }
            else if (m2 == 1)
            {

                ip = ip / 100;

                float i = (float)Math.Pow(ip + 1, m1) - 1;

                a = p * (i * (float)(Math.Pow((1 + i), n)) / (((float)Math.Pow(1 + i, n)) - 1));
            }

            return a;
        }


    }
}
