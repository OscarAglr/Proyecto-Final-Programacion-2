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
            FrmFNESF.proyecto.Inversion = Convert.ToDecimal(txtInversion.Text);
            FrmFNESF.proyecto.ValorResidual = Convert.ToDecimal(txtVR.Text);
            FrmFNESF.proyecto.TMAR = Convert.ToDecimal(txtTMAR.Text)/100;
            FrmFNESF.IndexDepreciacion = cbMetodos.SelectedIndex;
            FrmFNESF.LoadDepreciacion();
            this.Close();
        }
    }
}
