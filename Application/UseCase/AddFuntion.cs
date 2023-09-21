using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class AddFuntion : IMetoAddFuntion
    {
        IAddFuntion repo;

        public AddFuntion (IAddFuntion repo)
        {
            this.repo = repo;
        }

        public void addFuntion()
        {
            try 
            {
                Console.Write("Ingrese una fecha (xx/xx): ");
                DateTime fecha = DateTime.Parse(Console.ReadLine());
                Console.Write("Ingrese una hora (HH:mm): ");
                DateTime hora = DateTime.Parse(Console.ReadLine());
                repo.addFuntion(fecha, hora);
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Formato ingresado incompatible.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("demasiados datos ingresado.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("El formato del horario ingresado es erroneo");
            }
        }
    }
}
