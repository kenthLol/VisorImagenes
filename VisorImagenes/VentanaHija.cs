using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisorImagenes
{
    public partial class VentanaHija : Form
    {
        public VentanaHija(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
            this.PictureBox.Image = Resource1.Logo_UNAN_León;
        }

        public PictureBox PictureBox
        {
            get { return m_PictureBox; }
        }

        private void ajustarALaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si no estamos en modo ajustar, activamos este modo 
            if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.AutoSize)
            {
                this.AutoScroll = false;
                this.PictureBox.Size = this.ClientSize;
                this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            // Si estamos en modo ajustar, desactivamos este modo 
            else if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.Zoom)
            {
                this.AutoScroll = true;
                this.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            menuImagenAjustar.Checked = this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom;
        }

        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
                this.PictureBox.Size = this.ClientSize;
        }

        public void Rotar90()
        {
            int width = this.PictureBox.Image.Width;
            int height = this.PictureBox.Image.Height;

            this.PictureBox.Size = new Size(width * 2, height * 2);
            this.PictureBox.Refresh();
            this.PictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.PictureBox.Refresh();
        }

        public void Escribir()
        {
            using (Graphics gfx = Graphics.FromImage(this.PictureBox.Image))
            {
                // Utilizar el método DrawString de gfx para pintar el texto
                // "Programación Visual" en la posición 0,0 del área de
                // cliente, utilizando una fuente Arial de 20 ptos
                // y una brocha blanca
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gfx.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                gfx.CompositingQuality = CompositingQuality.HighQuality;
                gfx.CompositingMode = CompositingMode.SourceOver;

                gfx.PageUnit = GraphicsUnit.Point;
                gfx.PageScale = 1.0f;

                Font font = new Font("Arial", 20);
                Brush brush = Brushes.White;
                gfx.DrawString("Programación Visual", font, brush, new PointF(0, 0));
            }
            // Refrescar el picture box 
            this.PictureBox.Refresh();
        }
    }
}
