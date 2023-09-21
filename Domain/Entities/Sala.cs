using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sala
    {
        public int SalaId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }
        public int Capacidad { get; set; }

        public ICollection<Funcion> Funciones {  get; set; }
    }

    
}
