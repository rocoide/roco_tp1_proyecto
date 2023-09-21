using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ListarTitulo : IListar
    {
        IRepository repo;
        public ListarTitulo(IRepository repo)
        {
            this.repo = repo;
        }
        public void listar()
        {
            Console.Write("Ingrese un titulo para ver las funciones de esa pelicula: ");
            string titu = Console.ReadLine();
            List<Programacion> lista =  repo.listarTitulo(titu);
            Console.WriteLine("La lista tiene " + lista.Count + " funciones\n");
            if (lista.Count != 0)
            {
                foreach (Programacion p in lista)
                {
                    Console.WriteLine("Titulo: " + p.Titulo + "\nSinopsis: " + p.Sinopsis + "\nPoster: " + p.Poster + "\nTrailer: " + p.Trailer + "\nGenero: " + p.Genero + "\n");
                    Console.WriteLine("Sala: " + p.salaNombre + " - Fecha: " + p.Fecha.ToString("dddd") + " " + p.Fecha.ToString("dd/MM/yyyy") + " - Horario: " + p.Horario.ToString("HH:mm"));
                }
                Console.WriteLine("\n\n");
            }
            else
            {
                Console.WriteLine("No hay funciones para esa pelicula\n");
            }
        }
    }
}
