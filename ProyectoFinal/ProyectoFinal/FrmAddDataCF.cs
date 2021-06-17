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
    public partial class FrmAddDataCF : Form
    {
        public int VidaUtil { get; set; }
        public FrmFNECF FrmFNECF { get; set; }
        public FrmAddDataCF()
        {
            InitializeComponent();
        }

        private void FrmAddDataCF_Load(object sender, EventArgs e)
        {
            txtVidaUtil.Text = VidaUtil.ToString();
            cbMetodos.Items.AddRange(Enum.GetValues(typeof(MetodoDepreciacion))
                                          .Cast<object>().ToArray());
            cbMetodos.SelectedIndex = 0;
            cbMetodos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAmortizacion.Items.AddRange(Enum.GetValues(typeof(MetodoAmortizacion))
                                          .Cast<object>().ToArray());
            cbAmortizacion.SelectedIndex = 0;
            cbAmortizacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFNECF.proyecto.Inversion = Convert.ToDecimal(txtInversion.Text);

                if (FrmFNECF.proyecto.Inversion <= 0)
                {
                    MessageBox.Show("La inversión no puede ser menor o igual a 0", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmFNECF.proyecto.ValorResidual = Convert.ToDecimal(txtVR.Text);

                if (FrmFNECF.proyecto.ValorResidual < 0)
                {
                    MessageBox.Show("El valor residual no puede ser negativo", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (FrmFNECF.proyecto.ValorResidual > FrmFNECF.proyecto.Inversion)
                {
                    MessageBox.Show("El valor residual no puede ser igual a la inversión", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmFNECF.proyecto.TMAR = Convert.ToDecimal(txtTMAR.Text)/100;

                if (FrmFNECF.proyecto.TMAR < 0 || FrmFNECF.proyecto.TMAR > 1)
                {
                    MessageBox.Show("Valor de TMAR inválido", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmFNECF.IndexDepreciacion = cbMetodos.SelectedIndex;

                FrmFNECF.proyecto.Prestamo = Convert.ToDecimal(txtPrestamo.Text);

                if (FrmFNECF.proyecto.Prestamo < 0)
                {
                    MessageBox.Show("El préstamo no puede ser negativo", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmFNECF.proyecto.Tasa_de_interes_prestamo = Convert.ToDecimal(txtTasaInteres.Text)/100;

                if (FrmFNECF.proyecto.Tasa_de_interes_prestamo < 0 || FrmFNECF.proyecto.Tasa_de_interes_prestamo > 100)
                {
                    MessageBox.Show("Valor de tasa de interés inválido", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                decimal total = FrmFNECF.proyecto.Inversion + FrmFNECF.proyecto.Prestamo;

                FrmFNECF.proyecto.TMAR_Mixta = (FrmFNECF.proyecto.Inversion / total) * FrmFNECF.proyecto.TMAR
                    + (FrmFNECF.proyecto.Prestamo / total) * FrmFNECF.proyecto.Tasa_de_interes_prestamo;

                int index_amortizacion = cbAmortizacion.SelectedIndex;

                FrmFNECF.proyecto.Tipo_de_amortizacion = (MetodoAmortizacion)Enum.GetValues(typeof(MetodoAmortizacion))
                                                        .GetValue(index_amortizacion);

                FrmFNECF.MostrarTMARMixta();
                FrmFNECF.LoadDepreciacion();
                FrmFNECF.LoadAmortizacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos inválidos", "Mensaje de error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
