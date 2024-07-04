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
    public partial class Dangky : Form
    {
        Connect ac = new Connect();
        public Dangky()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dangky_Load(object sender, EventArgs e)
        {
            radnam.Checked = true;
            radnu.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "" || txtsdt.Text == "" || txtcpass.Text == "")
            {
                MessageBox.Show("bạn chưa nhập đủ thông tin", "thông báo");
            }
            else if(ktrauser(txtuser.Text) == false)
            {
                MessageBox.Show("Tên Uẻ đã tồn tại!", "Thông báo");
            }
            else if(txtpass.Text != txtcpass.Text)
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận phải giống nhau", "Thông báo");
                txtcpass.Focus();
                txtcpass.SelectAll();

            }
            else
            {
                try
                {                   
                    string gt;
                    if (radnam.Checked == true)
                        gt = "Nam";
                    else
                        gt = "Nữ";
                    ac.Action(" insert into Taikhoan values ( N'" + txtuser.Text + "', N'" + txtten.Text + "', '" + txtsdt.Text + "', N'" + gt + "', N'" + txtpass.Text + "', N'" + txtcpass.Text + "') ");
                    MessageBox.Show("Đăng ký thành công", "Thông báo");
                    Form trangchu = new Trangchu();
                    trangchu.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("co loi nhap lieu", "thong bao");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ktrauser(string user)
        {
            ac.connsql.Open();
            string sql = $" select * from Taikhoan where Username = '{user}' ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            if (dt.Rows.Count == 0)
                return true; //chua ton tai
            else
                return false; //da ton tai
        }

        private void Dangky_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Frmmain gg = new Frmmain();
            gg.Show();
        }
    }
}
