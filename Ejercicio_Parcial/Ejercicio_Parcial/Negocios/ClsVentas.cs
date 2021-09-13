using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Parcial.Entidades;

namespace Ejercicio_Parcial.Negocios
{
    class ClsVentas
    {
        public string cobro(Ventas ventas) 
        {
            if (ventas.Id_producto < 1 || ventas.Id_producto > 5)
            {
                return "Ingrese el id del del producto: ";
            }
            else if (ventas.Nombre_producto == "")
            {
                return "Ingrese el nomobre del producto: ";

            }
            else if (ventas.Descripcion_producto == "")
            {
                return "Ingrese la descripcion del producto: ";
            }
            else if (ventas.Cantidad == 0)
            {
                return "Ingresa la cantidad a comprar: ";
            }
            else if (ventas.Precio == 0 ) ;
                double total = ventas.Precio * ventas.Cantidad;

            if (ventas.Precio > 50)
            {
                double descuento = total - (total * 0.20);
                Console.WriteLine("aplica al 20% de descuento su total es de " + descuento);
            }
            else
            {
                Console.WriteLine("no aplica descuento su total es" + total);
            }

            return "";
        }
    }
}
