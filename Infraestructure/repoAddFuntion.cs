using Application.Interfaces;
using Application.UseCase;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class repoAddFuntion : IAddFuntion, IListarPeliculas
    {
        public CineContext cine;

        public repoAddFuntion(CineContext cine)
        {
            this.cine = cine;
        }

        public void addFuntion(DateTime fecha, DateTime hora) 
        {
            try 
            {
                Console.Write("Ingrese un opcion de sala (1,2 o 3): ");
                int sala = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (sala > 0 | sala < 4) 
                {
                    ListarPeliculas listaPeliculas = new ListarPeliculas();
                    listaPeliculas.listarPeliculas(this);
                    Console.Write("ingrese un opcion de pelicula (1 a 20): ");
                    int pelicula = int.Parse(Console.ReadLine());
                    Funcion funci = new Funcion()
                    {
                        Fecha = fecha,
                        Horario = hora,
                        SalaId = sala,
                        PeliculaId = pelicula,
                    };
                    cine.Funciones.Add(funci);
                    cine.SaveChanges();
                    Console.WriteLine("Se ha agregado la funcion correctamente\n");
                }
                else 
                {
                    Console.WriteLine("sala invilida\n");
                }
            }
            catch (OverflowException ex)
            {
                Console.Clear();
                Console.WriteLine("Se han ingresado demasiados datos, error.\n");
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("por favor ingrese un numero.\n");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("no ha ingresado opciones validas");
            }
        }

        public List<Programacion> listarPeliculas() 
        {
            List<Programacion> lista =  cine.Peliculas
                                                           .Include(p => p.Generos)
                                                           .Select(f => new Programacion
                                                           {
                                                               Titulo = f.Titulo,
                                                               Genero = f.Generos.Nombre,
                                                               Poster = f.Poster,
                                                               Trailer = f.Trailer
                                                           })
                                                           .ToList();
            return lista;
        }

    }
}
