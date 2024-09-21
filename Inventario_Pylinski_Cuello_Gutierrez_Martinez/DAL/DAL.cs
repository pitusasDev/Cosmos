using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL
    {
        public SqlConnection conn = new SqlConnection("Server=DESKTOP-A6BV1GP;DataBase=Cosmos;User ID=oreo;Password=asd123");
        public SqlCommand cmd;
        public void Conectar()
        {
            try
            {
                if (!(conn.State == ConnectionState.Open))
                {
                    conn.Open();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Desconectar()
        {
            try
            {
                if (!(conn.State == ConnectionState.Closed))
                {
                    conn.Close();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Execute(string consulta)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(consulta, conn);
                cmd.ExecuteNonQuery();
                Desconectar();
                return true;

            } catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public DataSet DevolverDataset(string consulta)
        {
            DataSet ds = new DataSet();
            Conectar();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, conn);
            sqlDataAdapter.Fill(ds);
            Desconectar();
            return ds;
        }
    }
}
