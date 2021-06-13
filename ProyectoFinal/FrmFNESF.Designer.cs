
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
            // 
            // btnAddTables
            // 
            this.btnAddTables.Location = new System.Drawing.Point(269, 69);
            this.btnAddTables.Name = "btnAddTables";
            this.btnAddTables.Size = new System.Drawing.Size(136, 35);
            this.btnAddTables.TabIndex = 3;
            this.btnAddTables.Text = "Agregar tablas";
            this.btnAddTables.UseVisualStyleBackColor = true;
            this.btnAddTables.Click += new System.EventHandler(this.btnAddTables_Click);
            // 
            // FrmFNESF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTables);
            this.Controls.Add(this.dgvFNE);
            this.Controls.Add(this.numTables);
            this.Controls.Add(this.label1);
            this.Name = "FrmFNESF";
            this.Text = "FrmFNESF";
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
    }
}