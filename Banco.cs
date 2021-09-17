using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CFB_acabdemia
{
    class Banco
    {
        public static SqlConnection conexao;



        public static SqlConnection Conexaobanco()
        {
            conexao = new SqlConnection("Data Source=BORSA-GAMES;Initial Catalog=banco;Integrated Security=True");
            conexao.Open();
            return conexao;
        }

        public static DataTable DQL(string sql)
        {
            SqlDataAdapter Da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Conexaobanco();

                var cmd = vcon.CreateCommand();

                cmd.CommandText = sql;
                Da = new SqlDataAdapter(cmd.CommandText, vcon);
                Da.Fill(dt);
                vcon.Close();
                return dt;




            }
            catch (Exception ex)
            {

                throw ex;

            }

        }
        public static void DML(string q,string msgOK=null,string msgERRO=null)
        {
            SqlDataAdapter Da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Conexaobanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = q;
                Da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
               




            }
            catch (Exception ex)
            {
                if(msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);

                }
                throw ex;
            }

        }
        

        public static DataTable Obtertodosusuarios()
        {
            SqlDataAdapter Da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Conexaobanco();
                var cmd = vcon.CreateCommand();
                
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    Da = new SqlDataAdapter(cmd.CommandText, vcon);
                    Da.Fill(dt);
                    vcon.Close();
                    return dt;


                

            } catch (Exception ex)
            {
                
                throw ex;
            }

        }

        internal static object ObterHorario()
        {
            throw new NotImplementedException();
        }

       
        //___funções do formulario

        private const string SQL = "INSERT INTO tb_usuarios (T_nomeusuario,T_username,T_senhausuario, T_statususuario,N_nivelusuario) VALUES (@nome,@username,@senha,@status,@nivel)";
        public static void NovoUsuario(Usuario u)
        {
            if (existeUsarname(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }

            try
            {
                var vcon = Conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("novo usuario Inserido");
                vcon.Close();


            }
            catch (Exception e)
            {
               MessageBox.Show("Erro ao gravar novo usuario" + e.Message
                   );
               
            }
           
        }

        public static DataTable ObterusuariosIDnome()
        {
            SqlDataAdapter Da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Conexaobanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT N_idusuario as 'ID Usuario',T_nomeusuario as 'Nome usuario' FROM tb_usuarios";
                Da = new SqlDataAdapter(cmd.CommandText, vcon);
                Da.Fill(dt);
                vcon.Close();
                return dt;




            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public static DataTable Obterdadosusuarios(string id)
        {
            SqlDataAdapter Da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Conexaobanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_usuarios where N_idusuario=" + id;
                Da = new SqlDataAdapter(cmd.CommandText, vcon);
                Da.Fill(dt);
                vcon.Close();
                return dt;




            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static void Atualizarusuario(Usuario u)
        {
            SqlDataAdapter Da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Conexaobanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "UPDATE tb_usuarios SET T_nomeusuario='"+ u.nome +"',T_username='"+ u.username +"',T_senhausuario='"+ u.senha +"',T_statususuario='"+ u.status +"',N_nivelusuario="+ u.nivel +" where N_idusuario="+ u.Id;
                Da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
               




            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static void Deletarusuario(string Id)
        {
            SqlDataAdapter Da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Conexaobanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "DELETE FROM tb_usuarios where N_idusuario=" + Id;
                Da = new SqlDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception e)
            {

                throw e;
            }

        }

        //___fim da função

        public static bool existeUsarname(Usuario u)
        {
            bool res;
            SqlDataAdapter Da = null;
            DataTable dt = new DataTable();

            var vcon = Conexaobanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_username FROM tb_usuarios WHERE T_username='"+u.username+"'";
            Da = new SqlDataAdapter(cmd.CommandText,vcon);
            Da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            vcon.Close();
            return res;
        }


    }
}
