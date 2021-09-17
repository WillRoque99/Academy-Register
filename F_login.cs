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

namespace CFB_acabdemia
{
    public partial class F_login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void tnb_logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            if (username== "" || senha == "")
            {
                MessageBox.Show("Username ou Senha invalidos");
                tb_username.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_username='" +username+ "' AND T_senhausuario='" +senha+"'";
            dt = Banco.DQL(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeusuario.Text = dt.Rows[0].Field<string>("T_nomeusuario");
                form1.pp_ledlogado.Image = Properties.Resources.botaoverde; //troca da luz vermelha para a verde
                //Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("T_nivelusuario").ToString());
                Globais.nivel =int.Parse( dt.Rows[0].ItemArray[5].ToString());
                Globais.logado = true;
                this.Close();
                

            }
            else
            {

                MessageBox.Show("messagem não encontrada");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
