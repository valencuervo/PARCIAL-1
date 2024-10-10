using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUTN.Dominio.Dominio
{
    public class Alumno : Identificable
    {
        public string nombre;
        public string apellido;
        public string dni;
        public string legajo;
        public bool deuda;
        public Alumno() { }

        public Alumno(String nombre, String apellido, String dni, String legajo, bool deuda = false)
        {
            this.nombre = nombre; this.apellido = apellido;
            this.dni = dni;
            this.legajo = legajo;
            this.deuda = deuda;

        }

    }
}
