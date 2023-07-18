using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05Streaming
{
    public partial class Form2 : Form
    {

        public string titulo;
        public string descricao;
        public string camimho_imagem;
        public string link_videos;

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        

       

     private void llblDescrição_Click(object sender, EventArgs e)
     {

     }

        private void btnAssistit_Click(object sender, EventArgs e)
        {
            webView21.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
            llblDescrição.Text = descricao;
            imgfundo.ImageLocation = camimho_imagem;
            webView21.Source = new Uri(link_videos);
        }
    }
}
