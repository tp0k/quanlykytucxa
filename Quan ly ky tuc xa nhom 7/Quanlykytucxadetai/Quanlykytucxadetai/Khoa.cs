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
    public partial class Khoa : Form
    {
        Connect ac = new Connect();
        public Khoa()
        {
            InitializeComponent();
        }

        private void btnquayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            laydulieubangkhoa();
            txtmakhoa.Focus();
        }

        private void laydulieubangkhoa()
        {
            dgvbangkhoa.DataSource = ac.Get("select * from Khoa");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmakhoa.Clear();
            txttenkhoa.Clear();
            txtmakhoa.Focus();
        }

        private bool ktramakhoa(string makhoa)
        {
            ac.connsql.Open();
            string sql = $" select * from Khoa where Makhoa = '{makhoa}' ";
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
            if (txtmakhoa.Text == "" || txttenkhoa.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramakhoa(txtmakhoa.Text) == false)
                    MessageBox.Show("Mã khoa đã tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        ac.Action("insert into Khoa values ( N'" + txtmakhoa.Text + "', N'" +txttenkhoa.Text + "' ) ");
                        laydulieubangkhoa();
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
            if (txtmakhoa.Text == "" || txttenkhoa.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramakhoa(txtmakhoa.Text) == true)
                    MessageBox.Show("mã khoa không tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        ac.Action("delete from Khoa where Makhoa = N'" + txtmakhoa.Text + "' ");
                        laydulieubangkhoa();
                    }
                    catch
                    {
                        MessageBox.Show("Khoa "+txttenkhoa.Text+" đã có lớp học được tạo , Không thể xóa ???", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmakhoa.Text == "" || txttenkhoa.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramakhoa(txtmakhoa.Text) == true)
                    MessageBox.Show("Mã khoa không tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        ac.Action(" update Khoa set Tenkhoa = N'"+txttenkhoa.Text+"' where Makhoa = N'"+txtmakhoa.Text+"' ");
                        laydulieubangkhoa();
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private void dgvbangkhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = e.RowIndex;
            if (a > -1)
            {
                txtmakhoa.Text = dgvbangkhoa.Rows[a].Cells[0].Value.ToString();
                txttenkhoa.Text = dgvbangkhoa.Rows[a].Cells[1].Value.ToString();
            }
        }

        private void Khoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }
    }
}
