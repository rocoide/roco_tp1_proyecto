using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Programacion
    {
        public Programacion() { }

        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string Poster { get; set; }
        public string Trailer { get; set; }
        public string Genero { get; set; }
        public string salaNombre { get; set; }
        public int Capacidad { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Horario { get; set; }

    }
}
