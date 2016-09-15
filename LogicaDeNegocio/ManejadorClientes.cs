using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;

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


    }
}
