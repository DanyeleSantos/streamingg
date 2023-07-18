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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string titulo = "O diario de ANNE FRANK ";
            string descricao = "Baseado em fatos reais, o filme retrata a história de Anne Frank, uma jovem judia que, durante a Segunda Guerra Mundial, se esconde com sua família em um sótão secreto em Amsterdã. Enquanto enfrentam o medo constante da descoberta pelos nazistas, Anne registra seus pensamentos e sentimentos em um diário como forma de esperança e preservação.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula05Streaming/Aula05Streaming/imagens/good.doctor.jpg";
            string link_videos = "https://www.youtube.com/embed/CPPqp66Zn28";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.camimho_imagem = caminho_imagem;
            telaInfo.link_videos = link_videos; 
            telaInfo.Show();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string titulo = "Good Doctor";
            string descricao = " Em The Good Doctor, um jovem cirurgião diagnosticado com savantismo, um distúrbio psíquico raro, é recrutado para trabalhar na ala pedriátrica de um hospital de prestígio. Apesar do seu incrível conhecimento na área da medicina, esse médico não consegue se relacionar com o mundo à sua volta.Resta saber se esta dificuldade será um problema na hora de salvar vidas";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula05Streaming/Aula05Streaming/imagens/good.doctor.jpg";
            string link_videos = "https://www.youtube.com/embed/lnY9FWUTY84";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.camimho_imagem = caminho_imagem;
            telaInfo.link_videos = link_videos;
            telaInfo.Show();

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
         private void pictureBox1_Click_1(object sender, EventArgs e)
         {

            string titulo = "O menino do pijama listrado";
            string descricao = "Durante a Segunda Guerra Mundial, a história se desenrola por meio da amizade improvável entre Bruno, um menino alemão de oito anos, e Shmuel, um garoto judeu de idade similar, que vive em um campo de concentração nazista. Separados por uma cerca, os dois estabelecem um vínculo fraterno ignorando as diferenças e o horror que os cerca.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula05Streaming/Aula05Streaming/imagens/menino.jpg";
            string link_videos = "https://www.youtube.com/embed/uZD-ySKl91A";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.camimho_imagem = caminho_imagem;
            telaInfo.link_videos = link_videos;

            telaInfo.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            string titulo = "LA CASA DE PAEL.";
            string descricao = "Um grupo de criminosos habilidosos e misteriosos liderados por um homem conhecido como O Professor realiza um plano ambicioso para assaltar a Casa da Moeda da Espanha. Enquanto imprimem dinheiro e lidam com reféns, eles enfrentam dilemas morais e emocionais que tornam o roubo muito mais complexo do que parecia ser.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula05Streaming/Aula05Streaming/imagens/LACASADEPAPEL.jpg";
            string link_videos = "https://www.youtube.com/embed/VaqMTLNhSvM";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.camimho_imagem = caminho_imagem;
            telaInfo.link_videos = link_videos;
            telaInfo.Show();


        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string titulo = "vis.a.vis";
            string descricao = "Macarena Ferreiro, uma jovem ingênua, é presa após cometer fraude financeira. Ela é enviada para uma prisão feminina onde enfrenta a dura realidade do sistema penitenciário, lidando com outros detentos, conflitos internos e buscando a sobrevivência em um ambiente hostil.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula05Streaming/Aula05Streaming/imagens/vis.a.vis.jpg";
            string link_videos = "https://www.youtube.com/embed/N08KRAPzsHU";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.camimho_imagem = caminho_imagem;
            telaInfo.link_videos = link_videos;
            telaInfo.Show();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

            string titulo = "Cidade de DEUS";
            string descricao = "No tumultuado bairro da Cidade de Deus, no Rio de Janeiro, a história se concentra em Buscapé, um jovem sensível e aspirante a fotógrafo que busca escapar da violência e das drogas que cercam sua comunidade. Enquanto a cidade se transforma em um campo de guerra entre gangues rivais, ele testemunha a ascensão do impiedoso Zé Pequeno, um criminoso ambicioso e temido. Buscapé narra a saga de personagens que lutam para sobreviver em meio ao caos, destacando suas esperanças, sonhos e desafios em um cenário brutal e impactante.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula05Streaming/Aula05Streaming/imagens/cidade.de.deus.jpg";
            string link_videos = "https://www.youtube.com/embed/fZJUKixyeXM";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.camimho_imagem = caminho_imagem;
            telaInfo.link_videos = link_videos;
            telaInfo.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

            string titulo = "Divertidamente";
            string descricao = "Acompanhe as emoções dentro da mente de Riley, uma jovem que enfrenta desafios após se mudar para uma nova cidade. A Alegria, a Tristeza, o Medo, a Raiva e o Nojo trabalham juntos para ajudá-la a lidar com suas emoções em uma jornada emocionante e hilariante.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula05Streaming/Aula05Streaming/imagens/divertidamente.jpg";
            string link_videos = "https://www.youtube.com/embed/LSpeM7G4zfY";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.camimho_imagem = caminho_imagem;
            telaInfo.link_videos = link_videos;
            telaInfo.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            string titulo = "Meu malvado favorito";
            string descricao = "Durante a Segunda Guerra Mundial, a história se desenrola por meio da amizade improvável entre Bruno, um menino alemão de oito anos, e Shmuel, um garoto judeu de idade similar, que vive em um campo de concentração nazista. Separados por uma cerca, os dois estabelecem um vínculo fraterno ignorando as diferenças e o horror que os cerca.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula05Streaming/Aula05Streaming/imagens/meu.malvado.favorito.jpg";
            string link_videos = "https://www.youtube.com/embed/462RosJNAMw";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.camimho_imagem = caminho_imagem;
            telaInfo.link_videos = link_videos;
            telaInfo.Show();
        }
    }
}
