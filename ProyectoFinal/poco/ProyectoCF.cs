using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.poco
{
    public class ProyectoCF : Proyecto
    {
        public decimal Prestamo { get; set; }
        public decimal Tasa_de_interes_prestamo { get; set; }

    }
}
