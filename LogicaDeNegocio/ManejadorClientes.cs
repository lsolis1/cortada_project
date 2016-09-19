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
        public void agregarCliente(Cliente cliente)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }

        public List<Cliente> ListarClientes()
        {
            using (var db= new DB_LaCortadaEntities())
            {
                var obtener_clientes = db.Clientes.OrderBy(x=>x.id_cliente);
                return obtener_clientes.ToList();
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
                //cliente.Tipo_Doc = Convert.ToByte(db.Tipos_Documento.Single(x=> x.Tipo_Doc == cliente.Tipo_Doc));
                //cliente.Cod_Postal = Convert.ToSByte(db.Ciudades.Single(x=> x.Cod_Postal == cliente.Cod_Postal));
                db.Entry(cliente).State = EntityState.Modified;
            }
        }

    }
}
