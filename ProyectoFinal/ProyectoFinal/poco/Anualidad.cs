using ProyectoFinal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.poco
{
    public class Anualidad
    {
        public string nombreDelArchivo { get; set; }
        public TipoDeAnualidad tipoA { get; set; }
        public float valor { get; set; }
        public TipoValor tipoV { get; set; }
        public float vidaUtil { get; set; }
        public Enum periodo { get; set; }
        public float pGracia { get; set; }
        public float interes { get; set; }
        public Enum tasa { get; set; }
        public float anualidad { get; set; }
    }
}
