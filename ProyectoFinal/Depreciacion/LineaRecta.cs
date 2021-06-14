using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Depreciacion
{
    public class LineaRecta : IDepreciacion
    {
        public decimal[] Calcular(decimal valor, decimal valorR, int vidaUtil)
        {
            decimal depreciacionActivo = (valor - valorR) / vidaUtil;
            return Enumerable.Repeat(depreciacionActivo, vidaUtil).ToArray();
        }
    }
}
