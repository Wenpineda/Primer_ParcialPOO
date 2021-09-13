using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Parcial.Entidades;

namespace Ejercicio_Parcial.Negocios
{
    class ClsUsuario
    {
        public int Y { get; internal set; }

        public string Acceso(Usuario usuario) 
        {
            if (usuario.Nombre == "")
            {
                return "Ingresa tu nombre: ";
            } 
            else if (usuario.Contraseña == "")
            {
                return "Ingresa tu contraseña: ";
            }
            else
            {
                return "Inicio de sesion correcto puede continuar con el proceso de venta";
            }

        }
    }
}
