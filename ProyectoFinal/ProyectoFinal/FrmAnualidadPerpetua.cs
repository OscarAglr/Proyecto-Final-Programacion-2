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
    public partial class FrmAnualidadPerpetua : Form
    {
        public FrmAnualidadPerpetua
            ()
        {
            InitializeComponent();
            grbAnualidadPerpetua.Paint += PaintBorderlessGroupBox;
        }



        private void PaintBorderlessGroupBox(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            e.Graphics.Clear(SystemColors.Control);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }

        private void txtInteres_TextChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                txtValor.ForeColor = Color.Gray;
                txtValor.Text = "Digite el periodo";
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            txtValor.ForeColor = Color.Black;
            txtValor.Text = "";
        }

        private void txtInteres_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInteres.Text))
            {
                txtInteres.ForeColor = Color.Gray;
                txtInteres.Text = "Digite el periodo";
            }
        }

        private void txtInteres_Enter(object sender, EventArgs e)
        {
            txtInteres.ForeColor = Color.Black;
            txtInteres.Text = "";
        }
        private void CalcularAnualidadActionPerformed()
        {

            if (string.IsNullOrWhiteSpace(txtValor.Text)  || string.IsNullOrWhiteSpace(txtInteres.Text))
            {
                txtAnualidad.Text = "NaN";
                txtAnualidad.ForeColor = Color.Gray;
                return;
            }

            try
            {
                txtAnualidad.Text = Anualidades.ValorPresente.AnualidadPerpetua.APerpetua(float.Parse(txtValor.Text), float.Parse(txtInteres.Text)).ToString();
                txtAnualidad.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                //Nothing
            }

        }

    }
}
