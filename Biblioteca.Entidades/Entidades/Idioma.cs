using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.Entidades
{
    public class Idioma
    {
        public int IdiomaId { get; set; }
        public string Descripcion { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
