
namespace ProyectoFinal
{
    partial class FrmMDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDI));
            this.menuPrograma = new System.Windows.Forms.MenuStrip();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anticipadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diferidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perpetuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesUniformesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmeticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flujosNetosDeEfectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinFinanciamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conFinanciamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrograma.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrograma
            // 
            this.menuPrograma.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPrograma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem});
            this.menuPrograma.Location = new System.Drawing.Point(0, 0);
            this.menuPrograma.Name = "menuPrograma";
            this.menuPrograma.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuPrograma.Size = new System.Drawing.Size(816, 33);
            this.menuPrograma.TabIndex = 1;
            this.menuPrograma.Text = "menuStrip2";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anualidadesToolStripMenuItem1,
            this.anualidadesToolStripMenuItem,
            this.flujosNetosDeEfectivoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.catalogoToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(232, 29);
            this.catalogoToolStripMenuItem.Text = "Funciones Financieras";
            // 
            // anualidadesToolStripMenuItem1
            // 
            this.anualidadesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordinariaToolStripMenuItem,
            this.anticipadaToolStripMenuItem,
            this.diferidaToolStripMenuItem,
            this.perpetuaToolStripMenuItem});
            this.anualidadesToolStripMenuItem1.Name = "anualidadesToolStripMenuItem1";
            this.anualidadesToolStripMenuItem1.Size = new System.Drawing.Size(314, 30);
            this.anualidadesToolStripMenuItem1.Text = "Anualidades";
            // 
            // ordinariaToolStripMenuItem
            // 
            this.ordinariaToolStripMenuItem.Name = "ordinariaToolStripMenuItem";
            this.ordinariaToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.ordinariaToolStripMenuItem.Text = "Ordinaria";
            this.ordinariaToolStripMenuItem.Click += new System.EventHandler(this.ordinariaToolStripMenuItem_Click);
            // 
            // anticipadaToolStripMenuItem
            // 
            this.anticipadaToolStripMenuItem.Name = "anticipadaToolStripMenuItem";
            this.anticipadaToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.anticipadaToolStripMenuItem.Text = "Anticipada";
            this.anticipadaToolStripMenuItem.Click += new System.EventHandler(this.anticipadaToolStripMenuItem_Click);
            // 
            // diferidaToolStripMenuItem
            // 
            this.diferidaToolStripMenuItem.Name = "diferidaToolStripMenuItem";
            this.diferidaToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.diferidaToolStripMenuItem.Text = "Diferida";
            this.diferidaToolStripMenuItem.Click += new System.EventHandler(this.diferidaToolStripMenuItem_Click);
            // 
            // perpetuaToolStripMenuItem
            // 
            this.perpetuaToolStripMenuItem.Name = "perpetuaToolStripMenuItem";
            this.perpetuaToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.perpetuaToolStripMenuItem.Text = "Perpetua";
            this.perpetuaToolStripMenuItem.Click += new System.EventHandler(this.perpetuaToolStripMenuItem_Click);
            // 
            // anualidadesToolStripMenuItem
            // 
            this.anualidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seriesUniformesToolStripMenuItem,
            this.aritmeticoToolStripMenuItem});
            this.anualidadesToolStripMenuItem.Name = "anualidadesToolStripMenuItem";
            this.anualidadesToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.anualidadesToolStripMenuItem.Text = "Series Con Gradientes";
            // 
            // seriesUniformesToolStripMenuItem
            // 
            this.seriesUniformesToolStripMenuItem.Name = "seriesUniformesToolStripMenuItem";
            this.seriesUniformesToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.seriesUniformesToolStripMenuItem.Text = "Geometrico";
            // 
            // aritmeticoToolStripMenuItem
            // 
            this.aritmeticoToolStripMenuItem.Name = "aritmeticoToolStripMenuItem";
            this.aritmeticoToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.aritmeticoToolStripMenuItem.Text = "Aritmetico";
            // 
            // flujosNetosDeEfectivoToolStripMenuItem
            // 
            this.flujosNetosDeEfectivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinFinanciamientoToolStripMenuItem,
            this.conFinanciamientoToolStripMenuItem});
            this.flujosNetosDeEfectivoToolStripMenuItem.Name = "flujosNetosDeEfectivoToolStripMenuItem";
            this.flujosNetosDeEfectivoToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.flujosNetosDeEfectivoToolStripMenuItem.Text = "Flujos netos de efectivo";
            // 
            // sinFinanciamientoToolStripMenuItem
            // 
            this.sinFinanciamientoToolStripMenuItem.Name = "sinFinanciamientoToolStripMenuItem";
            this.sinFinanciamientoToolStripMenuItem.Size = new System.Drawing.Size(279, 30);
            this.sinFinanciamientoToolStripMenuItem.Text = "Sin financiamiento";
            this.sinFinanciamientoToolStripMenuItem.Click += new System.EventHandler(this.sinFinanciamientoToolStripMenuItem_Click);
            // 
            // conFinanciamientoToolStripMenuItem
            // 
            this.conFinanciamientoToolStripMenuItem.Name = "conFinanciamientoToolStripMenuItem";
            this.conFinanciamientoToolStripMenuItem.Size = new System.Drawing.Size(279, 30);
            this.conFinanciamientoToolStripMenuItem.Text = "Con financiamiento";
            this.conFinanciamientoToolStripMenuItem.Click += new System.EventHandler(this.conFinanciamientoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(311, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 466);
            this.Controls.Add(this.menuPrograma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMDI";
            this.Text = "EXCEL PIOLA UWU";
            this.menuPrograma.ResumeLayout(false);
            this.menuPrograma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrograma;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flujosNetosDeEfectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinFinanciamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conFinanciamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriesUniformesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmeticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anticipadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diferidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perpetuaToolStripMenuItem;
    }
}

