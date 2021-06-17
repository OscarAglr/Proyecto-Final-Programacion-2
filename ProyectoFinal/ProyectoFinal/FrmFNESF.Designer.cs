
namespace ProyectoFinal
{
    partial class FrmFNESF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numTables = new System.Windows.Forms.NumericUpDown();
            this.dgvFNE = new System.Windows.Forms.DataGridView();
            this.btnAddTables = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVPN = new System.Windows.Forms.TextBox();
            this.txtTIR = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTMAR = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vida util del proyecto:";
            // 
            // numTables
            // 
            this.numTables.Location = new System.Drawing.Point(177, 48);
            this.numTables.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numTables.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTables.Name = "numTables";
            this.numTables.Size = new System.Drawing.Size(72, 26);
            this.numTables.TabIndex = 1;
            this.numTables.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTables.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvFNE
            // 
            this.dgvFNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFNE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFNE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFNE.Location = new System.Drawing.Point(16, 84);
            this.dgvFNE.Name = "dgvFNE";
            this.dgvFNE.RowHeadersWidth = 62;
            this.dgvFNE.RowTemplate.Height = 28;
            this.dgvFNE.Size = new System.Drawing.Size(772, 372);
            this.dgvFNE.TabIndex = 2;
            this.dgvFNE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFNE_CellContentClick);
            // 
            // btnAddTables
            // 
            this.btnAddTables.AutoSize = true;
            this.btnAddTables.Location = new System.Drawing.Point(255, 43);
            this.btnAddTables.Name = "btnAddTables";
            this.btnAddTables.Size = new System.Drawing.Size(136, 35);
            this.btnAddTables.TabIndex = 3;
            this.btnAddTables.Text = "Agregar tablas";
            this.btnAddTables.UseVisualStyleBackColor = true;
            this.btnAddTables.Click += new System.EventHandler(this.btnAddTables_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(177, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular TIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Location = new System.Drawing.Point(683, 465);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 35);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddData.AutoSize = true;
            this.btnAddData.Location = new System.Drawing.Point(652, 43);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(136, 35);
            this.btnAddData.TabIndex = 6;
            this.btnAddData.Text = "Agregar datos";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "VPN";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TIR";
            // 
            // txtVPN
            // 
            this.txtVPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVPN.Location = new System.Drawing.Point(59, 474);
            this.txtVPN.Name = "txtVPN";
            this.txtVPN.Size = new System.Drawing.Size(100, 26);
            this.txtVPN.TabIndex = 9;
            this.txtVPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVPN_KeyPress);
            // 
            // txtTIR
            // 
            this.txtTIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTIR.Location = new System.Drawing.Point(59, 509);
            this.txtTIR.Name = "txtTIR";
            this.txtTIR.Size = new System.Drawing.Size(100, 26);
            this.txtTIR.TabIndex = 10;
            this.txtTIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTIR_KeyPress);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(177, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Calcular VPN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "TMAR";
            // 
            // txtTMAR
            // 
            this.txtTMAR.Location = new System.Drawing.Point(72, 16);
            this.txtTMAR.Name = "txtTMAR";
            this.txtTMAR.ReadOnly = true;
            this.txtTMAR.Size = new System.Drawing.Size(100, 26);
            this.txtTMAR.TabIndex = 13;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(637, 505);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(151, 35);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Exportar a Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmFNESF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtTMAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTIR);
            this.Controls.Add(this.txtVPN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddTables);
            this.Controls.Add(this.dgvFNE);
            this.Controls.Add(this.numTables);
            this.Controls.Add(this.label1);
            this.Name = "FrmFNESF";
            this.Text = "Flujo de caja sin financiamiento";
            this.Load += new System.EventHandler(this.FrmFNESF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTables;
        private System.Windows.Forms.DataGridView dgvFNE;
        private System.Windows.Forms.Button btnAddTables;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVPN;
        private System.Windows.Forms.TextBox txtTIR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTMAR;
        private System.Windows.Forms.Button btnExport;
    }
}