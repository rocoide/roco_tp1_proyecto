using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Application.Interfaces;
using Domain.Entities;

namespace Application
{
    public class ListarDia : IListar
    {
        IRepository repo;
        public ListarDia (IRepository repo) 
        {
            this.repo = repo;
        }

        public void listar() 
        {
            Console.Write("Ingrese una fecha (xx/xx) para ver las funciones de ese dia: ");
            DateTime dia = DateTime.Parse(Console.ReadLine());
            List<Programacion> lista =  repo.listarDia(dia);
            Console.WriteLine("\nLa lista tiene " + lista.Count + " funciones\n");
            if (lista.Count != 0)
            {
                foreach (Programacion p in lista)
                {
                    Console.WriteLine("Titulo: " + p.Titulo + "\nSinopsis: " + p.Sinopsis + "\nPoster: " + p.Poster + "\nTrailer: " + p.Trailer + "\nGenero: " + p.Genero + "\n");
                    Console.WriteLine("Sala: " + p.salaNombre + " - Fecha: " + p.Fecha.ToString("dddd") + " " + p.Fecha.ToString("dd/MM/yyyy") + " - Horario: " + p.Horario.ToString("HH:mm"));
                    Console.WriteLine("\n\n");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No hay funciones para esa fecha\n");
            }
        }
    }
}
