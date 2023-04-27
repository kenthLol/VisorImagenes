using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            get { return (VentanaHija)this.ActiveMdiChild; }
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
            string título = "Doc" + (this.MdiChildren.Length + 1);
            NuevaHija(título);
        }

        private void NuevaHija(string título)
        {
            VentanaHija hija = new VentanaHija(título);
            hija.MdiParent = this;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();
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
    }
}
