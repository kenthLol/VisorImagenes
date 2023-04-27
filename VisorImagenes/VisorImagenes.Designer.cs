namespace VisorImagenes
{
    partial class VisorImagenes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventana = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotar90ºToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.Ventana,
            this.ayudaToolStripMenuItem,
            this.imagenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.Ventana;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // Ventana
            // 
            this.Ventana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem,
            this.mosaicoHorizontalToolStripMenuItem,
            this.mosaicoVerticalToolStripMenuItem});
            this.Ventana.Name = "Ventana";
            this.Ventana.Size = new System.Drawing.Size(61, 20);
            this.Ventana.Text = "Ventana";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // mosaicoHorizontalToolStripMenuItem
            // 
            this.mosaicoHorizontalToolStripMenuItem.Name = "mosaicoHorizontalToolStripMenuItem";
            this.mosaicoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mosaicoHorizontalToolStripMenuItem.Text = "Mosaico horizontal";
            this.mosaicoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.mosaicoHorizontalToolStripMenuItem_Click);
            // 
            // mosaicoVerticalToolStripMenuItem
            // 
            this.mosaicoVerticalToolStripMenuItem.Name = "mosaicoVerticalToolStripMenuItem";
            this.mosaicoVerticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mosaicoVerticalToolStripMenuItem.Text = "Mosaico Vertical";
            this.mosaicoVerticalToolStripMenuItem.Click += new System.EventHandler(this.mosaicoVerticalToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotar90ºToolStripMenuItem,
            this.escribirTextoToolStripMenuItem});
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // rotar90ºToolStripMenuItem
            // 
            this.rotar90ºToolStripMenuItem.Name = "rotar90ºToolStripMenuItem";
            this.rotar90ºToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotar90ºToolStripMenuItem.Text = "Rotar 90º";
            this.rotar90ºToolStripMenuItem.Click += new System.EventHandler(this.rotar90ºToolStripMenuItem_Click);
            // 
            // escribirTextoToolStripMenuItem
            // 
            this.escribirTextoToolStripMenuItem.Name = "escribirTextoToolStripMenuItem";
            this.escribirTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escribirTextoToolStripMenuItem.Text = "Escribir texto";
            this.escribirTextoToolStripMenuItem.Click += new System.EventHandler(this.escribirTextoToolStripMenuItem_Click);
            // 
            // VisorImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VisorImagenes";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ventana;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicoVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotar90ºToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirTextoToolStripMenuItem;
    }
}

