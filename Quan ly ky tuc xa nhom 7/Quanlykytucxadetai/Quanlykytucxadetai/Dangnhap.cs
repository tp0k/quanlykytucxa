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
    public partial class Dangnhap : Form
    {
        Connect ac = new Connect();       
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ac.connsql.Open();
            string user = txtuser.Text.Trim();
            string pass = txtpass.Text.Trim();
            string sql = " select * from Taikhoan where Username ='" + user + "' and Pass = '" + pass + "' ";
            if (txtpass.Text == "" || txtuser.Text == "")
            {
                MessageBox.Show("bạn chưa nhập đủ thông tin", "Thông báo");
            }
            else 
            {
                try
                {               
                    if(ac.Get(sql).Rows.Count != 0)
                    {
                        Trangchu.quyen = ac.Get(" select ID from Taikhoan where Username ='" + user + "' and Pass = '" + pass + "' ").Rows[0][0].ToString().Trim();
                        this.Hide();
                        Form trangchu = new Trangchu();
                        trangchu.Show();  
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu");
                        txtuser.Text = "";
                        txtpass.Text = "";
                        txtuser.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Co loi nhap lieu", "thong bao");
                }
            }
            ac.connsql.Close();
        }

            private void button2_Click(object sender, EventArgs e)
            {
                Form dangky = new Dangky();
                dangky.Show();
                this.Hide();
            }

        private void gg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Frmmain gg = new Frmmain();
            gg.Show();
        }
    }
}
