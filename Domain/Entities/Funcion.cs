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
        //todos tienen que arrancar si o si con mayuscula?
        [Key]
        public int FuncionId { get; set; }


        [Column(Order =4)]
        public DateTime Fecha { get; set; }
        
        [Column(Order = 5)]
        public DateTime Horario { get; set; }




        [Column("PeliculaId", Order =2)]
        public int PeliculaId { get; set; }
        public Pelicula Peliculas { get; set; }



        [Column("SalaId", Order = 3)]
        public int SalaId { get; set; }
        public Sala Salas {  get; set; }


        public ICollection<Ticket> Tickets { get; set; }

    }

    
}
