using Application;
using Application.Interfaces;
using Application.UseCase;
using Domain.Entities;
using Domain.Interfaces;
using Infraestructure;

namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
                {
                try
                {
                    using (var ctx = new CineContext())
                    {
                        Console.WriteLine("Bienvenidos al cine\n");
                        Console.WriteLine("Por favor elija una opcion\n1 - Listar funciones\n2 - Registrar funcion\n3 - Salir\n");
                        Console.Write("Ingrese una opcion: ");
                        int opcion = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        switch (opcion)
                        {
                            case 1:
                                try 
                                {
                                    Console.WriteLine("opciones de listado:\n1 - Listar por titulo\n2 - Listar por dia\n3 - Listar por titulo y dia\n4 - volver al menu\n");
                                    IRepository repo = new Repositorio(ctx);
                                    IListar lista;
                                    Console.Write("Ingrese una opcion: ");
                                    int opcion2 = int.Parse(Console.ReadLine());
                                    switch (opcion2) 
                                    {
                                        case 1:
                                            lista = new ListarTitulo(repo);
                                            lista.listar();
                                            break;
                                        case 2:
                                            lista = new ListarDia(repo);
                                            lista.listar();
                                            break;
                                        case 3:
                                            lista = new ListarDiaTitu(repo);
                                            lista.listar();
                                            break;
                                        case 4:
                                            break;              //no hace nada y vuelve al menu
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
                                break;
                            case 2:
                                IAddFuntion repo2 = new repoAddFuntion(ctx);
                                IMetoAddFuntion generador = new AddFuntion(repo2);
                                generador.addFuntion();
                                break;
                            case 3:
                                menu = false;
                                break;
                            default:
                                Console.WriteLine("El número no coincide con ningún caso.\n");
                                break;
                        }
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
                    Console.Clear();
                    Console.WriteLine("ha ocurrido un error inesperado.\n");
                }
             }
            Console.WriteLine("Gracias por utilizar nuestros servicios. Que tenga un buen dia :)");
        }
    }
}
