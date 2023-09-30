using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Funciones")]
    public class Funcion
    {
        public int FuncionId { get; set; }

        public int PeliculaId { get; set; }
        public Pelicula Peliculas { get; set; }

        public int SalaId { get; set; }
        public Sala Salas {  get; set; }


        public ICollection<Ticket> Tickets { get; set; }

        public DateTime Fecha { get; set; }
        public TimeSpan Horario { get; set; }



        




    }

    
}
