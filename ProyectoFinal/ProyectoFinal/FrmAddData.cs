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
    public partial class FrmAddData : Form
    {
        public int VidaUtil { get; set; }
        public FrmFNESF FrmFNESF { get; set; }
        public FrmAddData()
        {
            InitializeComponent();
        }

        private void FrmAddData_Load(object sender, EventArgs e)
        {
            txtVidaUtil.Text = VidaUtil.ToString();
            cbMetodos.Items.AddRange(Enum.GetValues(typeof(MetodoDepreciacion))
                                          .Cast<object>().ToArray());
            cbMetodos.SelectedIndex = 0;
            cbMetodos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFNESF.proyecto.Inversion = Convert.ToDecimal(txtInversion.Text);
                if (FrmFNESF.proyecto.Inversion <= 0)
                {
                    MessageBox.Show("La inversión no puede ser menor o igual a 0", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FrmFNESF.proyecto.ValorResidual = Convert.ToDecimal(txtVR.Text);
                if (FrmFNESF.proyecto.ValorResidual < 0)
                {
                    MessageBox.Show("El valor residual no puede ser negativo", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (FrmFNESF.proyecto.ValorResidual > FrmFNESF.proyecto.Inversion)
                {
                    MessageBox.Show("El valor residual no puede ser igual a la inversión", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FrmFNESF.proyecto.TMAR = Convert.ToDecimal(txtTMAR.Text) / 100;
                if (FrmFNESF.proyecto.TMAR < 0 || FrmFNESF.proyecto.TMAR > 1)
                {
                    MessageBox.Show("Valor de TMAR inválido", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FrmFNESF.IndexDepreciacion = cbMetodos.SelectedIndex;
                FrmFNESF.MostrarTMAR();
                FrmFNESF.LoadDepreciacion();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos inválidos", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
