using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Entidades.Entidades;

namespace Biblioteca.Windows
{
    public partial class frmAutoresAE : Form
    {
        public frmAutoresAE()
        {
            InitializeComponent();
        }
        private Autor autor;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (autor != null)
            {
                ApellidoTextBox.Text = autor.Apellido;
                nombreTextBox.Text = autor.Nombre;
                nacionalidadTextBox.Text = autor.Nacionalidad;
            }
        }

        public Autor GetAutor()
        {
            return autor;
        }

        private void CancelarIconButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos())
            {
                if (autor == null)
                {
                    autor = new Autor();
                }

                autor.Nombre = nombreTextBox.Text;
                autor.Apellido = ApellidoTextBox.Text;
                autor.Nacionalidad= nacionalidadTextBox.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(ApellidoTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ApellidoTextBox, "El apellido del autor es requerido");
            }

            return valido;
        }

        public void SetAutor(Autor autor)
        {
            this.autor = autor;
        }
    }
}
