using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Anualidades.ValorPresente
{
    public class AnualidadDiferida
    {
        public static float TasaAnual(float i, float p, float n,float k, float m)
        {

            float a = 0;
            i = i / 100;

            if (m == 1)
            {
                float e = n - k;

                a = p * ((float)Math.Pow((1 + i), -k)*(i * (float)(Math.Pow((1 + i), e)))) / (((float)Math.Pow(1 + i, e) - 1));

            }
            else if (m > 1)
            {

                float raiz = 1 / m;

                float ip = (float)Math.Pow((1 + i), raiz) - 1;

                float e = n - k;

                a = p * ((float)Math.Pow((1 + ip), -k) * (i * (float)(Math.Pow((1 + ip), e)))) / (((float)Math.Pow(1 + ip, e) - 1));
            }

            return a;
        }

        public static float TasaPeriodica(float ip, float p, float n,float k, float m1, float m2)
        {
            float a = 0;
            if (m1 != m2 && m2 != 1)
            {

                float raiz = 1 / m2;

                float ip1 = ip / 100;

                float ip2 = (float)Math.Pow((float)Math.Pow(1 + ip1, m1), raiz) - 1;

                float e = n - k;

                a = p * ((float)Math.Pow((1 + ip2), -k) * (ip2 * (float)(Math.Pow((1 + ip2), e)))) / (((float)Math.Pow(1 + ip2, e) - 1));

            }
            else if (m1 == m2)
            {

                ip = ip / 100;

                float e = n - k;

                a = p * ((float)Math.Pow((1 + ip), -k) * (ip * (float)(Math.Pow((1 + ip), e)))) / (((float)Math.Pow(1 + ip, e) - 1));

            }
            else if (m2 == 1)
            {

                ip = ip / 100;

                float i = (float)Math.Pow(ip + 1, m1) - 1;

                float e = n - k;

                a = p * ((float)Math.Pow((1 + i), -k) * (i * (float)(Math.Pow((1 + i), e)))) / (((float)Math.Pow(1 + i, e) - 1));
            }

            return a;
        }

    }
}
