using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace VisorImagenes
{
    public partial class VisorImagenes : Form
    {
        public VisorImagenes()
        {
            InitializeComponent();
        }

        public VentanaHija HijaActiva
        {
            get { return this.ActiveMdiChild as VentanaHija; }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string title = "Doc" + (this.MdiChildren.Length + 1);
                NuevaHija(title, System.Drawing.Image.FromFile(openFileDialog.FileName));
            }
        }

        private void NuevaHija(string título, System.Drawing.Image imagen = null)
        {
            VentanaHija fh = new VentanaHija(título);
            fh.Text = título;
            fh.MdiParent = this;
            fh.PictureBox.Image = imagen;
            fh.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            fh.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HijaActiva.Close();
        }

        private void rotar90ºToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HijaActiva.Rotar90();
        }

        private void escribirTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HijaActiva.Escribir();
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HijaActiva.ConvertirEscalaDeGrises();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Imagen JPEG|*.jpg|Imagen PNG|*.png|Imagen BMP|*.bmp|Todos los archivos|*.*";
            saveFileDialog.Title = "Guardar imagen como...";
            saveFileDialog.FileName = "Sin título";

            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                string fileName = saveFileDialog.FileName;
                string fileExtension = Path.GetExtension(fileName).ToLower();

                // Guardar la imagen con el encoding apropiado.
                ImageFormat imageFormat;
                switch (fileExtension)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                    case ".bmp":
                        imageFormat = ImageFormat.Bmp;
                        break;
                    default:
                        imageFormat = ImageFormat.Jpeg;
                        break;
                }

                this.HijaActiva.PictureBox.Image.Save(fileName, imageFormat);
            }
        }

        private void VisorImagenes_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
