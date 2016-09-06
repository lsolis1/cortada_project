﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
namespace LogicaDeNegocio
{
    public class ManejadorEmpleados
    {
        public Login VerificarLogin(string usuario, string password)
        {
            //Verificar el logeo de un empleado.
            using (var db = new DB_LaCortadaEntities())
            {
                var login = db.Logins.SingleOrDefault(x=>x.username == usuario && x.password == password);
                login.Empleado = db.Empleados.SingleOrDefault(c => c.Nro_Empleado == login.Nro_Empleado);
                return login;
            }
            
        }

        public byte ObtenerIdEmpleado(string usuario,string password)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                Login login = db.Logins.SingleOrDefault(x => x.username == usuario && x.password == password);
                if (login != null)
                {
                    return login.Nro_Empleado;
                }
                else
                {
                    return 4; //devuelvo el admin
                }

            }
        }
       
        public string ObtenerNombreApellido(string usuario,string password)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                Login login = db.Logins.SingleOrDefault(x => x.username == usuario && x.password == password);
                return login.Empleado.Nombre + " " +login.Empleado.Apellido;

            }
        }

    }

}
