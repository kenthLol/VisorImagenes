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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorImagenes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotar90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirTextoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirAEscalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventana = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraHerramientas = new System.Windows.Forms.ToolStrip();
            this.nuevoBoton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutBoton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.etiquetaEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.mostrarBarraDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarBarraDeEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.barraHerramientas.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.verToolStripMenuItem,
            this.Ventana,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.Ventana;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
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
            this.nuevoToolStripMenuItem.MouseEnter += new System.EventHandler(this.nuevoToolStripMenuItem_MouseEnter);
            this.nuevoToolStripMenuItem.MouseLeave += new System.EventHandler(this.nuevoToolStripMenuItem_MouseLeave);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            this.guardarToolStripMenuItem.MouseEnter += new System.EventHandler(this.guardarToolStripMenuItem_MouseEnter);
            this.guardarToolStripMenuItem.MouseLeave += new System.EventHandler(this.guardarToolStripMenuItem_MouseLeave);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            this.cerrarToolStripMenuItem.MouseEnter += new System.EventHandler(this.cerrarToolStripMenuItem_MouseEnter);
            this.cerrarToolStripMenuItem.MouseLeave += new System.EventHandler(this.cerrarToolStripMenuItem_MouseLeave);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            this.salirToolStripMenuItem.MouseEnter += new System.EventHandler(this.salirToolStripMenuItem_MouseEnter);
            this.salirToolStripMenuItem.MouseLeave += new System.EventHandler(this.salirToolStripMenuItem_MouseLeave);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotar90ToolStripMenuItem,
            this.escribirTextoToolStripMenuItem1,
            this.convertirAEscalaDeGrisesToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // rotar90ToolStripMenuItem
            // 
            this.rotar90ToolStripMenuItem.Name = "rotar90ToolStripMenuItem";
            this.rotar90ToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.rotar90ToolStripMenuItem.Text = "Rotar 90°";
            this.rotar90ToolStripMenuItem.Click += new System.EventHandler(this.rotar90ToolStripMenuItem_Click);
            this.rotar90ToolStripMenuItem.MouseEnter += new System.EventHandler(this.rotar90ToolStripMenuItem_MouseEnter);
            this.rotar90ToolStripMenuItem.MouseLeave += new System.EventHandler(this.rotar90ToolStripMenuItem_MouseLeave);
            // 
            // escribirTextoToolStripMenuItem1
            // 
            this.escribirTextoToolStripMenuItem1.Name = "escribirTextoToolStripMenuItem1";
            this.escribirTextoToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.escribirTextoToolStripMenuItem1.Text = "Escribir texto";
            this.escribirTextoToolStripMenuItem1.Click += new System.EventHandler(this.escribirTextoToolStripMenuItem1_Click);
            this.escribirTextoToolStripMenuItem1.MouseEnter += new System.EventHandler(this.escribirTextoToolStripMenuItem1_MouseEnter);
            this.escribirTextoToolStripMenuItem1.MouseLeave += new System.EventHandler(this.escribirTextoToolStripMenuItem1_MouseLeave);
            // 
            // convertirAEscalaDeGrisesToolStripMenuItem
            // 
            this.convertirAEscalaDeGrisesToolStripMenuItem.Name = "convertirAEscalaDeGrisesToolStripMenuItem";
            this.convertirAEscalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.convertirAEscalaDeGrisesToolStripMenuItem.Text = "Convertir a escala de grises";
            this.convertirAEscalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.convertirAEscalaDeGrisesToolStripMenuItem_Click);
            this.convertirAEscalaDeGrisesToolStripMenuItem.MouseEnter += new System.EventHandler(this.convertirAEscalaDeGrisesToolStripMenuItem_MouseEnter);
            this.convertirAEscalaDeGrisesToolStripMenuItem.MouseLeave += new System.EventHandler(this.convertirAEscalaDeGrisesToolStripMenuItem_MouseLeave);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarBarraDeHerramientasToolStripMenuItem,
            this.mostrarBarraDeEstadoToolStripMenuItem});
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
            this.cascadaToolStripMenuItem.MouseEnter += new System.EventHandler(this.cascadaToolStripMenuItem_MouseEnter);
            this.cascadaToolStripMenuItem.MouseLeave += new System.EventHandler(this.cascadaToolStripMenuItem_MouseLeave);
            // 
            // mosaicoHorizontalToolStripMenuItem
            // 
            this.mosaicoHorizontalToolStripMenuItem.Name = "mosaicoHorizontalToolStripMenuItem";
            this.mosaicoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mosaicoHorizontalToolStripMenuItem.Text = "Mosaico horizontal";
            this.mosaicoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.mosaicoHorizontalToolStripMenuItem_Click);
            this.mosaicoHorizontalToolStripMenuItem.MouseEnter += new System.EventHandler(this.mosaicoHorizontalToolStripMenuItem_MouseEnter);
            this.mosaicoHorizontalToolStripMenuItem.MouseLeave += new System.EventHandler(this.mosaicoHorizontalToolStripMenuItem_MouseLeave);
            // 
            // mosaicoVerticalToolStripMenuItem
            // 
            this.mosaicoVerticalToolStripMenuItem.Name = "mosaicoVerticalToolStripMenuItem";
            this.mosaicoVerticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mosaicoVerticalToolStripMenuItem.Text = "Mosaico Vertical";
            this.mosaicoVerticalToolStripMenuItem.Click += new System.EventHandler(this.mosaicoVerticalToolStripMenuItem_Click);
            this.mosaicoVerticalToolStripMenuItem.MouseEnter += new System.EventHandler(this.mosaicoVerticalToolStripMenuItem_MouseEnter);
            this.mosaicoVerticalToolStripMenuItem.MouseLeave += new System.EventHandler(this.mosaicoVerticalToolStripMenuItem_MouseLeave);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            this.ayudaToolStripMenuItem.MouseEnter += new System.EventHandler(this.ayudaToolStripMenuItem_MouseEnter);
            this.ayudaToolStripMenuItem.MouseLeave += new System.EventHandler(this.ayudaToolStripMenuItem_MouseLeave);
            // 
            // barraHerramientas
            // 
            this.barraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoBoton,
            this.toolStripSeparator1,
            this.aboutBoton});
            this.barraHerramientas.Location = new System.Drawing.Point(0, 24);
            this.barraHerramientas.Name = "barraHerramientas";
            this.barraHerramientas.Size = new System.Drawing.Size(1177, 25);
            this.barraHerramientas.TabIndex = 3;
            this.barraHerramientas.Text = "toolStrip1";
            // 
            // nuevoBoton
            // 
            this.nuevoBoton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoBoton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoBoton.Image")));
            this.nuevoBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoBoton.Name = "nuevoBoton";
            this.nuevoBoton.Size = new System.Drawing.Size(23, 22);
            this.nuevoBoton.Text = "Nuevo";
            this.nuevoBoton.Click += new System.EventHandler(this.nuevoBoton_Click);
            this.nuevoBoton.MouseEnter += new System.EventHandler(this.nuevoBoton_MouseEnter);
            this.nuevoBoton.MouseLeave += new System.EventHandler(this.nuevoBoton_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // aboutBoton
            // 
            this.aboutBoton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutBoton.Image = ((System.Drawing.Image)(resources.GetObject("aboutBoton.Image")));
            this.aboutBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutBoton.Name = "aboutBoton";
            this.aboutBoton.Size = new System.Drawing.Size(23, 22);
            this.aboutBoton.Text = "Acerca de";
            this.aboutBoton.Click += new System.EventHandler(this.aboutBoton_Click);
            this.aboutBoton.MouseEnter += new System.EventHandler(this.aboutBoton_MouseEnter);
            this.aboutBoton.MouseLeave += new System.EventHandler(this.aboutBoton_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetaEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1177, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(1162, 17);
            this.etiquetaEstado.Spring = true;
            this.etiquetaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mostrarBarraDeHerramientasToolStripMenuItem
            // 
            this.mostrarBarraDeHerramientasToolStripMenuItem.CheckOnClick = true;
            this.mostrarBarraDeHerramientasToolStripMenuItem.Name = "mostrarBarraDeHerramientasToolStripMenuItem";
            this.mostrarBarraDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.mostrarBarraDeHerramientasToolStripMenuItem.Text = "Mostrar barra de herramientas";
            this.mostrarBarraDeHerramientasToolStripMenuItem.Click += new System.EventHandler(this.mostrarBarraDeHerramientasToolStripMenuItem_Click);
            this.mostrarBarraDeHerramientasToolStripMenuItem.MouseEnter += new System.EventHandler(this.mostrarBarraDeHerramientasToolStripMenuItem_MouseEnter);
            this.mostrarBarraDeHerramientasToolStripMenuItem.MouseLeave += new System.EventHandler(this.mostrarBarraDeHerramientasToolStripMenuItem_MouseLeave);
            // 
            // mostrarBarraDeEstadoToolStripMenuItem
            // 
            this.mostrarBarraDeEstadoToolStripMenuItem.CheckOnClick = true;
            this.mostrarBarraDeEstadoToolStripMenuItem.Name = "mostrarBarraDeEstadoToolStripMenuItem";
            this.mostrarBarraDeEstadoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.mostrarBarraDeEstadoToolStripMenuItem.Text = "Mostrar barra de estado";
            this.mostrarBarraDeEstadoToolStripMenuItem.Click += new System.EventHandler(this.mostrarBarraDeEstadoToolStripMenuItem_Click);
            this.mostrarBarraDeEstadoToolStripMenuItem.MouseEnter += new System.EventHandler(this.mostrarBarraDeEstadoToolStripMenuItem_MouseEnter);
            this.mostrarBarraDeEstadoToolStripMenuItem.MouseLeave += new System.EventHandler(this.mostrarBarraDeEstadoToolStripMenuItem_MouseLeave);
            // 
            // VisorImagenes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.barraHerramientas);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VisorImagenes";
            this.Text = "Visor de Imágenes";
            this.Load += new System.EventHandler(this.VisorImagenes_Load);
            this.MdiChildActivate += new System.EventHandler(this.VisorImagenes_MdiChildActivate);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.VisorImagenes_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VisorImagenes_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.barraHerramientas.ResumeLayout(false);
            this.barraHerramientas.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barraHerramientas;
        private System.Windows.Forms.ToolStripButton nuevoBoton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton aboutBoton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaEstado;
        private System.Windows.Forms.ToolStripMenuItem rotar90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirTextoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem convertirAEscalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarBarraDeHerramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarBarraDeEstadoToolStripMenuItem;
    }
}

