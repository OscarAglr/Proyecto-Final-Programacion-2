using ProyectoFinal.Enums;
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
    public partial class FrmAnualidadAnticipada : Form
    {
        public FrmAnualidadAnticipada()
        {
            InitializeComponent();
            grbAnualidadTemplate.Paint += PaintBorderlessGroupBox;
            grbValor.Paint += PaintBorderlessGroupBox;
            grbTasa.Paint += PaintBorderlessGroupBox;
        }

      

        private void PaintBorderlessGroupBox(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            e.Graphics.Clear(SystemColors.Control);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void FrmAnualidadAnticipada_Load(object sender, EventArgs e)
        {
            cmbPeriodos.Items.AddRange(Enum.GetValues(typeof(Periodos)).Cast<object>().ToArray());
            cmbPeriodos.SelectedIndex = 0;
            cmbTipoInteres.Items.AddRange(Enum.GetValues(typeof(Tasas)).Cast<object>().ToArray());
            cmbTipoInteres.SelectedIndex = 0;
            txtValor.Focus();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_TextBox(e, txtValor);
        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_TextBox(e, txtInteres);
        }

        private void txtPeriodos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion_TextBox(e, txtPeriodos);
        }

        private void rbtnVP_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int v))
            {
                return;
            }
            txtValor.Focus();
            txtValor.SelectAll();
        }

        private void rbtnVF_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int v))
            {
                return;
            }
            txtValor.Focus();
            txtValor.SelectAll();
        }

        private void rbtnTasaPeriodica_Click(object sender, EventArgs e)
        {
            cmbTipoInteres.Enabled = true;

            if (int.TryParse(txtInteres.Text, out int v))
            {
                cmbTipoInteres.Focus();
                txtInteres.SelectAll();
                return;
            }

            txtInteres.Focus();
            txtInteres.SelectAll();
        }

        private void rbtnTasaEfectiva_Click(object sender, EventArgs e)
        {
            cmbTipoInteres.Enabled = false;
            if (int.TryParse(txtInteres.Text, out int v))
            {
                cmbTipoInteres.Focus();
                txtInteres.SelectAll();
                return;
            }
            txtInteres.Focus();
            txtInteres.SelectAll();
        }


        private void cmbTipoInteres_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }

        private void cmbPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }

        private void rbtnVP_CheckedChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }

        private void rbtnVF_CheckedChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }

        private void rbtnTasaEfectiva_CheckedChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }

        private void rbtnTasaPeriodica_CheckedChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();

        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            txtValor.ForeColor = Color.Black;
            txtValor.Text = "";
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                txtValor.ForeColor = Color.Gray;
                txtValor.Text = "Digite el valor";
            }
        }

        private void txtInteres_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInteres.Text))
            {
                txtInteres.ForeColor = Color.Gray;
                txtInteres.Text = "Digite la tasa";
            }
        }

        private void txtInteres_Enter(object sender, EventArgs e)
        {
            txtInteres.ForeColor = Color.Black;
            txtInteres.Text = "";
        }

        private void txtPeriodos_Enter(object sender, EventArgs e)
        {
            txtPeriodos.ForeColor = Color.Black;
            txtPeriodos.Text = "";
        }

        private void txtPeriodos_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPeriodos.Text))
            {
                txtPeriodos.ForeColor = Color.Gray;
                txtPeriodos.Text = "Digite el periodo";
            }
        }


        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }

        private void txtInteres_TextChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }

        private void txtPeriodos_TextChanged(object sender, EventArgs e)
        {
            CalcularAnualidadActionPerformed();
        }
        private void Validacion_TextBox(KeyPressEventArgs e, TextBox txt)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (e.KeyChar.Equals('.'))
            {
                if (txt.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }
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

        private void CalcularAnualidadActionPerformed()
        {

            if (string.IsNullOrWhiteSpace(txtValor.Text) || string.IsNullOrWhiteSpace(txtPeriodos.Text) || string.IsNullOrWhiteSpace(txtInteres.Text))
            {
                txtAnualidad.Text = "NaN";
                txtAnualidad.ForeColor = Color.Gray;
                return;
            }

            try
            {

                if (rbtnVF.Checked == true)
                {
                    AnualidadConValorFuturo();
                }
                else if (rbtnVP.Checked == true)
                {
                    AnualidadConValorPresente();

                }

                txtAnualidad.ForeColor = Color.Black;

            }
            catch (FormatException)
            {
                //Nothing
            }

        }

        private void AnualidadConValorFuturo()
        {
            if (rbtnTasaEfectiva.Checked == true)
            {

                switch (cmbPeriodos.SelectedIndex)
                {
                    case 0:
                        {
                            txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                ), float.Parse(txtPeriodos.Text), 6).ToString();

                            break;
                        }
                    case 1:
                        {
                            txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                ), float.Parse(txtPeriodos.Text), 4).ToString();
                            break;
                        }
                    case 2:
                        {
                            txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                 ), float.Parse(txtPeriodos.Text), 3).ToString();
                            break;
                        }
                    case 3:
                        {
                            txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                 ), float.Parse(txtPeriodos.Text), 2).ToString();
                            break;
                        }
                    case 4:
                        {
                            txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                 ), float.Parse(txtPeriodos.Text), 12).ToString();
                            break;
                        }
                    case 5:
                        {
                            txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                             ), float.Parse(txtPeriodos.Text), 1).ToString();
                            break;
                        }
                }
            }
            else if (rbtnTasaPeriodica.Checked == true)
            {
                switch (cmbTipoInteres.SelectedIndex)
                {

                    case 0:
                        {

                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 1).ToString();
                                        break;
                                    }

                            }
                            break;
                        }
                    case 1:
                        {
                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 1).ToString();
                                        break;
                                    }

                            }
                            break;
                        }
                    case 2:
                        {
                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 1).ToString();
                                        break;
                                    }

                            }
                            break;
                        }
                    case 3:
                        {
                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 1).ToString();
                                        break;
                                    }

                            }
                            break;
                        }
                    case 4:
                        {

                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorFuturo.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 1).ToString();
                                        break;
                                    }

                            }
                            break;
                        }
                }
            }


        }

        private void AnualidadConValorPresente()
        {
            if (rbtnTasaEfectiva.Checked == true)
            {
                switch (cmbPeriodos.SelectedIndex)
                {
                    case 0:
                        {
                            txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                ), float.Parse(txtPeriodos.Text), 6).ToString();

                            break;
                        }
                    case 1:
                        {
                            txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                ), float.Parse(txtPeriodos.Text), 4).ToString();
                            break;
                        }
                    case 2:
                        {
                            txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                 ), float.Parse(txtPeriodos.Text), 3).ToString();
                            break;
                        }
                    case 3:
                        {
                            txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                 ), float.Parse(txtPeriodos.Text), 2).ToString();
                            break;
                        }
                    case 4:
                        {
                            txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                                 ), float.Parse(txtPeriodos.Text), 12).ToString();
                            break;
                        }
                    case 5:
                        {
                            txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaAnual(float.Parse(txtInteres.Text), float.Parse(txtValor.Text
                             ), float.Parse(txtPeriodos.Text), 1).ToString();
                            break;
                        }
                }
            }
            else if (rbtnTasaPeriodica.Checked == true)
            {
                switch (cmbTipoInteres.SelectedIndex)
                {

                    case 0:
                        {

                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 6, 1).ToString();
                                        break;
                                    }


                            }
                            break;
                        }
                    case 1:
                        {
                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 4, 1).ToString();
                                        break;
                                    }


                            }
                            break;
                        }
                    case 2:
                        {
                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 3, 1).ToString();
                                        break;
                                    }


                            }
                            break;
                        }
                    case 3:
                        {
                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 2, 1).ToString();
                                        break;
                                    }


                            }
                            break;
                        }
                    case 4:
                        {

                            switch (cmbPeriodos.SelectedIndex)
                            {
                                case 0:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 6).ToString();

                                        break;
                                    }
                                case 1:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 4).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 3).ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 2).ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 12).ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        txtAnualidad.Text = Anualidades.ValorPresente.AnualidadAnticipada.TasaPeriodica(float.Parse(txtInteres.Text), float.Parse(txtValor.Text), float.Parse(txtPeriodos.Text), 12, 1).ToString();
                                        break;
                                    }


                            }
                            break;
                        }
                }
            }
        }
    }
}
