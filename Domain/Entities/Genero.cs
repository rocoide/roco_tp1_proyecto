using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Generos")]
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Nombre { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; }
    }

    
}
