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
    public partial class FrmFNECF : Form
    {
        DataTable dt;
        public FrmFNECF()
        {
            InitializeComponent();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            int n = (int)numTables.Value;
            LoadTable(n);
        }

        private void LoadTable(int n)
        {
            dt = new DataTable();
            dt.Columns.Add(" ");
            for (int i = 0; i <= n; i++)
            {
                dt.Columns.Add($"{i}");
            }
            dt.Rows.Add("Ingresos");
            dt.Rows.Add("Costos");
            dt.Rows.Add("Depreciacion");
            dt.Rows.Add("Intereses");
            dt.Rows.Add("Utilidad antes de impuesto");
            dt.Rows.Add("IR (30%)");
            dt.Rows.Add("Utilidad después de impuesto");
            dt.Rows.Add("Depreciacion");
            dt.Rows.Add("Egresos no afectos de impuesto");
            dt.Rows.Add("Ingresos no afectos de impuesto");
            dt.Rows.Add("Abono al principal");
            dt.Rows.Add("Prestamo");
            dt.Rows.Add("Flujos netos de efectivo");
            dgvFNECF.DataSource = dt;
        }
    }
}
