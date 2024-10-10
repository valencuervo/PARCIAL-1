using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BibliotecaUTN.Dominio.Dominio
{
    public class Libro : Identificable
    {
        private string _ISBN;
        private string _titulo;
        private List<Copia> _copias;

        public Libro() : base()
        {
            _copias = new List<Copia>();
        }

        public Libro(String titulo, String isbn, String autor, String descripcion): this()
        {
            
        }

    }
}
