
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
            ((System.ComponentModel.ISupportInitialize)(this.numTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vida util del proyecto:";
            // 
            // numTables
            // 
            this.numTables.Location = new System.Drawing.Point(177, 74);
            this.numTables.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTables.Name = "numTables";
            this.numTables.Size = new System.Drawing.Size(72, 26);
            this.numTables.TabIndex = 1;
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
            this.dgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFNE.Location = new System.Drawing.Point(16, 106);
            this.dgvFNE.Name = "dgvFNE";
            this.dgvFNE.RowHeadersWidth = 62;
            this.dgvFNE.RowTemplate.Height = 28;
            this.dgvFNE.Size = new System.Drawing.Size(642, 332);
            this.dgvFNE.TabIndex = 2;
            this.dgvFNE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFNE_CellContentClick);
            // 
            // btnAddTables
            // 
            this.btnAddTables.AutoSize = true;
            this.btnAddTables.Location = new System.Drawing.Point(269, 69);
            this.btnAddTables.Name = "btnAddTables";
            this.btnAddTables.Size = new System.Drawing.Size(136, 35);
            this.btnAddTables.TabIndex = 3;
            this.btnAddTables.Text = "Agregar tablas";
            this.btnAddTables.UseVisualStyleBackColor = true;
            this.btnAddTables.Click += new System.EventHandler(this.btnAddTables_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(687, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Location = new System.Drawing.Point(687, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 35);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.AutoSize = true;
            this.btnAddData.Location = new System.Drawing.Point(522, 69);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(136, 35);
            this.btnAddData.TabIndex = 6;
            this.btnAddData.Text = "Agregar datos";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // FrmFNESF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddTables);
            this.Controls.Add(this.dgvFNE);
            this.Controls.Add(this.numTables);
            this.Controls.Add(this.label1);
            this.Name = "FrmFNESF";
            this.Text = "FrmFNESF";
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
    }
}