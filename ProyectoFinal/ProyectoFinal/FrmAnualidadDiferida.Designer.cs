
namespace ProyectoFinal
{
    partial class FrmAnualidadDiferida
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
            this.rbtnVP = new System.Windows.Forms.RadioButton();
            this.rbtnVF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAnualidadDiferida = new System.Windows.Forms.GroupBox();
            this.txtPeriodoDeGracia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnualidad = new System.Windows.Forms.TextBox();
            this.cmbPeriodos = new System.Windows.Forms.ComboBox();
            this.txtPeriodos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoInteres = new System.Windows.Forms.ComboBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbTasa = new System.Windows.Forms.GroupBox();
            this.rbtnTasaEfectiva = new System.Windows.Forms.RadioButton();
            this.rbtnTasaPeriodica = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.grbValor = new System.Windows.Forms.GroupBox();
            this.grbAnualidadDiferida.SuspendLayout();
            this.grbTasa.SuspendLayout();
            this.grbValor.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnVP
            // 
            this.rbtnVP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnVP.AutoSize = true;
            this.rbtnVP.Checked = true;
            this.rbtnVP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnVP.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVP.Location = new System.Drawing.Point(6, 21);
            this.rbtnVP.Name = "rbtnVP";
            this.rbtnVP.Size = new System.Drawing.Size(174, 24);
            this.rbtnVP.TabIndex = 0;
            this.rbtnVP.TabStop = true;
            this.rbtnVP.Text = "Valor Presente (p)";
            this.rbtnVP.UseVisualStyleBackColor = true;
            this.rbtnVP.CheckedChanged += new System.EventHandler(this.rbtnVP_CheckedChanged);
            this.rbtnVP.Click += new System.EventHandler(this.rbtnVP_Click);
            // 
            // rbtnVF
            // 
            this.rbtnVF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnVF.AutoSize = true;
            this.rbtnVF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnVF.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVF.Location = new System.Drawing.Point(6, 93);
            this.rbtnVF.Name = "rbtnVF";
            this.rbtnVF.Size = new System.Drawing.Size(157, 24);
            this.rbtnVF.TabIndex = 0;
            this.rbtnVF.Text = "Valor Futuro (f)";
            this.rbtnVF.UseVisualStyleBackColor = true;
            this.rbtnVF.CheckedChanged += new System.EventHandler(this.rbtnVF_CheckedChanged);
            this.rbtnVF.Click += new System.EventHandler(this.rbtnVF_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Valor";
            // 
            // grbAnualidadDiferida
            // 
            this.grbAnualidadDiferida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAnualidadDiferida.Controls.Add(this.txtPeriodoDeGracia);
            this.grbAnualidadDiferida.Controls.Add(this.label6);
            this.grbAnualidadDiferida.Controls.Add(this.label5);
            this.grbAnualidadDiferida.Controls.Add(this.txtAnualidad);
            this.grbAnualidadDiferida.Controls.Add(this.cmbPeriodos);
            this.grbAnualidadDiferida.Controls.Add(this.txtPeriodos);
            this.grbAnualidadDiferida.Controls.Add(this.label4);
            this.grbAnualidadDiferida.Controls.Add(this.cmbTipoInteres);
            this.grbAnualidadDiferida.Controls.Add(this.txtInteres);
            this.grbAnualidadDiferida.Controls.Add(this.label3);
            this.grbAnualidadDiferida.Controls.Add(this.grbTasa);
            this.grbAnualidadDiferida.Controls.Add(this.label2);
            this.grbAnualidadDiferida.Controls.Add(this.txtValor);
            this.grbAnualidadDiferida.Controls.Add(this.grbValor);
            this.grbAnualidadDiferida.Controls.Add(this.label1);
            this.grbAnualidadDiferida.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAnualidadDiferida.Location = new System.Drawing.Point(12, 12);
            this.grbAnualidadDiferida.Name = "grbAnualidadDiferida";
            this.grbAnualidadDiferida.Size = new System.Drawing.Size(722, 757);
            this.grbAnualidadDiferida.TabIndex = 3;
            this.grbAnualidadDiferida.TabStop = false;
            this.grbAnualidadDiferida.Text = "Datosn del ejercicio";
            // 
            // txtPeriodoDeGracia
            // 
            this.txtPeriodoDeGracia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriodoDeGracia.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoDeGracia.ForeColor = System.Drawing.Color.Gray;
            this.txtPeriodoDeGracia.Location = new System.Drawing.Point(249, 595);
            this.txtPeriodoDeGracia.Name = "txtPeriodoDeGracia";
            this.txtPeriodoDeGracia.Size = new System.Drawing.Size(206, 29);
            this.txtPeriodoDeGracia.TabIndex = 12;
            this.txtPeriodoDeGracia.Text = "Periodo de gracia";
            this.txtPeriodoDeGracia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPeriodoDeGracia.TextChanged += new System.EventHandler(this.txtPeriodoDeGracia_TextChanged);
            this.txtPeriodoDeGracia.Enter += new System.EventHandler(this.txtPeriodoDeGracia_Enter);
            this.txtPeriodoDeGracia.Leave += new System.EventHandler(this.txtPeriodoDeGracia_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "4. Periodo de gracia (k)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 712);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "A = ";
            // 
            // txtAnualidad
            // 
            this.txtAnualidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnualidad.Enabled = false;
            this.txtAnualidad.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnualidad.Location = new System.Drawing.Point(225, 702);
            this.txtAnualidad.Name = "txtAnualidad";
            this.txtAnualidad.ReadOnly = true;
            this.txtAnualidad.Size = new System.Drawing.Size(251, 39);
            this.txtAnualidad.TabIndex = 0;
            this.txtAnualidad.Text = "NaN";
            this.txtAnualidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodos.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriodos.FormattingEnabled = true;
            this.cmbPeriodos.Location = new System.Drawing.Point(333, 478);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Size = new System.Drawing.Size(206, 30);
            this.cmbPeriodos.TabIndex = 4;
            this.cmbPeriodos.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodos_SelectedIndexChanged);
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriodos.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodos.ForeColor = System.Drawing.Color.Gray;
            this.txtPeriodos.Location = new System.Drawing.Point(127, 479);
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.Size = new System.Drawing.Size(200, 29);
            this.txtPeriodos.TabIndex = 3;
            this.txtPeriodos.Text = "Digite el periodo";
            this.txtPeriodos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPeriodos.TextChanged += new System.EventHandler(this.txtPeriodos_TextChanged);
            this.txtPeriodos.Enter += new System.EventHandler(this.txtPeriodos_Enter);
            this.txtPeriodos.Leave += new System.EventHandler(this.txtPeriodos_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "3. Periodo (n)";
            // 
            // cmbTipoInteres
            // 
            this.cmbTipoInteres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInteres.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoInteres.FormattingEnabled = true;
            this.cmbTipoInteres.Location = new System.Drawing.Point(272, 369);
            this.cmbTipoInteres.Name = "cmbTipoInteres";
            this.cmbTipoInteres.Size = new System.Drawing.Size(212, 30);
            this.cmbTipoInteres.TabIndex = 10;
            this.cmbTipoInteres.SelectedIndexChanged += new System.EventHandler(this.cmbTipoInteres_SelectedIndexChanged);
            // 
            // txtInteres
            // 
            this.txtInteres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInteres.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.ForeColor = System.Drawing.Color.Gray;
            this.txtInteres.Location = new System.Drawing.Point(524, 334);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(166, 29);
            this.txtInteres.TabIndex = 2;
            this.txtInteres.Text = "Digite la tasa";
            this.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInteres.TextChanged += new System.EventHandler(this.txtInteres_TextChanged);
            this.txtInteres.Enter += new System.EventHandler(this.txtInteres_Enter);
            this.txtInteres.Leave += new System.EventHandler(this.txtInteres_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(696, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "%";
            // 
            // grbTasa
            // 
            this.grbTasa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTasa.BackColor = System.Drawing.Color.Transparent;
            this.grbTasa.Controls.Add(this.rbtnTasaEfectiva);
            this.grbTasa.Controls.Add(this.rbtnTasaPeriodica);
            this.grbTasa.Location = new System.Drawing.Point(53, 284);
            this.grbTasa.Name = "grbTasa";
            this.grbTasa.Size = new System.Drawing.Size(213, 138);
            this.grbTasa.TabIndex = 6;
            this.grbTasa.TabStop = false;
            // 
            // rbtnTasaEfectiva
            // 
            this.rbtnTasaEfectiva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnTasaEfectiva.AutoSize = true;
            this.rbtnTasaEfectiva.Checked = true;
            this.rbtnTasaEfectiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTasaEfectiva.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTasaEfectiva.Location = new System.Drawing.Point(6, 21);
            this.rbtnTasaEfectiva.Name = "rbtnTasaEfectiva";
            this.rbtnTasaEfectiva.Size = new System.Drawing.Size(163, 24);
            this.rbtnTasaEfectiva.TabIndex = 0;
            this.rbtnTasaEfectiva.TabStop = true;
            this.rbtnTasaEfectiva.Text = "Tasa Efectiva (i)";
            this.rbtnTasaEfectiva.UseVisualStyleBackColor = true;
            this.rbtnTasaEfectiva.CheckedChanged += new System.EventHandler(this.rbtnTasaEfectiva_CheckedChanged);
            this.rbtnTasaEfectiva.Click += new System.EventHandler(this.rbtnTasaEfectiva_Click);
            // 
            // rbtnTasaPeriodica
            // 
            this.rbtnTasaPeriodica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnTasaPeriodica.AutoSize = true;
            this.rbtnTasaPeriodica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTasaPeriodica.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTasaPeriodica.Location = new System.Drawing.Point(6, 88);
            this.rbtnTasaPeriodica.Name = "rbtnTasaPeriodica";
            this.rbtnTasaPeriodica.Size = new System.Drawing.Size(184, 24);
            this.rbtnTasaPeriodica.TabIndex = 0;
            this.rbtnTasaPeriodica.Text = "Tasa Periodica (ip)";
            this.rbtnTasaPeriodica.UseVisualStyleBackColor = true;
            this.rbtnTasaPeriodica.CheckedChanged += new System.EventHandler(this.rbtnTasaPeriodica_CheckedChanged);
            this.rbtnTasaPeriodica.Click += new System.EventHandler(this.rbtnTasaPeriodica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "2. Tasa de interes (i)";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Gray;
            this.txtValor.Location = new System.Drawing.Point(272, 136);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(241, 29);
            this.txtValor.TabIndex = 1;
            this.txtValor.Text = "Digite el valor";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // grbValor
            // 
            this.grbValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbValor.BackColor = System.Drawing.Color.Transparent;
            this.grbValor.Controls.Add(this.rbtnVP);
            this.grbValor.Controls.Add(this.rbtnVF);
            this.grbValor.Location = new System.Drawing.Point(53, 76);
            this.grbValor.Name = "grbValor";
            this.grbValor.Size = new System.Drawing.Size(213, 144);
            this.grbValor.TabIndex = 3;
            this.grbValor.TabStop = false;
            // 
            // FrmAnualidadDiferida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 781);
            this.Controls.Add(this.grbAnualidadDiferida);
            this.Name = "FrmAnualidadDiferida";
            this.Text = "Anualidad Diferida";
            this.Load += new System.EventHandler(this.FrmAnualidadDiferida_Load);
            this.grbAnualidadDiferida.ResumeLayout(false);
            this.grbAnualidadDiferida.PerformLayout();
            this.grbTasa.ResumeLayout(false);
            this.grbTasa.PerformLayout();
            this.grbValor.ResumeLayout(false);
            this.grbValor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnVP;
        private System.Windows.Forms.RadioButton rbtnVF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbAnualidadDiferida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnualidad;
        private System.Windows.Forms.ComboBox cmbPeriodos;
        private System.Windows.Forms.TextBox txtPeriodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoInteres;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbTasa;
        private System.Windows.Forms.RadioButton rbtnTasaEfectiva;
        private System.Windows.Forms.RadioButton rbtnTasaPeriodica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox grbValor;
        private System.Windows.Forms.TextBox txtPeriodoDeGracia;
        private System.Windows.Forms.Label label6;
    }
}