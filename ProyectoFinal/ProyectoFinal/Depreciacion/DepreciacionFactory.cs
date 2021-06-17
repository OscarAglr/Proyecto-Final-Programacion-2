using ProyectoFinal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Depreciacion
{
    public class DepreciacionFactory
    {
        public IDepreciacion CreateInstance(MetodoDepreciacion metodoDepreciacion)
        {
            switch (metodoDepreciacion)
            {
                case MetodoDepreciacion.LINEARECTA:
                    return new LineaRecta();
                case MetodoDepreciacion.SUMADIGITOS:
                    return new SDADepreciacion();
                default:
                    return null;
            }
        }
    }
}
