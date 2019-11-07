using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
    public class Login
    {
        //Aqui el usuario ingresa sus datos pero se guardan los registros
        public void Ingresar_Datos()
        {
            Usuario usuario = new Usuario();
            Console.WriteLine("Ingrese su nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su username:");
            usuario.Username = Console.ReadLine();   
            Console.WriteLine("Ingrese su contrasenia");
            usuario.Password = Console.ReadLine();

            Registro r = new Registro();
            string ruta = "Datos txt";
            List<string> datos = r.ObtenerLineas(ruta);
            
        }

        //Aqui al momento de registrarse e ingresar los datos se verificara si sus datos son validos
        public void Validar_Datos(Usuario u, IList<string> Datos)
        {
            List<Usuario> usuarios = new List<Usuario>();

            foreach(var Item in Datos)
            {
                string[] Info = Item.Split(',');
                usuarios.Add(new Usuario { Nombre = Info[0], Username = Info[0], Password = Info[0] });
                   
                
            }
            foreach(var us in usuarios)
            {
                if(u.Username == us.Username && u.Password==us.Password)
                {
                    Bienvenido();
                    

                }

            }
        }

        public void Bienvenido()
        {
            Console.WriteLine("Bienvenido");
        }
    }
}
