using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace upb.tabd.broker
{
    public class DataAccess
    {
        protected static IMongoClient cliente = new MongoClient("mongodb://android:Mae$tro01@ds015962.mlab.com:15962/androidbd");
        protected static IMongoDatabase database = cliente.GetDatabase("androidbd");

        public List<BsonDocument> ConsultarPersonas()
        {
            var coleccion = database.GetCollection<BsonDocument>("Persona");
            List<BsonDocument> resultado = coleccion.Find(_ => true).ToList();

            return resultado;
        }

        public List<BsonDocument> ConsultarIntereses()
        {
            var coleccion = database.GetCollection<BsonDocument>("Intereses");
            List<BsonDocument> resultado = coleccion.Find(_ => true).ToList();

            return resultado;
        }

        public List<BsonDocument> ConsultarHabilidades()
        {
            var coleccion = database.GetCollection<BsonDocument>("Habilidades");
            List<BsonDocument> resultado = coleccion.Find(_ => true).ToList();

            return resultado;
        }

        public List<BsonDocument> ConsultarConocimientos()
        {
            var coleccion = database.GetCollection<BsonDocument>("Conocimientos");
            List<BsonDocument> resultado = coleccion.Find(_ => true).ToList();

            return resultado;
        }
    }
}
