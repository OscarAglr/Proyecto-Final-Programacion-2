using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Depreciacion
{
    public interface IDepreciacion
    {
        decimal[] Calcular(decimal valor, decimal valorR, int vidaUtil);
    }
}
