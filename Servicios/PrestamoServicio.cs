using BibliotecaUTN.Dominio.Dominio;

namespace BibliotecaUTN.Servicios
{
    public class PrestamoServicio
    {
        internal static void Actualizar(Prestamo prestamo)
        {
            Console.WriteLine("Vamos a hacer una devolucion");
        }

        internal static void Crear(List<Libro> libros)
        {
            Console.WriteLine("Vamos a crear un prestamo");
          
        }

        internal static void Listar(List<Alumno> alumnos)
        {
            Console.WriteLine("Todos los alumnos con deuda atrasada");
            bool Haydeuda = false;
            foreach (var alumno in alumnos)
            {
                if (alumno.deuda)
                {
                    Console.WriteLine($"{alumno.nombre} {alumno.apellido} {alumno.dni} {alumno.legajo}");
                    Haydeuda = true;
                }
            }
            if (!Haydeuda)
            {
                Console.WriteLine("no hay alumnos con deuda");

            }
        }
    }
}

