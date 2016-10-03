using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
using System.Data.Entity;
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
                if (login != null)
                {
                    login.Empleado = db.Empleados.SingleOrDefault(c => c.Nro_Empleado == login.Nro_Empleado);
                    //return login;
                }
                //login.Empleado = db.Empleados.SingleOrDefault(c => c.Nro_Empleado == login.Nro_Empleado);
                return login;
            }
            
        }
        public Login ObtenerDatosLogin(Empleado empleado)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                return db.Logins.SingleOrDefault(x=>x.Nro_Empleado==empleado.Nro_Empleado);
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

        public List<Empleado> ListarEmpleados()
        {
            using (var db = new DB_LaCortadaEntities())
            {
                return db.Empleados.Include(x => x.Ciudade).ToList();
            }
        }

        public bool AgregarEmpleado(Empleado empleado)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                if (db.Ciudades.FirstOrDefault(x=>x.Cod_Postal==empleado.Cod_Postal)==null)
                {
                    return false;
                }
                else
                {
                    db.Empleados.Add(empleado);
                    db.SaveChanges();
                    return true;
                }
                
            }
        }

        public void AgregarLogin(Login login)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                db.Logins.Add(login);
                db.SaveChanges();
            }
        }
        public bool ModificarEmpleado(Empleado empleado)
        {
            using (var db =  new DB_LaCortadaEntities())
            {
                empleado.Tipos_Documento = db.Tipos_Documento.SingleOrDefault(x=> x.Tipo_Doc == empleado.Tipo_Doc);
                empleado.Ciudade = db.Ciudades.SingleOrDefault(x=> x.Cod_Postal == empleado.Cod_Postal);
                db.Entry(empleado).State = EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }
    }
}
