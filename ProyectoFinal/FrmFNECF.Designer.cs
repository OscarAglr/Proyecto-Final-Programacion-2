
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
            this.dgvFNECF.Location = new System.Drawing.Point(12, 125);
            this.dgvFNECF.Name = "dgvFNECF";
            this.dgvFNECF.RowHeadersWidth = 62;
            this.dgvFNECF.RowTemplate.Height = 28;
            this.dgvFNECF.Size = new System.Drawing.Size(624, 313);
            this.dgvFNECF.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vida util del proyecto";
            // 
            // numTables
            // 
            this.numTables.Location = new System.Drawing.Point(173, 93);
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
            this.btnAddTable.Location = new System.Drawing.Point(264, 88);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(147, 35);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Agregar tablas";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // FrmFNECF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.numTables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFNECF);
            this.Name = "FrmFNECF";
            this.Text = "FrmFNECF";
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
    }
}