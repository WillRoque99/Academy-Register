using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace CFB_acabdemia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeusuario.Text = "---";
            pp_ledlogado.Image = Properties.Resources.botaovermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)//verifica se esta logado e qual nivel de acesso é permitido.
            {
                if(Globais.nivel>=3)
                {

                }
                else
                {
                    MessageBox.Show("acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("é nessessario ter um usuario logado");
            }
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_novousuario f_Novousuario = new F_novousuario();
                    f_Novousuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("é nessessario ter um usuario logado");
            }
        }

        private void gestaoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
                    f_GestaoUsuarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("é nessessario ter um usuario logado");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
               
            }
            else
            {
                MessageBox.Show("é nessessario ter um usuario logado");
            }
        }
    }
}
