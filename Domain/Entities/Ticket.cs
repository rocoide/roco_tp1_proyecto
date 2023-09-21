using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Tickets")] 
    public class Ticket
    {
        public int TicketId { get; set; }

        [Column(Order = 2, TypeName = "nvarchar(50)")]
        public string Usuario { get; set; }

        //cambia el orden de la columna y el nombre con el que se mapea
        [Column("funcionID", Order = 1)]
        public int FuncionId { get; set; }
        public Funcion Funciones {  get; set; }
    }

    
}
