using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
using System.Data.Entity;
namespace LogicaDeNegocio
{
    public class ConfiguracionComplejo
    {
        public List<Dias_atencion> getHorarios()
        {
            using (var db= new DB_LaCortadaEntities())
            {
                return db.Dias_atencion.ToList();
            }
        }

        public Dias_atencion getHorarioDiaEspecifico(int dia)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                return db.Dias_atencion.SingleOrDefault(x => x.id_dia == dia);
            }
        }

        public void setHorarios(List<Dias_atencion> horarios)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                try
                {
                    foreach (var item in horarios)
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                
            }
        }
        public void setHorariosDias(Dias_atencion horarios)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                db.Entry(horarios).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void getDatosComplejo()
        {
            using (var db =new  DB_LaCortadaEntities())
            {
                DatosComplejo.getDatos = db.Configuracions.SingleOrDefault(x => x.id_configuracion == 1);
            }
        }

        public Configuracion ListarDatosComplejo()
        {
            using (var db = new DB_LaCortadaEntities())
            {
                return db.Configuracions.SingleOrDefault(x => x.id_configuracion == 1);
            }
        }

        public void CambiarDatosComplejo(Configuracion configuracion)
        {
            using (var db = new DB_LaCortadaEntities())
            {
                db.Entry(configuracion).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
