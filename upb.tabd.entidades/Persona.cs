using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upb.tabd.entidades
{
    public class Persona
    {
        public int _id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public double Edad { get; set; }
        public double Telefono { get; set; }
        public List<int> Intereses { get; set; }
        public List<int> Conocimientos { get; set; }
        public List<int> Habilidades { get; set; }
    }
}
