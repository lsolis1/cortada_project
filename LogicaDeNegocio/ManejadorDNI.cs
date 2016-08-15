using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;

namespace LogicaDeNegocio
{
    public class ManejadorDNI
    {
        public List<Tipos_Documento> ListarDocumentos()
        {
            using (var db = new DB_LaCortadaEntities())
            {
                return db.Tipos_Documento.ToList();
            }
        }
    }
}
