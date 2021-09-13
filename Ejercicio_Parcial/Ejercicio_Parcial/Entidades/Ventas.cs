using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Parcial.Entidades
{
    class Ventas
    {
        private int id_producto;
        private string descripcion_producto;
        private string nombre_producto;
        private int cantidad;
        private double precio;

        public Ventas(int id_producto, string descripcion_producto, string nombre_producto, int cantidad, double precio)
        {
            this.id_producto = id_producto;
            this.descripcion_producto = descripcion_producto;
            this.nombre_producto = nombre_producto;
            this.cantidad = cantidad;
            this.precio = precio;


        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Descripcion_producto { get => descripcion_producto; set => descripcion_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
