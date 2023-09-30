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
        public Guid TicketId { get; set; }

        public int FuncionId { get; set; }
        public Funcion Funciones {  get; set; }

        public string Usuario { get; set; }
    }

    
}
