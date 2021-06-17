using ProyectoFinal.Amortizacion;
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
    public partial class FrmFNECF : Form
    {
        public ProyectoCF proyecto;
        DataTable dt;
        const decimal IR = 0.30m;
        //List<decimal> ingresos = new List<decimal>();
        //List<decimal> costos = new List<decimal>();
        double[] FNE;
        CuotaNivelada amortizacion = new CuotaNivelada();
        public decimal[] Depreciacion { get; set; }
        public int IndexDepreciacion { get; set; }
        public FrmFNECF()
        {
            InitializeComponent();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
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
            dt.Rows.Add("Intereses"); //3
            dt.Rows.Add("Utilidad antes de impuesto"); //4
            dt.Rows.Add("IR (30%)"); //5
            dt.Rows.Add("Utilidad después de impuesto"); //6
            dt.Rows.Add("Depreciacion"); //7
            dt.Rows.Add("Egresos no afectos de impuesto"); //8
            dt.Rows.Add("Ingresos no afectos de impuesto"); //9
            dt.Rows.Add("Valor de rescate"); //10
            dt.Rows.Add("Abono al principal"); //11           
            dt.Rows.Add("Prestamo"); //12
            dt.Rows.Add("Inversion"); //13
            dt.Rows.Add("Flujos netos de efectivo"); //14
            dgvFNECF.DataSource = dt;
            dgvFNECF.Rows[0].ReadOnly = false;
            dgvFNECF.Rows[1].ReadOnly = false;
            dgvFNECF.Rows[2].ReadOnly = true;
            dgvFNECF.Rows[3].ReadOnly = true;
            dgvFNECF.Rows[4].ReadOnly = true;
            dgvFNECF.Rows[5].ReadOnly = true;
            dgvFNECF.Rows[6].ReadOnly = true;
            dgvFNECF.Rows[7].ReadOnly = true;
            dgvFNECF.Rows[8].ReadOnly = false;
            dgvFNECF.Rows[9].ReadOnly = false;
            dgvFNECF.Rows[10].ReadOnly = true;
            dgvFNECF.Rows[11].ReadOnly = true;
            dgvFNECF.Rows[12].ReadOnly = true;
            dgvFNECF.Rows[13].ReadOnly = true;
            dgvFNECF.Rows[14].ReadOnly = true;
            formatearCeldas();
        }

        private void FrmFNECF_Load(object sender, EventArgs e)
        {
            proyecto = new ProyectoCF();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (dgvFNECF.DataSource == null)
            {
                MessageBox.Show("La tabla está vacía", "Mensaje de error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowCount = dgvFNECF.Rows.Count;
            int colCount = dgvFNECF.ColumnCount;
            //for (int i = 1; i < colCount; i++)
            //{
            //    decimal ingreso = 0;
            //    decimal costo = 0;
            //    decimal.TryParse(dgvFNECF.Rows[0].Cells[i].Value.ToString(), out ingreso);
            //    decimal.TryParse(dgvFNECF.Rows[1].Cells[i].Value.ToString(), out costo);
            //    ingresos.Add(ingreso);
            //    costos.Add(costo);
            //}
            for (int i = 1; i < colCount; i++)
            {
                decimal ingreso = 0;
                decimal costo = 0;
                decimal.TryParse(dgvFNECF.Rows[0].Cells[i].Value.ToString(), out ingreso);
                decimal.TryParse(dgvFNECF.Rows[1].Cells[i].Value.ToString(), out costo);
                decimal dep = 0;
                decimal.TryParse(dgvFNECF.Rows[2].Cells[i].Value.ToString(), out dep);
                decimal interes = 0;
                decimal.TryParse(dgvFNECF.Rows[3].Cells[i].Value.ToString(), out interes);
                decimal uai = ingreso - costo - dep - interes;
                dgvFNECF.Rows[4].Cells[i].Value = uai;
                decimal imp = uai * IR;
                dgvFNECF.Rows[5].Cells[i].Value = imp;
                decimal udi = uai - imp;
                dgvFNECF.Rows[6].Cells[i].Value = uai - imp;

                decimal egresos_no_afectos_de_impuesto = 0;
                decimal ingresos_no_afectos_de_impuesto = 0;
                decimal valor_de_rescate = 0;
                decimal abono = 0;
                decimal prestamo = 0;
                decimal inversion = 0;

                decimal.TryParse(dgvFNECF.Rows[8].Cells[i].Value.ToString(), out egresos_no_afectos_de_impuesto);
                decimal.TryParse(dgvFNECF.Rows[9].Cells[i].Value.ToString(), out ingresos_no_afectos_de_impuesto);
                decimal.TryParse(dgvFNECF.Rows[10].Cells[i].Value.ToString(), out valor_de_rescate);
                decimal.TryParse(dgvFNECF.Rows[11].Cells[i].Value.ToString(), out abono);
                decimal.TryParse(dgvFNECF.Rows[12].Cells[i].Value.ToString(), out prestamo);
                decimal.TryParse(dgvFNECF.Rows[13].Cells[i].Value.ToString(), out inversion);
                dgvFNECF.Rows[14].Cells[i].Value = udi + dep - egresos_no_afectos_de_impuesto + ingresos_no_afectos_de_impuesto - inversion - abono + prestamo + valor_de_rescate;
                
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            FrmAddDataCF frmAddData = new FrmAddDataCF();
            frmAddData.VidaUtil = proyecto.VidaUtil;
            frmAddData.FrmFNECF = this;
            frmAddData.ShowDialog();
        }

        public void LoadDepreciacion()
        {
            IDepreciacion depreciacion = new DepreciacionFactory()
                .CreateInstance((MetodoDepreciacion)Enum.GetValues(typeof(MetodoDepreciacion))
                                                        .GetValue(IndexDepreciacion));
            Depreciacion = depreciacion.Calcular(proyecto.Inversion,
                                                    proyecto.ValorResidual, proyecto.VidaUtil);
            AsignarInversion();
            dgvFNECF.Rows[10].Cells[dgvFNECF.ColumnCount - 1].Value = proyecto.ValorResidual;
            int colCount = dgvFNECF.ColumnCount;
            for (int i = 2; i < colCount; i++)
            {
                dgvFNECF.Rows[2].Cells[i].Value = Depreciacion[i - 2];
                dgvFNECF.Rows[7].Cells[i].Value = Depreciacion[i - 2];
            }
        }

        private void AsignarInversion()
        {
            dgvFNECF.Rows[13].Cells[1].Value = proyecto.Inversion;
        }

        public void LoadAmortizacion()
        {
            decimal[] intereses = amortizacion.CalcularInteres(proyecto.Prestamo,
                proyecto.Tasa_de_interes_prestamo, proyecto.VidaUtil);
            decimal[] abonos = amortizacion.CalcularAbono(proyecto.Prestamo,
                proyecto.Tasa_de_interes_prestamo, proyecto.VidaUtil);
            AsignarPrestamo();
            int colCount = dgvFNECF.ColumnCount;
            for (int i = 2; i < colCount; i++)
            {
                dgvFNECF.Rows[3].Cells[i].Value = intereses[i - 2];
                dgvFNECF.Rows[11].Cells[i].Value = abonos[i - 2];
            }
        }

        private void AsignarPrestamo()
        {
            dgvFNECF.Rows[12].Cells[1].Value = proyecto.Prestamo;
        }

        private void formatearCeldas()
        {
            for (int i = 0; i < dgvFNECF.ColumnCount; i++)
            {
                this.dgvFNECF.Columns[i].DefaultCellStyle.Format = "N2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvFNECF.DataSource == null)
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
                txtTIR.Text = tir.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo calcular la TIR", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvFNECF.DataSource == null)
            {
                MessageBox.Show("La tabla está vacía", "Matrakazo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                FNE = GetFNE();
                double vpn = Metodos.VPN(FNE, (double)proyecto.TMAR_Mixta);

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

        private double[] GetFNE()
        {
            int colCount = dgvFNECF.ColumnCount;
            double[] FNE = new double[colCount - 1];
            FNE = new double[colCount - 1];
            for (int i = 1; i < colCount; i++)
            {
                double fne = 0;
                double.TryParse(dgvFNECF.Rows[14].Cells[i].Value.ToString(), out fne);
                FNE[i - 1] = fne;
            }
            return FNE;
        }
    }
}
