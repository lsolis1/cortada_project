using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;

namespace LogicaDeNegocio
{
    public class ManejadorListaDeEspera
    {
        public static List<Lista_Espera> MostrarListaDeEsperaHoy()
        {
            var db = new DB_LaCortadaEntities();
                //mostrar lista de espera de hoy sin fecha de baja.
                return db.Lista_Espera.Where(x => x.Fecha == DateTime.Today && x.Fecha_baja == null).OrderByDescending(x => x.Hora).ToList();
        }


    }
}
