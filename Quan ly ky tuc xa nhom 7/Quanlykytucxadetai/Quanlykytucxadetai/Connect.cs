using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quanlykytucxadetai
{
    class Connect
    {
        SqlConnection conn;
        string connstring = "Data Source=DESKTOP-TTDQB8N;Initial Catalog=QuanLyKyTucXasql;Integrated Security=True";
        public SqlConnection connsql = new  SqlConnection(" Data Source=DESKTOP-TTDQB8N;Initial Catalog=QuanLyKyTucXasql;Integrated Security=True ");
        public DataTable Get(string sql)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void Action(string sql)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
