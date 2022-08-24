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
    public partial class frmEditorialesAE : Form
    {
        public frmEditorialesAE()
        {
            InitializeComponent();
        }
        private Editorial editorial;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (editorial != null)
            {
                EditorialTextBox.Text = editorial.NombreEditorial;
            }
        }

        public Editorial GetEditorial()
        {
            return editorial;
        }

        private void CancelarIconButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos())
            {
                if (editorial == null)
                {
                    editorial = new Editorial();
                }

                editorial.NombreEditorial = EditorialTextBox.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(EditorialTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(EditorialTextBox, "El nombre de la editorial es requerido");
            }

            return valido;
        }

        public void SetEditorial(Editorial editorial)
        {
            this.editorial = editorial;
        }
    }
}
