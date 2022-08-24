using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Entidades.Entidades;

namespace Biblioteca.Windows.Helpers
{
    public static class HelperGrid
    {
        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            if (obj is Autor)
            {
                r.Cells[0].Value = ((Autor)obj).Apellido;
                r.Cells[1].Value = ((Autor)obj).Nombre;
                r.Cells[2].Value = ((Autor)obj).Nacionalidad;
            }
            else if (obj is Editorial)
            {
                r.Cells[0].Value = ((Editorial)obj).NombreEditorial;
            }

            r.Tag = obj;

        }
    }
}
