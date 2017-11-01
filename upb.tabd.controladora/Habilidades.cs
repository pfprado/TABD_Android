using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using upb.tabd.broker;
using EN = upb.tabd.entidades;

namespace upb.tabd.controladora
{
    public class Habilidades
    {
        DataAccess broker = new DataAccess();

        public List<EN.Habilidad> ConsultarHabilidades()
        {
            List<EN.Habilidad> lstHabilidades = new List<EN.Habilidad>();
            List<BsonDocument> resultado = broker.ConsultarHabilidades();

            foreach (BsonDocument item in resultado)
            {
                EN.Habilidad registro = new EN.Habilidad();
                registro._id = int.Parse(item["_id"].ToString());
                registro.Habilidades = item["HABILIDADES"].ToString();
                lstHabilidades.Add(registro);
            }

            return lstHabilidades;
        }
    }
}
