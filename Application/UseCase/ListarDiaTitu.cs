using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ListarDiaTitu : IListar
    {
        IRepository repo;
        public ListarDiaTitu(IRepository repo)
        {
            this.repo = repo;
        }
        public void listar () 
        {
            try 
            {
                Console.Write("Ingrese un titulo a buscar: ");
                string titu = Console.ReadLine();
                Console.Write("Ingrese una fecha (xx/xx) a buscar: ");
                DateTime dia = DateTime.Parse(Console.ReadLine());
                List<Programacion> lista = repo.listarAmbos(dia, titu);
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
                    Console.WriteLine("No hay funciones para esa fecha y/o pelicula\n");
                }
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Demasiados datos ingresados, error.\n");
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Error inesperado.\n");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Formato de fecha ingresado incorrecto\n");
            }
        }
    }
}
