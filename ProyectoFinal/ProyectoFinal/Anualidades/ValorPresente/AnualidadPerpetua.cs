using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Anualidades.ValorPresente
{
    public class AnualidadPerpetua
    {
        public static float APerpetua(float p, float i)
        {
            i /= 100;
            return (p * i);
        }
    }
}
