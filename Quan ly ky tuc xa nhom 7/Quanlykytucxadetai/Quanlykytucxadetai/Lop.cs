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
    public partial class Lop : Form
    {
        Connect ac = new Connect();
        public Lop()
        {
            InitializeComponent();
        }

        private void btnquayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            laydulieubanglop();
            laydulieutenkhoa();
            txtmalop.Focus();
        }

        private void laydulieubanglop()
        {
            dgvbanglop.DataSource = ac.Get("select * from lop");
        }

        private void laydulieutenkhoa()
        {
            ac.connsql.Open();
            string sql = "select Makhoa,Tenkhoa from Khoa ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            cbotenkhoa.DataSource = dt;
            cbotenkhoa.DisplayMember = "Tenkhoa";
            cbotenkhoa.ValueMember = "Makhoa";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text == "" || txttenlop.Text == "" || cbotenkhoa.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "thông báo");
            else
            {
                if (ktramalop(txtmalop.Text) == false)
                    MessageBox.Show("Mã lớp đã tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        ac.Action("insert into Lop values ( N'" + txtmalop.Text + "', N'" + txttenlop.Text + "', N'" + cbotenkhoa.SelectedValue + "' ) ");
                        laydulieubanglop();
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private bool ktramalop(string malop)
        {
            ac.connsql.Open();
            string sql = $" select * from Lop where Malop = '{malop}' ";
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text == "" || txttenlop.Text == "" || cbotenkhoa.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "thông báo");
            else
            {
                if (ktramalop(txtmalop.Text) == true)
                    MessageBox.Show("Mã lớp không tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        ac.Action("update Lop set Tenlop = N'" + txttenlop.Text + "',Makhoa = N'" + cbotenkhoa.SelectedValue + "' where Malop =  N'" + txtmalop.Text + "' ");
                        laydulieubanglop();
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text == "" )
                MessageBox.Show("Bạn cần nhập mã lớp để xóa", "thông báo");
            else
            {
                if (ktramalop(txtmalop.Text) == true)
                    MessageBox.Show("MÃ lớp không tồn tại", "thông báo");
                else
                {
                    try
                    {
                        ac.Action("delete from Lop where Malop =  N'" + txtmalop.Text + "' ");
                        laydulieubanglop();
                    }
                    catch
                    {
                        MessageBox.Show("Lớp đã tồn tại sinh viên đăng kí không thể xóa ???", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dgvbanglop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow > -1)
            {
                txtmalop.Text = dgvbanglop.Rows[numrow].Cells[0].Value.ToString();
                txttenlop.Text = dgvbanglop.Rows[numrow].Cells[1].Value.ToString();
                cbotenkhoa.Text = Tenkhoa(dgvbanglop.Rows[numrow].Cells[2].Value.ToString());
            }
        }

        private string Tenkhoa(string Makhoa)
        {
            string tenkhoa = "";
            ac.connsql.Open();
            string sql = $" select Tenkhoa from Khoa where Makhoa = '{Makhoa}' ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                tenkhoa = dr["Tenkhoa"].ToString();
            }
            dr.Close();
            ac.connsql.Close();
            return tenkhoa;
        }

        private void Lop_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }
    }
}
