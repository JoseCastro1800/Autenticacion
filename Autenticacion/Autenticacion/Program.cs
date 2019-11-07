using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autenticacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro r = new Registro();
            Usuario u = new Usuario();
            u.Nombre = "Jose Castro";
            u.Username = "Manolo";
            u.Password = "963214";
            r.RegistrarUsuario(u, "archivo.txt");

            
            Login L = new Login();
            L.Bienvenido();
            L.Ingresar_Datos();

            Console.ReadKey();



            
        }

       


            


        


    }
}
