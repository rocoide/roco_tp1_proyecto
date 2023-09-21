using Application;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class Repositorio : IRepository
    {
        private CineContext cine;
        public Repositorio(CineContext _cine) 
        {
            cine = _cine;
        }

        public List<Programacion> listarTitulo(string titu) 
        {
            List<Programacion> lista = cine.Funciones
                                           .Include(f => f.Peliculas)
                                              .ThenInclude(p => p.Generos)
                                           .Include(f => f.Salas)
                                           .Where(f => f.Peliculas.Titulo.Contains(titu))
                                           .Select(f => new Programacion
                                                { 
                                                    Titulo = f.Peliculas.Titulo,
                                                    Sinopsis = f.Peliculas.Sinopsis,
                                                    Genero = f.Peliculas.Generos.Nombre,
                                                    salaNombre = f.Salas.Nombre,
                                                    Poster = f.Peliculas.Poster,
                                                    Trailer = f.Peliculas.Trailer,
                                                    Fecha = f.Fecha,
                                                    Horario = f.Horario
                                                })
                                           .ToList();
            return lista;
        }


        public List<Programacion> listarDia(DateTime dia) 
        {
            List<Programacion> lista = cine.Funciones
                                           .Include(f => f.Peliculas)
                                              .ThenInclude(p => p.Generos)
                                           .Include(f => f.Salas)
                                           .Where(f => f.Fecha.Day == dia.Day && (f.Fecha.Month == dia.Month))
                                           .Select(f => new Programacion
                                           {
                                               Titulo = f.Peliculas.Titulo,
                                               Sinopsis = f.Peliculas.Sinopsis,
                                               Genero = f.Peliculas.Generos.Nombre,
                                               salaNombre = f.Salas.Nombre,
                                               Poster = f.Peliculas.Poster,
                                               Trailer = f.Peliculas.Trailer,
                                               Fecha = f.Fecha,
                                               Horario = f.Horario
                                           })
                                           .ToList();
            return lista;
        }
        

        public List<Programacion> listarAmbos(DateTime dia, string titu) 
        {
            List<Programacion> lista = cine.Funciones
                                           .Include(f => f.Peliculas)
                                              .ThenInclude(p => p.Generos)
                                           .Include(f => f.Salas)
                                           .Where(f => f.Fecha.Day == dia.Day && (f.Fecha.Month == dia.Month  && (f.Peliculas.Titulo.Contains(titu))))
                                           .Select(f => new Programacion
                                           {
                                               Titulo = f.Peliculas.Titulo,
                                               Sinopsis = f.Peliculas.Sinopsis,
                                               Genero = f.Peliculas.Generos.Nombre,
                                               salaNombre = f.Salas.Nombre,
                                               Poster = f.Peliculas.Poster,
                                               Trailer = f.Peliculas.Trailer,
                                               Fecha = f.Fecha,
                                               Horario = f.Horario
                                           })
                                           .ToList();
            return lista;
        }







    }
}
