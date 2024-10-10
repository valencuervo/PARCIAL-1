using BibliotecaUTN.Dominio.Dominio;

namespace BibliotecaUTN.Servicios
{
    public class AlumnoServicio
    {
        public static Alumno Crear(List<Alumno> alumnos)
        {
            
            Console.WriteLine("Registrar nuevo alumno");
            {
                Console.WriteLine("Registrar nuevo alumno");
                Console.WriteLine("ingrese el nombre del alumno: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("ingrese el apellido: ");
                string apellido = Console.ReadLine();
                Console.WriteLine("ingrese el dni: ");
                string dni = Console.ReadLine();
                Console.WriteLine("ingrese el legajo");
                string legajo = Console.ReadLine();
                bool deuda = true;
        

                Alumno NuevoAlumno = new Alumno(nombre, apellido, dni, legajo, deuda);


                alumnos.Add(NuevoAlumno);




                return NuevoAlumno;

            }
        }
    }
}
