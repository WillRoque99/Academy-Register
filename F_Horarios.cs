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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"SELECT
                                N_idhorario as 'ID Horario',
                                T_dschorario as 'Horario'
                             FROM 
                                tb_horarios
                              ORDER BY
                                 T_dschorario
";
            Dgv_Horario.DataSource = Banco.DQL(vquery);
            Dgv_Horario.Columns[0].Width = 60;
            Dgv_Horario.Columns[0].Width = 150;
        }

      

        private void Bt_FecharHorario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void Dgv_Horario_SelectionChanged(object sender, EventArgs e)
        {
           /* DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
               DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"SELECT * FROM tb_horarios WHERE N_idhorario" + vid;

               dt = Banco.DQL(vquery);
               Tb_idhorario.Text = dt.Rows[0].Field<Int64>("N_idhorario").ToString();
               Mtb_DscHorario.Text = dt.Rows[0].Field<string>("T_dschorario");
            }*/
        }

        private void Btn_NovoHorario_Click(object sender, EventArgs e)
        {
            Tb_idhorario.Clear();
            Mtb_DscHorario.Clear();
            Mtb_DscHorario.Focus();
        }

        private void Btn_SalvarHorario_Click(object sender, EventArgs e)
        {
            string vquery = "INSERT INTO tb_horarios (T_dschorario) VALUES ('" + Mtb_DscHorario.Text + "');";
            Banco.DML(vquery);
           vquery = @"SELECT
                                N_idhorario as 'ID Horario',
                                T_dschorario as 'Horario'
                             FROM 
                                tb_horarios
                             ORDER BY
                                 T_dschorario
";
            Dgv_Horario.DataSource = Banco.DQL(vquery);
        }

        private void Btn_ExcluirHorario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclução?", "Exluir?", MessageBoxButtons.YesNo);
        }
    }
}
