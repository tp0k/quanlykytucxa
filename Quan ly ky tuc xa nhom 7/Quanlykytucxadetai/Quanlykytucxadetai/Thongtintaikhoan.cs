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
    public partial class Thongtintaikhoan : Form
    {       
        public Thongtintaikhoan()
        {
            InitializeComponent();
        }

        Connect ac = new Connect();

        private void Thongtintaikhoan_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void Laydulieudvg()
        {
            try
            {
                ac.connsql.Open();
                string sql = " select Hotennguoidung,Username,Sdt,Gioitinh,Pass from Taikhoan where Username = '" + txtUser.Text + "' and Pass = '" + txtPass.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(sql, ac.connsql);
                SqlCommand com = sqlCommand;
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();               
                da.Fill(dt);
                dgvlaydulieu.DataSource = dt;
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read() == false)
                {
                    MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu","Thông báo");
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }
                ac.connsql.Close();
            }
            catch
            {
                MessageBox.Show("sai", "thong bao");
            }
        }

        private void txtedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đày đủ thông tin cần thiết", "Thông báo");
                }
                else
                {
                    Laydulieudvg();
                }
            }
            catch
            {
                MessageBox.Show("co loi nhap lieu", "thongbao");
            }
        }

        private void txtlogout_Click(object sender, EventArgs e)
        {
            Form dangnhap = new Dangnhap();
            dangnhap.Show();
            this.Hide();
            
        }

        private void txtquayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void Thongtintaikhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }
    }
}
