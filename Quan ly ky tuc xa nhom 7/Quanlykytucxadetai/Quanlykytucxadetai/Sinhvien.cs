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
    public partial class Sinhvien : Form
    {
        Connect ac = new Connect();
        public Sinhvien()
        {
            InitializeComponent();
        }

        private void Sinhvien_Load(object sender, EventArgs e)
        {
            laydulieubangsv();
            radnam.Checked = true;
            radnu.Checked = false;
            laydulieumalop();
            laydulieumaphong();
            txtmasv.Focus();
        }

        private void laydulieubangsv()
        {
            dgvbangsv.DataSource = ac.Get("select * from Sinhvien");
        }

        private void laydulieumalop()
        {
            ac.connsql.Open();
            string sql = "select Malop from Lop ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            cbomalop.DataSource = dt;
            cbomalop.DisplayMember = "Malop";
            cbomalop.ValueMember = "Malop";
        }

        private void laydulieumaphong()
        {
            ac.connsql.Open();
            string sql = "select Maphong from Phong ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            cbomaphong.DataSource = dt;
            cbomaphong.DisplayMember = "Maphong";
            cbomaphong.ValueMember = "Maphong";
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text == "" || txttensv.Text == "" || txtsodt.Text == "" || txtquequan.Text == "" || cbomalop.Text == "" || cbomaphong.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                try
                {
                    if (kiemtramasv(int.Parse(txtmasv.Text)) == true)
                    {
                        MessageBox.Show("MÃ Sinh viên đã tồn tại", "Thông báo");
                    }
                    else
                    {
                        ac.connsql.Open();
                        string sql = $"select Songuoi, GioiHan from Phong where Maphong = '{cbomaphong.SelectedValue}'";
                        SqlCommand com = new SqlCommand(sql, ac.connsql);
                        com.CommandType = CommandType.Text;
                        SqlDataReader dr = com.ExecuteReader();
                        int soNguoi = -1;
                        int gioiHan = -1;
                        while (dr.Read())
                        {
                            soNguoi = int.Parse(dr.GetValue(0).ToString());
                            gioiHan = int.Parse(dr.GetValue(1).ToString());
                        }
                        if (soNguoi == gioiHan)
                            MessageBox.Show("Phòng này đã đạt tối đa Sinh viên !", "Notification");
                        else
                        {
                            string gt;
                            if (radnam.Checked == true)
                                gt = "Nam";
                            else
                                gt = "Nữ";
                            ac.Action(" insert into Sinhvien values ( '" + txtmasv.Text + "', N'" + txttensv.Text + "','" + txtsodt.Text + "','" + datetimepicker.Value + "', N'" + gt + "', N'" + txtquequan.Text + "', N'" + cbomalop.SelectedValue + "', N'" + cbomaphong.SelectedValue + "' ) ");
                            laydulieubangsv();
                        }
                        ac.connsql.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã sinh viên là số", "Bạn nhập sai kiểu dữ liệu");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text == "")
                MessageBox.Show("Bạn cần nhập mã sinh viên cần xóa", "Thông báo");
            else
            {
                if (kiemtramasv(int.Parse(txtmasv.Text)) == false)
                {
                    MessageBox.Show("Không tồn tại mã sinh viên này", "Thông báo");
                }
                else
                {
                    try
                    {
                        ac.Action("delete from Sinhvien where Masv = '" + txtmasv.Text + "' ");
                    }
                    catch
                    {
                        MessageBox.Show("Co loi nhap lieu", "Thong bao");
                    }
                    laydulieubangsv();
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmasv.Clear();
            txttensv.Clear();
            txtsodt.Clear();
            radnam.Checked = true;
            radnu.Checked = false;
            txtquequan.Clear();
            txtmasv.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text == "" || txttensv.Text == "" || txtsodt.Text == "" || txtquequan.Text == "" || cbomalop.Text == "" || cbomaphong.Text == "")
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin  sinh viên muốn sửa", "Thông báo");
            else
            {
                if (kiemtramasv(int.Parse(txtmasv.Text)) == false)
                {
                    MessageBox.Show("Không tồn tại mã sinh viên này", "Thông báo");
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
                        ac.Action("update Sinhvien Set Tensv = N'" + txttensv.Text + "',Sdt = '" + txtsodt.Text + "',Ngaysinh = '" + datetimepicker.Value + "',Gioitinh = N'" + gt + "',Quequan = N'" + txtquequan.Text + "',Malop = N'" + cbomalop.SelectedValue + "', Maphong = N'"+cbomaphong.Text+"' where Masv = '"+txtmasv.Text+"' ");                       
                        laydulieubangsv();
                    }
                    catch
                    {
                        MessageBox.Show("Co loi nhap lieu", "Thong bao");
                    }
                    laydulieubangsv();
                }
            }
        }

        private void dgvbangsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if(numrow >-1)
            {
                txtmasv.Text = dgvbangsv.Rows[numrow].Cells[0].Value.ToString();
                txttensv.Text = dgvbangsv.Rows[numrow].Cells[1].Value.ToString();
                txtsodt.Text = dgvbangsv.Rows[numrow].Cells[2].Value.ToString();
                datetimepicker.Text = dgvbangsv.Rows[numrow].Cells[3].Value.ToString();
                string gt = this.dgvbangsv.Rows[numrow].Cells[4].Value.ToString();
                if (gt.Trim() == "Nam")
                {
                    radnam.Checked = true;
                }
                else
                {
                    radnu.Checked = true;
                }
                txtquequan.Text = dgvbangsv.Rows[numrow].Cells[5].Value.ToString();
                cbomalop.Text = dgvbangsv.Rows[numrow].Cells[6].Value.ToString();
                cbomaphong.Text = dgvbangsv.Rows[numrow].Cells[7].Value.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*ac.connsql.Open();
            string sql = $"select Songuoi, GioiHan from Phong where Maphong = '{cbomaphong.SelectedValue}'";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataReader dr = com.ExecuteReader();
            int soNguoi = -1;
            int gioiHan = -1;
            while (dr.Read())
            {
                soNguoi = int.Parse(dr.GetValue(0).ToString());
                gioiHan = int.Parse(dr.GetValue(1).ToString());
            }
            if (soNguoi == gioiHan)
                MessageBox.Show("The room is full !", "Notification");
            else
            {
                MessageBox.Show("Phòng chưa full", "Notification");
            }*/
        }

        private void Sinhvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }
    }
}
