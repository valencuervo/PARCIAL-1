using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUTN.Dominio.Dominio
{
    public class Prestamo : Identificable
    {
        private DateTime _fechaPrestamo;
        private DateTime _fechaDevolucion;
        public bool devolucion;

        public Prestamo() { }

        public Prestamo(Alumno alumno, Copia copia, DateTime fechaPrestamo)
        {
            alumno = alumno;
            copia = copia;
            this._fechaDevolucion = CalcularFechaDevolucion(fechaPrestamo, Constants.DIAS_PRESTAMO);
            devolucion = false;
        }

        public DateTime CalcularFechaDevolucion(DateTime fechaDesde, int dias)
        {
            return fechaDesde.AddDays(dias);
        }

    }
}
