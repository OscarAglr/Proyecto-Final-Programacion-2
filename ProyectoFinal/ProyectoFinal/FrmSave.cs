using ProyectoFinal.DaoImplement;
using ProyectoFinal.poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmSave : Form
    {
        public AnualidadesDaoImpl AnualidadesDaoImpl { get; set; }
        public string nombre;
        public FrmSave()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new ArgumentException("El nombre es requerido.");
                }
                if (!validarNombre())
                {
                    throw new ArgumentException("Ya exite un archivo con ese nombre.");
                }
                nombre = txtNombre.Text;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarNombre()
        {
            if (AnualidadesDaoImpl.GetAll() == null)
            {
                return true;
            }
            foreach (Anualidad a in AnualidadesDaoImpl.GetAll())
            {
                if (a.nombreDelArchivo.Equals(txtNombre.Text,StringComparison.InvariantCultureIgnoreCase))
                {
                  return false;
                }
            }

            return true;
        }

        public string getNombre()
        {
            return nombre;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('.') || e.KeyChar.Equals('_')|| e.KeyChar.Equals('-'))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
