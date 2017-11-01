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
    public class Intereses
    {
        DataAccess broker = new DataAccess();

        public List<EN.Interes> ConsultarIntereses()
        {
            List<EN.Interes> lstIntereses = new List<EN.Interes>();
            List<BsonDocument> resultado = broker.ConsultarIntereses();

            foreach (BsonDocument item in resultado)
            {
                EN.Interes registro = new EN.Interes();
                registro._id = int.Parse(item["_id"].ToString());
                registro.Intereses = item["Intereses"].ToString();
                lstIntereses.Add(registro);
            }

            return lstIntereses;
        }
    }
}
