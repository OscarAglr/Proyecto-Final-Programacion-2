
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
            this.anualidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuPrograma.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuPrograma.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPrograma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem});
            this.menuPrograma.Location = new System.Drawing.Point(0, 0);
            this.menuPrograma.Name = "menuPrograma";
            this.menuPrograma.Size = new System.Drawing.Size(800, 33);
            this.menuPrograma.TabIndex = 1;
            this.menuPrograma.Text = "menuStrip2";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anualidadesToolStripMenuItem,
            this.flujosNetosDeEfectivoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // anualidadesToolStripMenuItem
            // 
            this.anualidadesToolStripMenuItem.Name = "anualidadesToolStripMenuItem";
            this.anualidadesToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.anualidadesToolStripMenuItem.Text = "Anualidades";
            // 
            // flujosNetosDeEfectivoToolStripMenuItem
            // 
            this.flujosNetosDeEfectivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinFinanciamientoToolStripMenuItem,
            this.conFinanciamientoToolStripMenuItem});
            this.flujosNetosDeEfectivoToolStripMenuItem.Name = "flujosNetosDeEfectivoToolStripMenuItem";
            this.flujosNetosDeEfectivoToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.flujosNetosDeEfectivoToolStripMenuItem.Text = "Flujos netos de efectivo";
            // 
            // sinFinanciamientoToolStripMenuItem
            // 
            this.sinFinanciamientoToolStripMenuItem.Name = "sinFinanciamientoToolStripMenuItem";
            this.sinFinanciamientoToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.sinFinanciamientoToolStripMenuItem.Text = "Sin financiamiento";
            this.sinFinanciamientoToolStripMenuItem.Click += new System.EventHandler(this.sinFinanciamientoToolStripMenuItem_Click);
            // 
            // conFinanciamientoToolStripMenuItem
            // 
            this.conFinanciamientoToolStripMenuItem.Name = "conFinanciamientoToolStripMenuItem";
            this.conFinanciamientoToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.conFinanciamientoToolStripMenuItem.Text = "Con financiamiento";
            this.conFinanciamientoToolStripMenuItem.Click += new System.EventHandler(this.conFinanciamientoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(298, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrograma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMDI";
            this.Text = "Proyecto";
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
    }
}

