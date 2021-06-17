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

            if (dgvHistorial.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvHistorial.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvHistorial.Columns[i - 1].HeaderText;
                }

                int k = dgvHistorial.CurrentCell.RowIndex;

                for (int j = 0; j < dgvHistorial.Columns.Count; j++)
                {
                    if (dgvHistorial.Rows[k].Cells[j].Value == null)
                    {
                        continue;
                    }
                    xcelApp.Cells[k + 2, j + 1] = dgvHistorial.Rows[k].Cells[j].Value.ToString();
                }

                //for (int i = 0; i < dgvHistorial.Rows.Count; i++)
                //{
                //    for (int j = 0; j < dgvHistorial.Columns.Count; j++)
                //    {
                //        if (dgvHistorial.Rows[i].Cells[j].Value == null)
                //        {
                //            continue;
                //        }
                //        xcelApp.Cells[i + 2, j + 1] = dgvHistorial.Rows[i].Cells[j].Value.ToString();
                //    }
                //}
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("La tabla está vacía", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvHistorial.DataSource;
            bs.Filter = "Nombre like '%" + txtFinder.Text + "%'";
            dgvHistorial.DataSource = bs;
        }
    }
}
