using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class ListarPeliculas
    {
        public void listarPeliculas(IListarPeliculas pelis) 
        {
            try 
            {
                List<Programacion> _pelis = pelis.listarPeliculas();
                for (int i = 0; i < _pelis.Count; i++)
                {
                    Console.Write((i + 1) + " - " + "Titulo: " + _pelis[i].Titulo + "\nPoster: " + _pelis[i].Poster + "\nTrailer: " + _pelis[i].Trailer + "\n\n");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Ha ocurrido un error");
            }
        }
    }
}
