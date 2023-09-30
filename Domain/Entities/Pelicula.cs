using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Peliculas")]
    public class Pelicula
    {

        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string Poster { get; set; }
        public string Trailer { get; set; }

        public int Genero { get; set; }
        public Genero Generos { get; set; }
        public ICollection<Funcion> Funciones { get; set; }
    }

    
}
