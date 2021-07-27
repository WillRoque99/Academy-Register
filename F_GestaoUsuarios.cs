using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_acabdemia
{
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterusuariosIDnome();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[1].Width = 190;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_novousuario f_Novousuario = new F_novousuario();
            f_Novousuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.ObterusuariosIDnome();
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {


                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.Obterdadosusuarios(vid);
                tb_id.Text = dt.Rows[0].Field<int>("N_idusuario").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_nomeusuario").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_username").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_senhausuario").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_statususuario").ToString();
                n_nivel.Value = dt.Rows[0].Field<int>("N_nivelusuario");
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.Id =Convert.ToInt32 (tb_id.Text);
            u.nome = tb_nome.Text;
            u.username = tb_username.Text;
            u.senha = tb_senha.Text;
            u.status = cb_status.Text;
            u.nivel = Convert.ToInt32( Math.Round (n_nivel.Value));
            Banco.Atualizarusuario(u);
            dgv_usuarios[0, linha].Value = tb_nome.Text;
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?","Excluir?", MessageBoxButtons.YesNo);
            if(res== DialogResult.Yes)
            {
                Banco.Deletarusuario(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
                    
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
