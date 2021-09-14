using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Parcial.Entidades;
using Ejercicio_Parcial.Negocios;

namespace Ejercicio_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            ClsUsuario clsusuario = new ClsUsuario();

            String nombre = Console.ReadLine();
            string contraseña = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escribe tu nombre");
            nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba su clave de accesos");
            contraseña = Convert.ToString(Console.ReadLine());
            Usuario Cons = new Usuario(nombre, contraseña);
            ClsUsuario clsUsuario = new ClsUsuario();
           

            Console.WriteLine(clsUsuario.Acceso(Cons));

            if (clsUsuario.Y == 1) 
            {
                int x = 1;
                while (x == 1)
                {
                    Console.WriteLine("ingrese el id del producto");
                    double id_producto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese el nombre del producto");
                    string nombre_producto = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("ingrese la descripcion del producto");
                    string descripcion_producto = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("ingrese la descripcion del producto");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese la cantidad del producto");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    Ventas vent = new Ventas(id_producto, descripcion_producto, nombre_producto, cantidad, precio);

                    ClsVentas cls = new ClsVentas();

                 
                    Console.WriteLine(cls.Cobro(vent));
                    Console.WriteLine(usuario.ToString());
                    Console.WriteLine(vent.ToString());
                    Console.ReadLine();

                }
            }

        }

    }
    
}
