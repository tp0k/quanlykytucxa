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
    public partial class Timkiemcs : Form
    {
        Connect ac = new Connect();
        public Timkiemcs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Timkiemcs_Load(object sender, EventArgs e)
        {
            laydulieusinhvien();
            laydulieutenlop();
            laydulieuPhong();
            laydulieuloaiphong();
        }

        private void laydulieuPhong()
        {
            dgvtimkiem2.DataSource = ac.Get("select * from timkiemphong");
        }

        private void laydulieuloaiphong()
        {
            ac.connsql.Open();
            string sql = " select Maloaiphong from Loaiphong ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            cboloaiphong.DataSource = dt;
            cboloaiphong.DisplayMember = "Maloaiphong";
            cboloaiphong.ValueMember = "Maloaiphong";
        }

        private void laydulieusinhvien()
        {
            dgvtimkiem1.DataSource = ac.Get("select * from timkiemsv");
        }

        private void laydulieutenlop()
        {
            ac.connsql.Open();
            string sql = " select Tenlop from Lop ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ac.connsql.Close();
            cbomalop.DataSource = dt;
            cbomalop.DisplayMember = "Tenlop";
            cbomalop.ValueMember = "Tenlop";
        }

        private void btnquayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void btntk1_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text == "" || cbomalop.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (kiemtramasv(int.Parse(txtmasv.Text)) == false)
                    MessageBox.Show("Mã sinh viên cần tìm không tồn tại", "Thông báo");
                {
                    try
                    {
                        ac.connsql.Open();
                        string sql = " select Masv,Tensv,Gioitinh,Sdt,Quequan,Tenlop,Tenkhoa,Sinhvien.Maphong from Sinhvien,Khoa,Lop where Sinhvien.Malop = Lop.Malop and Khoa.Makhoa = Lop.Makhoa and Masv = '" + txtmasv.Text + "' and Tenlop = N'" + cbomalop.SelectedValue + "' ";
                        SqlCommand com = new SqlCommand(sql, ac.connsql);
                        com.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(com);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ac.connsql.Close();
                        dgvtimkiem1.DataSource = dt;
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private void btnbotim1_Click(object sender, EventArgs e)
        {
            ac.connsql.Open();
            string sql = " select * from timkiemsv ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ac.connsql.Close();
            dgvtimkiem1.DataSource = dt;
            cbomalop.Text = "";
            txtmasv.Text = "";
            txtmasv.Focus();
        }

        private bool kiemtramasv(int masv)
        {
            bool ktra = false;
            ac.connsql.Open();
            string sql = "select * from Sinhvien where Masv ='" + masv + "' ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            if (dt.Rows.Count == 0)
                ktra = false;
            else
                ktra = true;
            return ktra;
        }

        private void dgvtimkiem1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = e.RowIndex;
            if (a > -1)
            {
                txtmasv.Text = dgvtimkiem1.Rows[a].Cells[0].Value.ToString();
                cbomalop.Text = dgvtimkiem1.Rows[a].Cells[5].Value.ToString();
            }
        }

        private void dgvtimkiem2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = e.RowIndex;
            if (a > -1)
            {
                txtmaphong.Text = dgvtimkiem2.Rows[a].Cells[0].Value.ToString();
                cboloaiphong.Text = dgvtimkiem2.Rows[a].Cells[4].Value.ToString();
            }
        }

        private void btnbotim2_Click(object sender, EventArgs e)
        {
            ac.connsql.Open();
            string sql = " select * from timkiemphong ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ac.connsql.Close();
            dgvtimkiem2.DataSource = dt;
            txtmaphong.Text = "";
            cboloaiphong.Text = "";
            txtmaphong.Focus();
        }

        private bool ktramaphong(string maphong)
        {
            ac.connsql.Open();
            string sql = $" select * from Phong where Phong.Maphong = '{maphong}' ";
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

        private void btntk2_Click(object sender, EventArgs e)
        {
            if (txtmaphong.Text == "" || cboloaiphong.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramaphong(txtmaphong.Text) == true)
                    MessageBox.Show("Mã phòng cần tìm không tồn tại", "Thông báo");
                {
                    try
                    {
                        ac.connsql.Open();
                        string sql = " select Phong.Maphong,Sodien,Sonuoc,Songuoi,Loaiphong.Maloaiphong,Tenloaiphong,Giatien,Tienphong = Sodien*3500 + Sonuoc*20000 + Giatien from Phong,Hoadon,Loaiphong where Phong.Maphong = Hoadon.Maphong and Phong.Maloaiphong = Loaiphong.Maloaiphong and Phong.Maphong = N'" + txtmaphong.Text + "' and Loaiphong.Maloaiphong = N'" + cboloaiphong.SelectedValue + "' ";
                        SqlCommand com = new SqlCommand(sql, ac.connsql);
                        com.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(com);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ac.connsql.Close();
                        dgvtimkiem2.DataSource = dt;
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private void Timkiemcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }
    }
}
