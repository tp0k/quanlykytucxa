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
    public partial class Quanlyuser : Form
    {
        Connect ac = new Connect();
        public Quanlyuser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtquaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void Quanlyuser_Load(object sender, EventArgs e)
        {
            laydulieutaikhoan();
            txtuser.Focus();
        }

        private void laydulieutaikhoan()
        {
            dgvlaydulieubangtaikhoan.DataSource = ac.Get("select * from Quanlytaikhoan");
        }

        private bool ktrauser(string user)
        {
            ac.connsql.Open();
            string sql = $" select * from Quanlytaikhoan where Username = '{user}' ";
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
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txthoten.Text == "" || txtsdt.Text == "" || txtpass.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "thông báo");
            else
            {
                if (ktrauser(txtuser.Text) == false)
                    MessageBox.Show("Tên user đã tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        string gt;
                        if (radnam.Checked == true)
                            gt = "Nam";
                        else
                            gt = "Nữ";
                        ac.Action("insert into Quanlytaikhoan values ( N'" + txtuser.Text + "', N'" + txthoten.Text + "','" + txtsdt.Text + "', N'"+gt+"', N'"+txtpass.Text+"' ) ");
                        laydulieutaikhoan();
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
                MessageBox.Show(" Bạn chưa nhập uer cần xóa! ", "Thông báo");
            else if(ktradmin(int.Parse(txtid.Text)) == true )
            {
                MessageBox.Show("Tài khoản Admin dùng để quản lý người dùng , không thể xóa được ~!");
            }
            else
            {
                if (ktrauser(txtuser.Text) == true)
                    MessageBox.Show("Tên uer không tồn tại", "Thông báo");
                else
                {
                    try
                    {          
                        ac.Action("delete from Quanlytaikhoan where Username = N'" + txtuser.Text + "' ");
                        laydulieutaikhoan();
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txthoten.Text == "" || txtsdt.Text == "" || txtpass.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktrauser(txtuser.Text) == true)
                    MessageBox.Show("Tên uer không tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        string gt;
                        if (radnam.Checked == true)
                            gt = "Nam";
                        else
                            gt = "Nữ";
                        ac.Action("update Quanlytaikhoan set Hotennguoidung = N'" + txthoten.Text + "', Sdt = '" + txtsdt.Text + "',Gioitinh = N'" + gt + "', Pass = N'" + txtpass.Text + "' where Username = N'" + txtuser.Text + "' ");
                        laydulieutaikhoan();
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txthoten.Clear();
            txtsdt.Clear();
            radnam.Checked = true;
            radnu.Checked = false;
            txtpass.Clear();
            txtuser.Focus();
        }

        private void dgvlaydulieubangtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow > -1)
            {
                txtid.Text = dgvlaydulieubangtaikhoan.Rows[numrow].Cells[0].Value.ToString();
                txtuser.Text = dgvlaydulieubangtaikhoan.Rows[numrow].Cells[1].Value.ToString();
                txthoten.Text = dgvlaydulieubangtaikhoan.Rows[numrow].Cells[2].Value.ToString();
                txtsdt.Text = dgvlaydulieubangtaikhoan.Rows[numrow].Cells[3].Value.ToString();                
                string gt = this.dgvlaydulieubangtaikhoan.Rows[numrow].Cells[4].Value.ToString();
                if (gt.Trim() == "Nam")
                {
                    radnam.Checked = true;
                }
                else
                {
                    radnu.Checked = true;
                }
                txtpass.Text = dgvlaydulieubangtaikhoan.Rows[numrow].Cells[5].Value.ToString();
            }
        }

        /*private bool ktradmin(string admin)
        {
            ac.connsql.Open();
            string sql = $" select * from Quanlytaikhoan where Username = '{admin}' ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            if (admin == "Admin")
                return true; 
            else
                return false; 
        }*/

        private bool ktradmin(int id)
        {
            ac.connsql.Open();
            string sql = " select * from Quanlytaikhoan where ID = '"+id+"' ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            if (id == 1)
                return true;
            else
                return false;
        }

        private void Quanlyuser_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }
    }
}
