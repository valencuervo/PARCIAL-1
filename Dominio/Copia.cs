
namespace BibliotecaUTN.Dominio.Dominio
{
    public class Copia
    {
        private Boolean _disponible;
        private Libro _libro;

        public Copia(Libro libro)
        {
            _libro = libro;
            _disponible = true;
        }
    }
}
