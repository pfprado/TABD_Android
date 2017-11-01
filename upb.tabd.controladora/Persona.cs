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
    public class Persona
    {
        DataAccess broker = new DataAccess();

        public List<EN.Persona> ConsultarPersonas() {
            List<EN.Persona> lstPersonas = new List<EN.Persona>();
            List<BsonDocument> resultado = broker.ConsultarPersonas();

            foreach (BsonDocument item in resultado) {
                EN.Persona registro = new EN.Persona();
                registro._id = int.Parse(item["_id"].ToString());
                registro.Nombres = item["Nombres"].ToString();
                registro.Apellidos = item["Apellidos"].ToString();
                registro.Edad = double.Parse(item["Edad"].ToString());
                registro.Telefono = double.Parse(item["Telefono"].ToString());
                registro.Intereses = new List<int>();
                registro.Habilidades = new List<int>();
                registro.Conocimientos = new List<int>();

                var arrayIntereses = item["Intereses"].AsBsonArray.ToArray();
                var arrayConocimientos = item["Conocimientos"].AsBsonArray.ToArray();
                var arrayHabilidades = item["Habilidades"].AsBsonArray.ToArray();

                for (int i = 0; i < arrayIntereses.Length; i++)
                {
                    registro.Intereses.Add(int.Parse(arrayIntereses.GetValue(i).ToString()));
                }

                for (int i = 0; i < arrayConocimientos.Length; i++)
                {
                    registro.Conocimientos.Add(int.Parse(arrayConocimientos.GetValue(i).ToString()));
                }

                for (int i = 0; i < arrayHabilidades.Length; i++)
                {
                    registro.Habilidades.Add(int.Parse(arrayHabilidades.GetValue(i).ToString()));
                }


                lstPersonas.Add(registro);
            }

            return lstPersonas;
        }
    }
}
