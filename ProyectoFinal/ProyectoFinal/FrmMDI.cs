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
    public partial class FrmMDI : Form
    {
        
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sinFinanciamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFNESF fNESF = new FrmFNESF();
            fNESF.MdiParent = this;
            fNESF.Show();
        }

        private void conFinanciamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFNECF fNECF = new FrmFNECF();
            fNECF.MdiParent = this;
            fNECF.Show();
        }

        private void ordinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnualidadOrdinaria frmAnualidadOrdinaria = new FrmAnualidadOrdinaria();
            frmAnualidadOrdinaria.ShowDialog();
        }

        private void anticipadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnualidadAnticipada frmAnualidadAnticipada = new FrmAnualidadAnticipada();
            frmAnualidadAnticipada.ShowDialog();
        }

        private void diferidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnualidadDiferida frmAnualidadDiferida = new FrmAnualidadDiferida();
            frmAnualidadDiferida.ShowDialog();
        }

        private void perpetuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnualidadPerpetua frmAnualidadPerpetua = new FrmAnualidadPerpetua();
            frmAnualidadPerpetua.ShowDialog();
        }
    }
}
