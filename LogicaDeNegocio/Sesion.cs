using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class Sesion
    {
        public static byte id_empleado { get; set; }

        public static string nombre_apellido { get; set; }

        //public static SesionCaja SesionCaja { get; set; }
    }

    public static class SesionCaja
    {
        public static DateTime fecha_sesion { get; set; }
        public static TimeSpan hora_inicio { get; set; }
        public static decimal importe_inicio { get; set; }
        public static decimal importe_actual { get; set; }
    }

}

