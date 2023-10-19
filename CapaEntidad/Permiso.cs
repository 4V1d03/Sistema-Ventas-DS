using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        public Rol oRol { get; set; } // oRol = objeto Rol, se omite el campo IdRol de la tabla Permiso, haciendo referencia a la clase Rol
        public string NombreMenu { get; set; }
        public string FechaRegistro { get; set; }
















    }
}
