using ProyectoFinal.DaoImplement;
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
        public AnualidadesDaoImpl anualidadesDaoImpl;
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
            frmAnualidadOrdinaria.AnualidadesDaoImpl = anualidadesDaoImpl;
            frmAnualidadOrdinaria.ShowDialog();
        }

        private void anticipadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnualidadAnticipada frmAnualidadAnticipada = new FrmAnualidadAnticipada();
            frmAnualidadAnticipada.AnualidadesDaoImpl = anualidadesDaoImpl;
            frmAnualidadAnticipada.ShowDialog();
        }

        private void diferidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnualidadDiferida frmAnualidadDiferida = new AnualidadDiferida();
            frmAnualidadDiferida.AnualidadesDaoImpl = anualidadesDaoImpl;
            frmAnualidadDiferida.ShowDialog();
        }

        private void perpetuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnualidadPerpetua frmAnualidadPerpetua = new FrmAnualidadPerpetua();
            frmAnualidadPerpetua.AnualidadesDaoImpl = anualidadesDaoImpl;
            frmAnualidadPerpetua.ShowDialog();
        }

        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para usar el programa de flujo de caja debes" +
                "primeramente debes agregar la tabla, puedes elegir que tan grande será la tabla " +
                "con un NumericUpDown, la cual representa la vida util del proyecto, das click en " +
                "Agregar Datos, ahí añades la inversión, TMAR, tipo de depreciación y, para el caso de FNE con financiamiento" +
                "prestamo, tasa de interés del que hace el préstamo y tipo de amortización del proyecto " +
                "luego, al dar al boton Calcular el programa se encargará de hacer los cálculos necesarios " +
                "para mostrar los flujos netos de efectivo, el programa también permite exportar la tabla " +
                "a Excel, por último, el programa puede calcular el VPN y la TIR, para evaluar si el proyecto " +
                "es conveniente o no.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void anualidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAnualidadesList frmAnualidadesList = new FrmAnualidadesList();
            frmAnualidadesList.MdiParent = this;
            frmAnualidadesList.AnualidadesDaoImpl = anualidadesDaoImpl;
            frmAnualidadesList.Show();
        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            anualidadesDaoImpl = new AnualidadesDaoImpl();
        }
    }
}
