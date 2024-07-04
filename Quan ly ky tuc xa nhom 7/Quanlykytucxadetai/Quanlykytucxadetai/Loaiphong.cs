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
    public partial class Loaiphong : Form
    {
        Connect ac = new Connect();
        public Loaiphong()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void Loaiphong_Load(object sender, EventArgs e)
        {
            laydulieubangloaiphong();
            txtmalp.Focus();
        }

        private void laydulieubangloaiphong()
        {
            dataGridViewbangloaiphong.DataSource = ac.Get("select * from Loaiphong");
        }

        private void dataGridViewbangloaiphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = e.RowIndex;
            if (a > -1)
            {
                txtmalp.Text = dataGridViewbangloaiphong.Rows[a].Cells[0].Value.ToString();
                txttenlp.Text = dataGridViewbangloaiphong.Rows[a].Cells[1].Value.ToString();
                txtgiatien.Text = dataGridViewbangloaiphong.Rows[a].Cells[2].Value.ToString();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmalp.Clear();
            txttenlp.Clear();
            txtgiatien.Clear();
            txtmalp.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmalp.Text == "" || txttenlp.Text == "" || txtgiatien.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramalp(txtmalp.Text) == false)
                    MessageBox.Show("MÃ loại phong đã tôn tại", "Thông báo");
                else
                {
                    try
                    {
                        ac.Action("insert into Loaiphong values ( N'" + txtmalp.Text + "', N'" + txttenlp.Text + "','" + txtgiatien.Text + "' ) ");
                        laydulieubangloaiphong();
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private bool ktramalp(string malp)
        {
            ac.connsql.Open();
            string sql = $" select * from Loaiphong where Maloaiphong = '{malp}' ";
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmalp.Text == "" || txttenlp.Text == "" || txtgiatien.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramalp(txtmalp.Text) == true)
                    MessageBox.Show("MÃ loại phòng không tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        ac.Action("update Loaiphong set Tenloaiphong = N'" + txttenlp.Text + "', Giatien = '" + txtgiatien.Text + "' where Maloaiphong = N'"+txtmalp.Text+"' ");
                        laydulieubangloaiphong();
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
            if (txtmalp.Text == "" || txttenlp.Text == "" || txtgiatien.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramalp(txtmalp.Text) == true)
                    MessageBox.Show("MÃ loại phòng đã tồn tại", "thong bao");
                else
                {
                    try
                    {
                        ac.Action("delete from Loaiphong where Maloaiphong = N'" + txtmalp.Text + "' ");
                        laydulieubangloaiphong();
                    }
                    catch
                    {
                        MessageBox.Show($"Phòng ở loại '{txttenlp.Text}' đã được tạo , không thể xóa loại phòng này được ?", "Thông báo");
                    }
                }
            }
        }

        private void Loaiphong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }
    }
}
