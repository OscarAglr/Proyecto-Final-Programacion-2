
namespace ProyectoFinal
{
    partial class FrmFNECF
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
            this.dgvFNECF = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numTables = new System.Windows.Forms.NumericUpDown();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTIR = new System.Windows.Forms.TextBox();
            this.txtVPN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVPN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNECF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTables)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFNECF
            // 
            this.dgvFNECF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFNECF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFNECF.Location = new System.Drawing.Point(12, 88);
            this.dgvFNECF.Name = "dgvFNECF";
            this.dgvFNECF.RowHeadersWidth = 62;
            this.dgvFNECF.RowTemplate.Height = 28;
            this.dgvFNECF.Size = new System.Drawing.Size(776, 372);
            this.dgvFNECF.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vida util del proyecto";
            // 
            // numTables
            // 
            this.numTables.Location = new System.Drawing.Point(173, 56);
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
            this.numTables.Size = new System.Drawing.Size(68, 26);
            this.numTables.TabIndex = 2;
            this.numTables.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(264, 51);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(147, 35);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Agregar tablas";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnData
            // 
            this.btnData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnData.Location = new System.Drawing.Point(644, 51);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(144, 35);
            this.btnData.TabIndex = 4;
            this.btnData.Text = "Agregar datos";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(683, 505);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 35);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTIR
            // 
            this.txtTIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTIR.Location = new System.Drawing.Point(59, 511);
            this.txtTIR.Name = "txtTIR";
            this.txtTIR.Size = new System.Drawing.Size(100, 26);
            this.txtTIR.TabIndex = 15;
            // 
            // txtVPN
            // 
            this.txtVPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVPN.Location = new System.Drawing.Point(59, 476);
            this.txtVPN.Name = "txtVPN";
            this.txtVPN.Size = new System.Drawing.Size(100, 26);
            this.txtVPN.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "TIR";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "VPN";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(173, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular TIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVPN
            // 
            this.btnVPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVPN.Location = new System.Drawing.Point(173, 472);
            this.btnVPN.Name = "btnVPN";
            this.btnVPN.Size = new System.Drawing.Size(125, 35);
            this.btnVPN.TabIndex = 16;
            this.btnVPN.Text = "Calcular VPN";
            this.btnVPN.UseVisualStyleBackColor = true;
            this.btnVPN.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmFNECF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.btnVPN);
            this.Controls.Add(this.txtTIR);
            this.Controls.Add(this.txtVPN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.numTables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFNECF);
            this.Name = "FrmFNECF";
            this.Text = "Flujo de caja con financiamiento";
            this.Load += new System.EventHandler(this.FrmFNECF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNECF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFNECF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTables;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTIR;
        private System.Windows.Forms.TextBox txtVPN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVPN;
    }
}