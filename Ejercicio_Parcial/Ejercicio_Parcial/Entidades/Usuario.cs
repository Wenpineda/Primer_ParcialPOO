using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Parcial.Entidades
{
    class Usuario
    {
        private string nombre;
        private string contraseña;

        public Usuario()
        {
        }

        public Usuario(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public override string ToString()
        {
            return " Su nombre es: "+ nombre + " su contraseña es : " + contraseña;
        }
    }
}
