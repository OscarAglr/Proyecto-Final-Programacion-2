using ProyectoFinal.Anualidades.ValorPresente;
using ProyectoFinal.DaoImplement;
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
    public partial class FrmAnualidadesList : Form
    {
        public AnualidadesDaoImpl AnualidadesDaoImpl { get; set; }
        DataTable dt;
        public FrmAnualidadesList()
        {
            InitializeComponent();
        }

        private void FrmAnualidadesList_Load(object sender, EventArgs e)
        {
            Load_Historial();
        }

        public void Load_Historial()
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.Rows.Clear();

            dt = new DataTable();

            dt.Columns.Add("Tipo de Anualidad");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Tipo De Valor");
            dt.Columns.Add("Valor");
            dt.Columns.Add("Tasa");
            dt.Columns.Add("Interes");
            dt.Columns.Add("Vida Util");
            dt.Columns.Add("Periodos");
            dt.Columns.Add("Periodo de Gracia");
            dt.Columns.Add("Anualidad");

            if (AnualidadesDaoImpl.GetAll() == null)
            {
                return;
            }

            foreach (Anualidad a in AnualidadesDaoImpl.GetAll())
            {
                DataRow dr = dt.NewRow();



                dr["Tipo de Anualidad"] = a.tipoA;
                dr["Nombre"] = a.nombreDelArchivo;
                dr["Tipo De Valor"] = a.tipoV;
                dr["Valor"] = a.valor;
                dr["Tasa"] = a.interes;
                dr["Interes"] = a.tasa;
                dr["Vida Util"] = a.vidaUtil;
                dr["Periodos"] = a.periodo;
                dr["Periodo de Gracia"] = "";
                dr["Anualidad"] = a.anualidad;
 
                dt.Rows.Add(dr);

            }
            

            dgvHistorial.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.Rows.Count == 0)
            {
                return;
            }
            int index = dgvHistorial.CurrentCell.RowIndex;
            AnualidadesDaoImpl.Delete(index);
            Load_Historial();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
