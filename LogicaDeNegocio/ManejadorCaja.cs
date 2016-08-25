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

        private static int ObtenerUltimoMovimiento()
        {
            var db = new DB_LaCortadaEntities();
            return db.Cajas.Max(x => x.Nro_Movimiento);
        }
        public static decimal ObtenerDineroEnCaja()
        {
            var db = new DB_LaCortadaEntities();
            var ultimo_nro_movimiento = ObtenerUltimoMovimiento();
            var obtener_datosUltimoMovimiento = db.Cajas.SingleOrDefault(x=> x.Nro_Movimiento == ultimo_nro_movimiento);
            if (obtener_datosUltimoMovimiento !=null)
            {
                return obtener_datosUltimoMovimiento.Importe_Inicio;
            }
            else
            {
                return 0000;
            }

        }



        public bool AgregarDineroCaja(decimal monto)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                //controlar que la variable monto sea un numero
                var ultimo_nro_movimiento = ObtenerUltimoMovimiento();
                var ultimaCaja = db.Cajas.FirstOrDefault(x=> x.Nro_Movimiento == ultimo_nro_movimiento);

                if (ultimaCaja == null) {
                    return false;
                }
                else
                {
                    ultimaCaja.Importe_Inicio = ultimaCaja.Importe_Inicio + monto;
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool QuitarDineroCaja(decimal monto)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                //controlar que la variable monto sea un numero
                var ultimo_nro_movimiento = ObtenerUltimoMovimiento();
                var ultimaCaja = db.Cajas.FirstOrDefault(x => x.Nro_Movimiento == ultimo_nro_movimiento);
                if (monto>ultimaCaja.Importe_Inicio)
                {
                    return false;
                }
                else if (monto == ultimaCaja.Importe_Inicio)
                {
                    return false;
                }
                else
                {
                    ultimaCaja.Importe_Inicio = ultimaCaja.Importe_Inicio - monto;
                    db.SaveChanges();
                    return true;
                }
                
            }
        }

    }
}
