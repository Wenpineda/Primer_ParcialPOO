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
            public string venderproducto(Ventas producto, int cantidad, double precio);Dd


        }
    }
}
