using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlykytucxadetai
{
    public partial class Phieuthu : Form
    {
        Connect ac = new Connect();
        public Phieuthu()
        {
            InitializeComponent();
        }

        private void Phieuthu_Load(object sender, EventArgs e)
        {
            laydulieutenhoadon();           
        }

        private void laydulieutenhoadon()
        {
            ac.connsql.Open();
            string sql = "select Mahd from Hoadon ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            cbomahd.DataSource = dt;
            cbomahd.DisplayMember = "Mahd";
            cbomahd.ValueMember = "Mahd";
        }

        private void btnquayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void btntaophieu_Click(object sender, EventArgs e)
        {
            try
            {
                ac.connsql.Open();
                string sql = " Select * from Phieuthu where Mahd = '"+cbomahd.SelectedValue+"' ";
                SqlCommand com = new SqlCommand(sql, ac.connsql);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                ac.connsql.Close();
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("co loi nhap lieu", "thong bao");
            }
        }

        private void btnxoaphieu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbophieu_Click(object sender, EventArgs e)
        {
            cbomahd.Text = "";
            try
            {
                ac.connsql.Open();
                string sql = " Select * from Phieuthu where '" + cbomahd.SelectedValue + "' = null ";
                SqlCommand com = new SqlCommand(sql, ac.connsql);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                ac.connsql.Close();
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("co loi nhap lieu", "thong bao");
            }
            cbomahd.Text = "";
        }

        private void Phieuthu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyKyTucXasqlDataSet1.Phieuthu' table. You can move, or remove it, as needed.
            this.PhieuthuTableAdapter.Fill(this.QuanLyKyTucXasqlDataSet1.Phieuthu, cbomahd.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
