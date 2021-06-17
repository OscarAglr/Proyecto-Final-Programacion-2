using ProyectoFinal.Depreciacion;
using ProyectoFinal.Enums;
using ProyectoFinal.MetodosDeEvaluacion;
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
    public partial class FrmFNESF : Form
    {
        public Proyecto proyecto;
        DataTable dt;
        const decimal IR = 0.30m;
        //List<decimal> ingresos = new List<decimal>();
        //List<decimal> costos = new List<decimal>();
        double[] FNE;
        public decimal[] Depreciacion { get; set; }
        public int IndexDepreciacion { get; set; }
        public FrmFNESF()
        {
            InitializeComponent();
        }

        private void btnAddTables_Click(object sender, EventArgs e)
        {
            proyecto.VidaUtil = (int)numTables.Value;
            LoadTable(proyecto.VidaUtil);
        }

        private void LoadTable(int n)
        { 
            dt = new DataTable();
            dt.Columns.Add(" ");
            for (int i = 0; i <= n; i++)
            {
                dt.Columns.Add($"{i}", typeof(decimal));
            }
            dt.Rows.Add("Ingresos"); //0
            dt.Rows.Add("Egresos"); //1
            dt.Rows.Add("Depreciacion"); //2
            dt.Rows.Add("Utilidad antes de impuesto"); //3
            dt.Rows.Add("IR (30%)"); //4
            dt.Rows.Add("Utilidad después de impuesto"); //5
            dt.Rows.Add("Ajustes por depreciacion"); //6
            dt.Rows.Add("Egresos no afectos de impuesto");//7
            dt.Rows.Add("Ingresos no afectos de impuesto"); //8
            dt.Rows.Add("Valor de rescate"); //9
            dt.Rows.Add("Inversion"); //10
            dt.Rows.Add("Flujos netos de efectivo"); //11
            dgvFNE.DataSource = dt;
            dgvFNE.Rows[0].ReadOnly = false;
            dgvFNE.Rows[1].ReadOnly = false;
            dgvFNE.Rows[2].ReadOnly = true;
            dgvFNE.Rows[3].ReadOnly = true;
            dgvFNE.Rows[4].ReadOnly = true;
            dgvFNE.Rows[5].ReadOnly = true;
            dgvFNE.Rows[6].ReadOnly = true;
            dgvFNE.Rows[7].ReadOnly = false;
            dgvFNE.Rows[8].ReadOnly = false;
            dgvFNE.Rows[9].ReadOnly = true;
            dgvFNE.Rows[10].ReadOnly = true;
            dgvFNE.Rows[11].ReadOnly = true;
            formatearCeldas();
            quitarSort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvFNE.DataSource == null)
            {
                MessageBox.Show("La tabla está vacía", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                FNE = GetFNE();
                double tir = Metodos.TIR(FNE) * 100;
                if ((decimal)tir / 100 < proyecto.TMAR)
                {
                    txtTIR.ForeColor = Color.Red;
                } 
                else if ((decimal)tir / 100 > proyecto.TMAR)
                {
                    txtTIR.ForeColor = Color.Green;
                }
                //MessageBox.Show($"{x}\n{y}");
                txtTIR.Text = tir.ToString("N2");
            } catch (Exception ex)
            {
                MessageBox.Show("No se pudo calcular la TIR", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (dgvFNE.DataSource == null)
            {
                MessageBox.Show("La tabla está vacía", "Matrakazo", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowCount = dgvFNE.Rows.Count;
            int colCount = dgvFNE.ColumnCount;
            //for (int i = 1; i < colCount; i++)
            //{
            //    decimal ingreso = 0;
            //    decimal costo = 0;
            //    decimal.TryParse(dgvFNE.Rows[0].Cells[i].Value.ToString(), out ingreso);
            //    decimal.TryParse(dgvFNE.Rows[1].Cells[i].Value.ToString(), out costo);
            //    ingresos.Add(ingreso);
            //    costos.Add(costo);
            //}
            for (int i = 1; i < colCount; i++)
            {
                decimal ingreso = 0;
                decimal costo = 0;
                decimal.TryParse(dgvFNE.Rows[0].Cells[i].Value.ToString(), out ingreso);
                decimal.TryParse(dgvFNE.Rows[1].Cells[i].Value.ToString(), out costo);
                decimal dep = 0;
                decimal.TryParse(dgvFNE.Rows[2].Cells[i].Value.ToString(), out dep);
                decimal uai = ingreso - costo - dep;
                dgvFNE.Rows[3].Cells[i].Value = uai;
                decimal imp = uai * IR;
                dgvFNE.Rows[4].Cells[i].Value = imp;
                decimal udi = uai - imp;
                dgvFNE.Rows[5].Cells[i].Value = udi;
                
                decimal egresos_no_afectos_de_impuesto = 0;
                decimal ingresos_no_afectos_de_impuesto = 0;
                decimal valor_de_rescate = 0;
                decimal inversion = 0;
                
                decimal.TryParse(dgvFNE.Rows[7].Cells[i].Value.ToString(), out egresos_no_afectos_de_impuesto);
                decimal.TryParse(dgvFNE.Rows[8].Cells[i].Value.ToString(), out ingresos_no_afectos_de_impuesto);
                decimal.TryParse(dgvFNE.Rows[9].Cells[i].Value.ToString(), out valor_de_rescate);
                decimal.TryParse(dgvFNE.Rows[10].Cells[i].Value.ToString(), out inversion);
                 
                dgvFNE.Rows[11].Cells[i].Value = udi + dep - egresos_no_afectos_de_impuesto + ingresos_no_afectos_de_impuesto - inversion + valor_de_rescate;
            }
        }

        private double[] GetFNE()
        {
            int colCount = dgvFNE.ColumnCount;
            double[] FNE = new double[colCount - 1];
            FNE = new double[colCount - 1];
            for (int i = 1; i < colCount; i++)
            {
                double fne = 0;
                double.TryParse(dgvFNE.Rows[11].Cells[i].Value.ToString(), out fne);
                FNE[i - 1] = fne;
            }
            return FNE;
        }

        private void FrmFNESF_Load(object sender, EventArgs e)
        {
            proyecto = new Proyecto();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (dgvFNE.DataSource == null)
            {
                MessageBox.Show("La tabla está vacía", "Mensaje de error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmAddData frmAddData = new FrmAddData();
            frmAddData.VidaUtil = proyecto.VidaUtil;
            frmAddData.FrmFNESF = this;
            frmAddData.ShowDialog();
        }

        public void LoadDepreciacion ()
        {
            IDepreciacion depreciacion = new DepreciacionFactory()
                .CreateInstance((MetodoDepreciacion)Enum.GetValues(typeof(MetodoDepreciacion))
                                                        .GetValue(IndexDepreciacion));
            Depreciacion = depreciacion.Calcular(proyecto.Inversion, 
                                                    proyecto.ValorResidual, proyecto.VidaUtil);
            AsignarInversion();
            dgvFNE.Rows[9].Cells[dgvFNE.ColumnCount - 1].Value = proyecto.ValorResidual;
            int colCount = dgvFNE.ColumnCount;
            for (int i = 2; i < colCount; i++)
            {
                dgvFNE.Rows[2].Cells[i].Value = Depreciacion[i - 2];
                dgvFNE.Rows[6].Cells[i].Value = Depreciacion[i - 2];
            }
        }

        private void AsignarInversion()
        {
            dgvFNE.Rows[10].Cells[1].Value = proyecto.Inversion;
        }

        private void formatearCeldas()
        {
            for (int i = 0; i < dgvFNE.ColumnCount; i++)
            {
                this.dgvFNE.Columns[i].DefaultCellStyle.Format = "N2";
            }
        }

        private void dgvFNE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtVPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTIR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void quitarSort()
        {
            foreach (DataGridViewColumn column in dgvFNE.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void MostrarTMAR()
        {
            try
            {
                txtTMAR.Text = $"{proyecto.TMAR * 100}%";
            }
            catch
            {
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvFNE.DataSource == null)
            {
                MessageBox.Show("La tabla está vacía", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                FNE = GetFNE();
                double vpn = Metodos.VPN(FNE, (double)proyecto.TMAR);
                if (vpn > 0)
                {
                    txtVPN.ForeColor = Color.Green;
                }
                else if (vpn < 0)
                {
                    txtVPN.ForeColor = Color.Red;
                }
                txtVPN.Text = vpn.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo calcular el VPN", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvFNE.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvFNE.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvFNE.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvFNE.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvFNE.Columns.Count; j++)
                    {
                        if (dgvFNE.Rows[i].Cells[j].Value == null)
                        {
                            continue;
                        }
                        xcelApp.Cells[i + 2, j + 1] = dgvFNE.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("La tabla está vacía", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
