using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
namespace LogicaDeNegocio
{
    public class ManejadorCaja
    {
        public void CargarCaja(Caja caja)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                db.Cajas.Add(caja);
                db.SaveChanges();
            }
        }

        public void ModificarCaja(Caja caja)
        {

        }
        


    }
}
