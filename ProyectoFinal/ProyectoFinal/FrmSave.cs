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
                    throw new ArgumentException("El nombre es requerido");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            nombre = txtNombre.Text;
            this.Close();
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

        private void FrmSave_Load(object sender, EventArgs e)
        {

        }
    }
}
