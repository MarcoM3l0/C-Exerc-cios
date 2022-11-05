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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("DIGITE UM NOME!");
                return;
            }

            if (txtSenha.Text != "123456")
            {
                MessageBox.Show("DIGITE A SENHA!");
                return; 
            }

            Program.usuario = txtNome.Text;

            FrmPrincipal frm = new FrmPrincipal();
            frm.ShowDialog();

            this.Close();
            
        }
    }
}
