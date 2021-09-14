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
        public String Cobro(Ventas ventas)
        {
            double total = ventas.Precio * ventas.Cantidad;

            if (ventas.Precio > 50)
            {
                double descuento = total - (total * 0.20);
                Console.WriteLine("aplica al 20% de descuento su total es de " + descuento);
            }
            else
            {
                Console.WriteLine("no aplica descuento su total es" + total);

                Console.ReadLine();
            }

        }
    }
}
