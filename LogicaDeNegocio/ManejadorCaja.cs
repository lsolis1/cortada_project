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
        
        public static string ObtenerDineroEnCaja()
        {
            //obtener importe de inicio de la ultima caja.
            using (var db = new DB_LaCortadaEntities())
            {
                var ultimaNroMovimiento = db.Cajas.Max(x=>x.Nro_Movimiento);
                var obtenerDinero = db.Cajas.FirstOrDefault(x=>x.Nro_Movimiento == ultimaNroMovimiento);
                if (obtenerDinero != null)
                {
                    return obtenerDinero.Importe_Inicio.ToString();
                }
                else
                {
                    return "error";
                }
                
            }
        }


    }
}
