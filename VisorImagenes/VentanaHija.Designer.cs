namespace VisorImagenes
{
    partial class VentanaHija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaHija));
            this.menuImagen = new System.Windows.Forms.MenuStrip();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImagenAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.barraHerramientas = new System.Windows.Forms.ToolStrip();
            this.guardarBoton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajustarBoton = new System.Windows.Forms.ToolStripButton();
            this.grisesBoton = new System.Windows.Forms.ToolStripButton();
            this.girarBoton = new System.Windows.Forms.ToolStripButton();
            this.textoBoton = new System.Windows.Forms.ToolStripButton();
            this.menuImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.barraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuImagen
            // 
            this.menuImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem});
            this.menuImagen.Location = new System.Drawing.Point(0, 0);
            this.menuImagen.Name = "menuImagen";
            this.menuImagen.Size = new System.Drawing.Size(812, 24);
            this.menuImagen.TabIndex = 1;
            this.menuImagen.Text = "menuStrip1";
            this.menuImagen.Visible = false;
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImagenAjustar});
            this.imagenToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.imagenToolStripMenuItem.MergeIndex = 2;
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // menuImagenAjustar
            // 
            this.menuImagenAjustar.Name = "menuImagenAjustar";
            this.menuImagenAjustar.Size = new System.Drawing.Size(177, 22);
            this.menuImagenAjustar.Text = "Ajustar a la ventana";
            this.menuImagenAjustar.Click += new System.EventHandler(this.ajustarALaVentanaToolStripMenuItem_Click);
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.m_PictureBox.Location = new System.Drawing.Point(-2, -2);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(10, 50);
            this.m_PictureBox.TabIndex = 0;
            this.m_PictureBox.TabStop = false;
            // 
            // barraHerramientas
            // 
            this.barraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarBoton,
            this.toolStripSeparator1,
            this.ajustarBoton,
            this.grisesBoton,
            this.girarBoton,
            this.textoBoton});
            this.barraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.barraHerramientas.Name = "barraHerramientas";
            this.barraHerramientas.Size = new System.Drawing.Size(812, 25);
            this.barraHerramientas.TabIndex = 2;
            this.barraHerramientas.Text = "barraHerramientas";
            this.barraHerramientas.Visible = false;
            // 
            // guardarBoton
            // 
            this.guardarBoton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarBoton.Image = ((System.Drawing.Image)(resources.GetObject("guardarBoton.Image")));
            this.guardarBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarBoton.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarBoton.MergeIndex = 1;
            this.guardarBoton.Name = "guardarBoton";
            this.guardarBoton.Size = new System.Drawing.Size(23, 22);
            this.guardarBoton.Text = "Guardar";
            this.guardarBoton.Click += new System.EventHandler(this.guardarBoton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 2;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ajustarBoton
            // 
            this.ajustarBoton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajustarBoton.Image = ((System.Drawing.Image)(resources.GetObject("ajustarBoton.Image")));
            this.ajustarBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajustarBoton.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ajustarBoton.MergeIndex = 3;
            this.ajustarBoton.Name = "ajustarBoton";
            this.ajustarBoton.Size = new System.Drawing.Size(23, 22);
            this.ajustarBoton.Text = "Ajustar a ventana";
            this.ajustarBoton.Click += new System.EventHandler(this.ajustarBoton_Click);
            // 
            // grisesBoton
            // 
            this.grisesBoton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.grisesBoton.Image = ((System.Drawing.Image)(resources.GetObject("grisesBoton.Image")));
            this.grisesBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.grisesBoton.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.grisesBoton.MergeIndex = 4;
            this.grisesBoton.Name = "grisesBoton";
            this.grisesBoton.Size = new System.Drawing.Size(23, 22);
            this.grisesBoton.Text = "Escala de grises";
            this.grisesBoton.Click += new System.EventHandler(this.grisesBoton_Click);
            // 
            // girarBoton
            // 
            this.girarBoton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.girarBoton.Image = ((System.Drawing.Image)(resources.GetObject("girarBoton.Image")));
            this.girarBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.girarBoton.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.girarBoton.MergeIndex = 5;
            this.girarBoton.Name = "girarBoton";
            this.girarBoton.Size = new System.Drawing.Size(23, 22);
            this.girarBoton.Text = "Rotar 90°";
            this.girarBoton.Click += new System.EventHandler(this.girarBoton_Click);
            // 
            // textoBoton
            // 
            this.textoBoton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textoBoton.Image = ((System.Drawing.Image)(resources.GetObject("textoBoton.Image")));
            this.textoBoton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textoBoton.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.textoBoton.MergeIndex = 6;
            this.textoBoton.Name = "textoBoton";
            this.textoBoton.Size = new System.Drawing.Size(23, 22);
            this.textoBoton.Text = "Añadir texto";
            this.textoBoton.Click += new System.EventHandler(this.textoBoton_Click);
            // 
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 430);
            this.Controls.Add(this.barraHerramientas);
            this.Controls.Add(this.m_PictureBox);
            this.Controls.Add(this.menuImagen);
            this.MainMenuStrip = this.menuImagen;
            this.Name = "VentanaHija";
            this.Text = "VentanaHija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaHija_FormClosed);
            this.Resize += new System.EventHandler(this.VentanaHija_Resize);
            this.menuImagen.ResumeLayout(false);
            this.menuImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.barraHerramientas.ResumeLayout(false);
            this.barraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuImagen;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImagenAjustar;
        private System.Windows.Forms.PictureBox m_PictureBox;
        public  System.Windows.Forms.ToolStrip barraHerramientas;
        private System.Windows.Forms.ToolStripButton guardarBoton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ajustarBoton;
        private System.Windows.Forms.ToolStripButton grisesBoton;
        private System.Windows.Forms.ToolStripButton girarBoton;
        private System.Windows.Forms.ToolStripButton textoBoton;
    }
}