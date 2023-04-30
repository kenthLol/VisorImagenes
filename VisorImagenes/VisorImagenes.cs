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
            this.ActualizarMenus();
        }

        public VentanaHija HijaActiva
        {
            get { return this.ActiveMdiChild as VentanaHija; }
        }

        public void ActualizarMenus()
        {
            // Deshabilitar el elemento del menú "Cerrar" si no hay ventana hija activa
            this.cerrarToolStripMenuItem.Enabled = (this.HijaActiva != null);
            this.guardarToolStripMenuItem.Enabled = (this.HijaActiva != null);
            this.escalaDeGrisesToolStripMenuItem.Enabled = (this.HijaActiva != null);
            this.escribirTextoToolStripMenuItem.Enabled = (this.HijaActiva != null);
            this.rotar90ºToolStripMenuItem.Enabled = (this.HijaActiva != null);

            // Deshabilitar los elementos del menú "Cascada" y "Mosaico" si no hay más de una ventana hija
            if (this.MdiChildren.Length > 1)
            {
                this.cascadaToolStripMenuItem.Enabled = true;
                this.mosaicoHorizontalToolStripMenuItem.Enabled = true;
                this.mosaicoVerticalToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.cascadaToolStripMenuItem.Enabled = false;
                this.mosaicoHorizontalToolStripMenuItem.Enabled = false;
                this.mosaicoVerticalToolStripMenuItem.Enabled = false;
            }
        }

        public void OnCloseHija()
        {
            //this.ActualizarMenus();
            this.DisableMenus();
        }

        private void DisableMenus()
        {
            this.cerrarToolStripMenuItem.Enabled =
            this.guardarToolStripMenuItem.Enabled =
            this.escalaDeGrisesToolStripMenuItem.Enabled =
            this.escribirTextoToolStripMenuItem.Enabled =
            this.rotar90ºToolStripMenuItem.Enabled = 
            this.cascadaToolStripMenuItem.Enabled =
            this.mosaicoHorizontalToolStripMenuItem.Enabled =
            this.mosaicoVerticalToolStripMenuItem.Enabled = false;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            ActualizarMenus();
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            ActualizarMenus();
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            ActualizarMenus();
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
            VentanaHija fh = new VentanaHija(título, this);
            fh.Text = título;
            fh.MdiParent = this;
            fh.PictureBox.Image = imagen;
            fh.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            fh.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HijaActiva.Close();
            ActualizarMenus();
        } 

        public void rotar90ºToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HijaActiva.Rotar90();
            ActualizarMenus();
        }

        public void escribirTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HijaActiva.Escribir();
            ActualizarMenus();
        }

        public void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HijaActiva.ConvertirEscalaDeGrises();
            ActualizarMenus();
        }

        public void guardarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void VisorImagenes_DragEnter(object sender, DragEventArgs e)
        {
            // Nos aseguramos de que lo que se está arrastrando son archivos 
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!file.ToUpper().EndsWith(".JPG") &&
                    !file.ToUpper().EndsWith(".JPEG") &&
                    !file.ToUpper().EndsWith(".PNG") &&
                    !file.ToUpper().EndsWith(".BMP") &&
                    !file.ToUpper().EndsWith(".GIF"))
                {
                    e.Effect = DragDropEffects.None; // Uno de los archivos no 
                                                     // es una imagen 
                    return;
                }
            }
            e.Effect = DragDropEffects.Copy; // Correcto, son todo imágenes 
        }

        private void VisorImagenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                AbrirArchivo(file);
            }
        }

        public void AbrirArchivo(string rutaArchivo)
        {
            string title = "Doc" + (this.MdiChildren.Length + 1);
            NuevaHija(title, System.Drawing.Image.FromFile(rutaArchivo));
        }

        private void VisorImagenes_MdiChildActivate(object sender, EventArgs e)
        {
            // ... 
            ToolStripManager.RevertMerge(this.barraHerramientas);
            VentanaHija ventanaHijaActiva = this.ActiveMdiChild as VentanaHija;
            if (ventanaHijaActiva != null)
            {
                ToolStripManager.Merge(ventanaHijaActiva.barraHerramientas, this.barraHerramientas);
            }
        }

        private void nuevoBoton_Click(object sender, EventArgs e)
        {
            nuevoToolStripMenuItem_Click(sender, e);
        }

        private void aboutBoton_Click(object sender, EventArgs e)
        {
            ayudaToolStripMenuItem_Click(sender, e);
        }

        private void nuevoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Abre un archivo de imagen";
        }

        private void nuevoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void guardarToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Guardar imagen";
        }

        private void guardarToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void cerrarToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Cerrar imagen";
        }

        private void cerrarToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void salirToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Cerrar el programa";
        }

        private void salirToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void rotar90ºToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Rotar la imagen a 90°";
        }

        private void rotar90ºToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void escribirTextoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Escribir texto Programacíón Visual en la parte superior de la imagen";
        }

        private void escribirTextoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void escalaDeGrisesToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Convierte a escala de grises la imagen";
        }

        private void escalaDeGrisesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void rotar90ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void escribirTextoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
