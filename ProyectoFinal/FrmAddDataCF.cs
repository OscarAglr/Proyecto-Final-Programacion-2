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
                FrmFNECF.proyecto.ValorResidual = Convert.ToDecimal(txtVR.Text);
                FrmFNECF.proyecto.TMAR = Convert.ToDecimal(txtTMAR.Text)/100;
                FrmFNECF.IndexDepreciacion = cbMetodos.SelectedIndex;
                FrmFNECF.proyecto.Prestamo = Convert.ToDecimal(txtPrestamo.Text);
                FrmFNECF.proyecto.Tasa_de_interes_prestamo = Convert.ToDecimal(txtTasaInteres.Text)/100;
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
