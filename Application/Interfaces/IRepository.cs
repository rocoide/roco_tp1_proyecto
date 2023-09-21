using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRepository
    {
        public List<Programacion> listarTitulo(string titu);
        public List<Programacion> listarDia(DateTime dia);
        public List<Programacion> listarAmbos(DateTime dia, string titu);
    }
}
