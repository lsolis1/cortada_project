using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
using System.Data.Entity;

namespace LogicaDeNegocio
{
    public class ManejadorClientes
    {
        public bool agregarCliente(Cliente cliente)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                if (db.Ciudades.FirstOrDefault(x=>x.Cod_Postal==cliente.Cod_Postal)==null)
                {
                    return false;
                }
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return true;
            }
        }

        //listar cliente
        public List<Cliente> ListarClientes(string textoBusquedaApellido,string textoBusquedaNombre)
        {
            using (var db= new DB_LaCortadaEntities())
            {
                if (!String.IsNullOrEmpty(textoBusquedaApellido)&& !String.IsNullOrWhiteSpace(textoBusquedaApellido) && String.IsNullOrEmpty(textoBusquedaNombre)
                    && String.IsNullOrWhiteSpace(textoBusquedaNombre))
                {
                    var obtener_clientes = db.Clientes.Include(x => x.Ciudade).Where(x=> x.Apellido.ToLower().Contains(textoBusquedaApellido.ToLower()));
                    return obtener_clientes.ToList();
                }else if (String.IsNullOrEmpty(textoBusquedaApellido) && String.IsNullOrWhiteSpace(textoBusquedaApellido) && !String.IsNullOrEmpty(textoBusquedaNombre)
                    && !String.IsNullOrWhiteSpace(textoBusquedaNombre))
                {
                    var obtener_clientes = db.Clientes.Include(x => x.Ciudade).Where(x => x.Nombre.ToLower().Contains(textoBusquedaNombre.ToLower()));
                    return obtener_clientes.ToList();
                }else if (!String.IsNullOrEmpty(textoBusquedaApellido)&& !String.IsNullOrWhiteSpace(textoBusquedaApellido) && !String.IsNullOrEmpty(textoBusquedaNombre)
                    && !String.IsNullOrWhiteSpace(textoBusquedaNombre))
                {
                    var obtener_clientes = db.Clientes.Include(x => x.Ciudade).Where(x => x.Apellido.ToLower().Contains(textoBusquedaApellido.ToLower()))
                        .Where(x=>x.Nombre.ToLower().Contains(textoBusquedaNombre.ToLower()));
                    return obtener_clientes.ToList();
                }
                else
                {
                    var obtener_clientes = db.Clientes.Include(x => x.Ciudade).OrderBy(x => x.id_cliente);
                    return obtener_clientes.ToList();
                }
                //var obtener_clientes = db.Clientes.Include(x => x.Ciudade).OrderBy(x => x.id_cliente);
                //return obtener_clientes.ToList();


                //var obtener_clientes = db.Clientes.Include(x => x.Ciudade).Where(x=> x.Apellido.ToLower().Contains(textoBusquedaApellido.ToLower()));
                //return obtener_clientes.ToList();



            }
        }

        public void borrarCliente(Cliente cliente)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                db.Entry(cliente).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void ModificarCliente(Cliente cliente)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                cliente.Tipos_Documento = db.Tipos_Documento.SingleOrDefault(x=> x.Tipo_Doc == cliente.Tipo_Doc);
                cliente.Ciudade = db.Ciudades.SingleOrDefault(x=> x.Cod_Postal == cliente.Cod_Postal);
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}
