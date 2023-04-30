using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;

namespace VisorImagenes
{
    public partial class VentanaHija : Form
    {
        public VentanaHija(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
            this.Activated += VentanaHija_Activated;
            PictureBox = new PictureBox();
            PictureBox.Dock = DockStyle.Fill;
            Controls.Add(PictureBox);
        }

        private void VentanaHija_Activated(object sender, EventArgs e)
        {
            ((VisorImagenes)this.MdiParent).ActualizarMenus();
        }

        public PictureBox PictureBox
        {
            get { return m_PictureBox; }
            set { m_PictureBox = value; }
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

        public void ConvertirEscalaDeGrises()
        {
            PictureBox pictureBox = this.PictureBox;
            Image imagen = pictureBox.Image;
            using (Graphics gfx = Graphics.FromImage(imagen))
            {
                // Matriz para realizar una transformación al gris manteniendo los valores de luminancia correctos
                ColorMatrix cm = new ColorMatrix(new float[][]{
                    new float[]{0.3f,0.3f,0.3f,0,0},
                    new float[]{0.59f,0.59f,0.59f,0,0},
                    new float[]{0.11f,0.11f,0.11f,0,0},
                    new float[]{0,0,0,1,0},
                    new float[]{0,0,0,0,1}
                });

                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(cm);
                // Utilizar el método DrawImage de gfx para redibujar la imagen usando los atributos de imagen especificados por ia
                gfx.DrawImage(imagen, new Rectangle(0, 0, imagen.Width, imagen.Height),
                    0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, ia);
            }
            // Refrescar el picture box
            pictureBox.Refresh();

        }

        private void guardarBoton_Click(object sender, EventArgs e)
        {
            VisorImagenes miObjeto = new VisorImagenes();
            miObjeto.guardarToolStripMenuItem_Click(sender, e);
        }

        private void ajustarBoton_Click(object sender, EventArgs e)
        {
            ajustarALaVentanaToolStripMenuItem_Click(sender, e);
        }

        private void grisesBoton_Click(object sender, EventArgs e)
        {
            ConvertirEscalaDeGrises();
        }

        private void girarBoton_Click(object sender, EventArgs e)
        {
            Rotar90();
        }

        private void textoBoton_Click(object sender, EventArgs e)
        {
            Escribir();
        }
    }
}
