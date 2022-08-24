using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.Entidades
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public int Ejemplares { get; set; }
        public int GeneroId { get; set; }
        public int IdiomaId { get; set; }
        public int EditorialId { get; set; }
        public double Precio { get; set; }
        public byte[] RowVersion { get; set; }
        public Autor Autor { get; set; }
        public GeneroLiterario GeneroLiterario { get; set; }
        public Idioma Idioma { get; set; }
        public Editorial Editorial { get; set; }
    }
}
