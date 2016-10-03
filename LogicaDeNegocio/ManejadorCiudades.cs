using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
namespace LogicaDeNegocio
{
    public class ManejadorCiudades
    {
        public List<Provincia> ListarProvincias()
        {
            using (var db = new DB_LaCortadaEntities())
            {
                return db.Provincias.ToList();
            }
        }

        public bool agregarCiudad(Ciudade ciudad)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                //verifica si el cod de provincia ya existe en la base de datos.
                if (db.Ciudades.SingleOrDefault(x=>x.Cod_Postal == ciudad.Cod_Postal)!=null)
                {
                    return false;
                }
                else
                {
                    db.Ciudades.Add(ciudad);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public List<Ciudade> ListarCiudades(byte cod_provincia)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                return db.Ciudades.Where(x => x.Cod_Provincia == cod_provincia).ToList();
            }
        }
    }
}
