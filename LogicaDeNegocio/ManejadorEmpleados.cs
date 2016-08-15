using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
namespace LogicaDeNegocio
{
    public class ManejadorEmpleados
    {
        public bool VerificarLogin(string usuario, string password)
        {
            //Verificar el logeo de un empleado.
            using (var db = new DB_LaCortadaEntities())
            {
                var login = db.Empleados.SingleOrDefault(x => x.Apellido == usuario && x.Nro_Doc.ToString() == password);
                if (login != null)
                {
                    return true;
                }
                else
                {
                    return false;
                } 
            }
            
        }
       
        public string ObtenerNombreApellido(string documento,string apellido)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                Empleado empleado = db.Empleados.SingleOrDefault(x=> x.Apellido == apellido && x.Nro_Doc.ToString() == documento);
                return empleado.Nombre + " " + empleado.Apellido;

            }
        }

    }
}
