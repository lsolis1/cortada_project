using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;

namespace LogicaDeNegocio
{
    public class ManejadorTurnos
    {
        
        public static List<Turno> ListarTurnosHoy()
        {
            var db = new DB_LaCortadaEntities();
            //listar los turnos de hoy.
            var turnos =  db.Turnos.Where(x => x.Fecha == DateTime.Today).ToList();
            return turnos.OrderByDescending(x=> x.Hora).ToList();
        }
    }
}
