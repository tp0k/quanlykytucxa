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
    public partial class Trangchu : Form
    {
        Connect cn = new Connect();
        public static string quyen;
        public Trangchu()
        {
            InitializeComponent();
        }

        private void txtttuser_Click(object sender, EventArgs e)
        {
            Form taikhoan = new Thongtintaikhoan();
            taikhoan.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtsv_Click(object sender, EventArgs e)
        {
            Form sinhvien = new Sinhvien();
            sinhvien.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form lop = new Lop();
            lop.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form khoa = new Khoa();
            khoa.Show();
            this.Hide();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            Form tk = new Timkiemcs();
            tk.Show();
            this.Hide();
        }

        private void btnphong_Click(object sender, EventArgs e)
        {
            Form ac = new Phong();
            ac.Show();
            this.Hide();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            Form ac = new Hoadon();
            ac.Show();
            this.Hide();
        }

        private void btnloaiphong_Click(object sender, EventArgs e)
        {
            Form ac = new Loaiphong();
            ac.Show();
           
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Form tk = new Thongtintaikhoan();
            tk.Show();
            this.Hide();
            
        }

        private void quảnLýUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form us = new Sinhvien();
            us.Show();
           
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form us = new Lop();
            us.Show();
            this.Hide();
            
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form us = new Khoa();
            us.Show();
            this.Hide();
          
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form us = new Phong();
            us.Show();
            this.Hide();
            
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form us = new Loaiphong();
            us.Show();
            this.Hide();
            
        }

        private void hóaĐơnĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form us = new Hoadon();
            us.Show();
            this.Hide();
            
        }

        private void phiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form us = new Phieuthu();
            us.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form us = new Dangnhap();
            us.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sinhViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form us = new Sinhvien();
            us.Show();
            this.Hide();
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form us = new Dangnhap();
            us.Show();
            this.Hide();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {           
            
        }

        private void tìmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form us = new Timkiemcs();
            us.Show();
            this.Hide();

        }

        private void quanLyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "1")
            {
                MessageBox.Show("Bạn có quyền sử sụng chức năng này", "Admin");
                Quanlyuser gg = new Quanlyuser();
                gg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Bạn cần đăng nhập tài khoản Admin để thực hiện chức năng này ! ","Thông báo");
            }
        }

        private void Trangchu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýSịnhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
