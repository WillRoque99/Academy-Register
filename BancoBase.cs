using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CFB_acabdemia
{
    internal class BancoBase
    {
        public static DataTable Consulta(string sql)
        {
            SqlDataAdapter Da = null;
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = Banco.Conexaobanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    Da = new SqlDataAdapter(cmd.CommandText, Banco.Conexaobanco());
                    Da.Fill(dt);
                    Banco.Conexaobanco().Close();
                    return dt;


                }

            }
            catch (Exception)
            {
                Banco.Conexaobanco().Close();

            }
            return dt;
        }
    }
}