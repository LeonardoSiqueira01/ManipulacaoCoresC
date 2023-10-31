using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMdiPai
{
    public partial class Form1 : Form
    {

        Color cor = Color.White;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void mDIFilhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMdiFilho frm = new FrmMdiFilho(this);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHr.Text = DateTime.Now.ToString("HH:mm:ss ");
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            retangulo.BackColor = Color.FromArgb(221,222,144);
          
        }

        private void exibir() {
            retangulo.BackColor = cor;
            cor = Color.FromArgb(trackBar1.Value,trackBar2.Value,trackBar3.Value);
            label2.Text = trackBar1.Value + ", "+trackBar2.Value + ", " + trackBar3.Value;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblRValor.Text = trackBar1.Value.ToString();
            exibir();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblGValor.Text = trackBar2.Value.ToString();
            exibir();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            lblBValor.Text = trackBar3.Value.ToString();
            exibir();
        }

    }
}
