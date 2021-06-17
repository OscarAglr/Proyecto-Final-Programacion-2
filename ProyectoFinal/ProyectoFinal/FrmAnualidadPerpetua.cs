using ProyectoFinal.Anualidades.ValorPresente;
using ProyectoFinal.DaoImplement;
using ProyectoFinal.Enums;
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
    public partial class FrmAnualidadPerpetua : Form
    {
        public AnualidadesDaoImpl AnualidadesDaoImpl { get; set; }

        public FrmAnualidadPerpetua()
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                TextBoxs_ValidationsContent(out float valor, out float interes, out float anualidad);

                FrmSave frmSave = new FrmSave();
                frmSave.ShowDialog();
                string nombre = frmSave.getNombre();

                Anualidad a = new Anualidad()
                {
                    nombreDelArchivo = nombre,
                    tipoA = TipoDeAnualidad.Perpetua,
                    valor = valor,
                    vidaUtil = float.PositiveInfinity,
                    periodo = Perpetua.INFINITY,
                    interes = interes,
                    tasa = Perpetua.INFINITY,
                    anualidad = anualidad
                };
                AnualidadesDaoImpl.Create(a);

                CleanAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void TextBoxs_ValidationsContent(out float valor, out float interes, out float anualidad)
        {
            if (!float.TryParse(txtValor.Text, out float v))
            {
                //txtValor.Focus();
                throw new ArgumentException($"Se necesita un valor presente/futuro.");
            }
            if (!float.TryParse(txtInteres.Text, out float i))
            {
                //txtInteres.Focus();
                throw new ArgumentException($"Se nesecita especificar la tasa de interes.");
            }
            if (!float.TryParse(txtAnualidad.Text, out float a))
            {
                throw new ArgumentException($"La anualidad no esta definida, verifique que haya llenado todos los datos.");
            }
            valor = v;
            interes = i;
            anualidad = a;
        }
        private void CleanAll()
        {
            txtInteres.ForeColor = Color.Gray;
            txtInteres.Text = "Digite la tasa";

            txtValor.ForeColor = Color.Gray;
            txtValor.Text = "Digite el valor";

            txtAnualidad.Text = "NaN";
            txtAnualidad.ForeColor = Color.Gray;
        }
        private void CalcularAnualidadActionPerformed()
        {

            if (string.IsNullOrWhiteSpace(txtValor.Text) || string.IsNullOrWhiteSpace(txtInteres.Text))
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
