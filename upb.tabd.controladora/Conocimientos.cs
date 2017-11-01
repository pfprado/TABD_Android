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
    public class Conocimientos
    {
        DataAccess broker = new DataAccess();

        public List<EN.Conocimiento> ConsultarConocimientos()
        {
            List<EN.Conocimiento> lstConocimientos = new List<EN.Conocimiento>();
            List<BsonDocument> resultado = broker.ConsultarConocimientos();

            foreach (BsonDocument item in resultado)
            {
                EN.Conocimiento registro = new EN.Conocimiento();
                registro._id = int.Parse(item["_id"].ToString());
                registro.Conocimientos = item["Conocimientos"].ToString();
                lstConocimientos.Add(registro);
            }

            return lstConocimientos;
        }
    }
}
