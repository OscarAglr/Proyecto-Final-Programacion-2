﻿
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
            this.ordinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anticipadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diferidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perpetuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flujosNetosDeEfectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinFinanciamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conFinanciamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrograma.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrograma
            // 
            this.menuPrograma.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPrograma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.historialToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuPrograma.Location = new System.Drawing.Point(0, 0);
            this.menuPrograma.Name = "menuPrograma";
            this.menuPrograma.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuPrograma.Size = new System.Drawing.Size(909, 28);
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
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.catalogoToolStripMenuItem.Text = "Funciones financieras";
            // 
            // anualidadesToolStripMenuItem
            // 
            this.anualidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordinariaToolStripMenuItem,
            this.anticipadaToolStripMenuItem,
            this.diferidaToolStripMenuItem,
            this.perpetuaToolStripMenuItem});
            this.anualidadesToolStripMenuItem.Name = "anualidadesToolStripMenuItem";
            this.anualidadesToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.anualidadesToolStripMenuItem.Text = "Anualidades";
            // 
            // ordinariaToolStripMenuItem
            // 
            this.ordinariaToolStripMenuItem.Name = "ordinariaToolStripMenuItem";
            this.ordinariaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.ordinariaToolStripMenuItem.Text = "Ordinaria";
            this.ordinariaToolStripMenuItem.Click += new System.EventHandler(this.ordinariaToolStripMenuItem_Click);
            // 
            // anticipadaToolStripMenuItem
            // 
            this.anticipadaToolStripMenuItem.Name = "anticipadaToolStripMenuItem";
            this.anticipadaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.anticipadaToolStripMenuItem.Text = "Anticipada";
            this.anticipadaToolStripMenuItem.Click += new System.EventHandler(this.anticipadaToolStripMenuItem_Click);
            // 
            // diferidaToolStripMenuItem
            // 
            this.diferidaToolStripMenuItem.Name = "diferidaToolStripMenuItem";
            this.diferidaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.diferidaToolStripMenuItem.Text = "Diferida";
            this.diferidaToolStripMenuItem.Click += new System.EventHandler(this.diferidaToolStripMenuItem_Click);
            // 
            // perpetuaToolStripMenuItem
            // 
            this.perpetuaToolStripMenuItem.Name = "perpetuaToolStripMenuItem";
            this.perpetuaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.perpetuaToolStripMenuItem.Text = "Perpetua";
            this.perpetuaToolStripMenuItem.Click += new System.EventHandler(this.perpetuaToolStripMenuItem_Click);
            // 
            // flujosNetosDeEfectivoToolStripMenuItem
            // 
            this.flujosNetosDeEfectivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinFinanciamientoToolStripMenuItem,
            this.conFinanciamientoToolStripMenuItem});
            this.flujosNetosDeEfectivoToolStripMenuItem.Name = "flujosNetosDeEfectivoToolStripMenuItem";
            this.flujosNetosDeEfectivoToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.flujosNetosDeEfectivoToolStripMenuItem.Text = "Flujos netos de efectivo";
            // 
            // sinFinanciamientoToolStripMenuItem
            // 
            this.sinFinanciamientoToolStripMenuItem.Name = "sinFinanciamientoToolStripMenuItem";
            this.sinFinanciamientoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.sinFinanciamientoToolStripMenuItem.Text = "Sin financiamiento";
            this.sinFinanciamientoToolStripMenuItem.Click += new System.EventHandler(this.sinFinanciamientoToolStripMenuItem_Click);
            // 
            // conFinanciamientoToolStripMenuItem
            // 
            this.conFinanciamientoToolStripMenuItem.Name = "conFinanciamientoToolStripMenuItem";
            this.conFinanciamientoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.conFinanciamientoToolStripMenuItem.Text = "Con financiamiento";
            this.conFinanciamientoToolStripMenuItem.Click += new System.EventHandler(this.conFinanciamientoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruccionesToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // instruccionesToolStripMenuItem
            // 
            this.instruccionesToolStripMenuItem.Name = "instruccionesToolStripMenuItem";
            this.instruccionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.instruccionesToolStripMenuItem.Text = "Instrucciones";
            this.instruccionesToolStripMenuItem.Click += new System.EventHandler(this.instruccionesToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anualidadesToolStripMenuItem1});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // anualidadesToolStripMenuItem1
            // 
            this.anualidadesToolStripMenuItem1.Name = "anualidadesToolStripMenuItem1";
            this.anualidadesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.anualidadesToolStripMenuItem1.Text = "Anualidades";
            this.anualidadesToolStripMenuItem1.Click += new System.EventHandler(this.anualidadesToolStripMenuItem1_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 486);
            this.Controls.Add(this.menuPrograma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMDI";
            this.Text = "Proyecto";
            this.Load += new System.EventHandler(this.FrmMDI_Load);
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
        private System.Windows.Forms.ToolStripMenuItem ordinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anticipadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diferidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perpetuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualidadesToolStripMenuItem1;
    }
}

