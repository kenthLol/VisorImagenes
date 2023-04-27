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
            this.menuImagen = new System.Windows.Forms.MenuStrip();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImagenAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.menuImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuImagen
            // 
            this.menuImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem});
            this.menuImagen.Location = new System.Drawing.Point(0, 0);
            this.menuImagen.Name = "menuImagen";
            this.menuImagen.Size = new System.Drawing.Size(800, 24);
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
            this.menuImagenAjustar.Size = new System.Drawing.Size(180, 22);
            this.menuImagenAjustar.Text = "Ajustar a la ventana";
            this.menuImagenAjustar.Click += new System.EventHandler(this.ajustarALaVentanaToolStripMenuItem_Click);
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(266, 142);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(100, 50);
            this.m_PictureBox.TabIndex = 0;
            this.m_PictureBox.TabStop = false;
            // 
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_PictureBox);
            this.Controls.Add(this.menuImagen);
            this.MainMenuStrip = this.menuImagen;
            this.Name = "VentanaHija";
            this.Text = "VentanaHija";
            this.Resize += new System.EventHandler(this.VentanaHija_Resize);
            this.menuImagen.ResumeLayout(false);
            this.menuImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.MenuStrip menuImagen;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImagenAjustar;
    }
}