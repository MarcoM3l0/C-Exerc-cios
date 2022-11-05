using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FrmPrincipal : Form
    {
        // Variáveis globais 
        float nota1, nota2, nota3, nota4, media;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dtData.Text = DateTime.Today.ToString();
            dtTime.Text = DateTime.Now.ToString();
            lblNome.Text = Program.usuario;
        }

        public void resultado()
        {
            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);
            nota4 = float.Parse(txtNota4.Text);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            lblMedia.Text = media.ToString();
        }

        public void mediaAluno()
        {
            if (media < 6)
            {
                lblStatus.Text = "Recuperação";
                lblStatus.ForeColor = Color.Red;
                lblMedia.ForeColor = Color.Red;
                lblNome.ForeColor = Color.Red;
            }
            else if (media <= 7)
            {
                lblStatus.Text = "Aprovado na média";
                lblStatus.ForeColor = Color.FromArgb(192, 64, 0);
                lblMedia.ForeColor = Color.FromArgb(192, 64, 0);
                lblNome.ForeColor = Color.FromArgb(192, 64, 0);
            }
            else
            {
                lblStatus.Text = "Aprovado a cima da média.";
                lblStatus.ForeColor = Color.Green;
                lblMedia.ForeColor = Color.Green;
                lblNome.ForeColor = Color.Green;
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            resultado();
            mediaAluno();
        }
    }
}
