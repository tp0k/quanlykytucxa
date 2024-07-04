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
    public partial class Phong : Form
    {
        Connect ac = new Connect();
        public Phong()
        {
            InitializeComponent();
        }

        private void btnquayxe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            laydulieuphong();
            laydulieutenloaiphong();
            txtMaphong.Focus();
            txtsonguoi.Text = "0";//khong cho nhap so nguoi
        }

        private void laydulieuphong()
        {
            dataGridViewphong.DataSource = ac.Get("select * from Phong");
        }

        private void laydulieutenloaiphong()
        {
            ac.connsql.Open();
            string sql = "select Maloaiphong,Tenloaiphong from Loaiphong ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            ac.connsql.Close();
            cbomaloaiphong.DataSource = dt;
            cbomaloaiphong.DisplayMember = "Tenloaiphong";
            cbomaloaiphong.ValueMember = "Maloaiphong";
        }

        private void dataGridViewphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow > -1)
            {
                txtMaphong.Text = dataGridViewphong.Rows[numrow].Cells[0].Value.ToString();
                txtdaynha.Text = dataGridViewphong.Rows[numrow].Cells[1].Value.ToString();
                txtsonguoi.Text = dataGridViewphong.Rows[numrow].Cells[2].Value.ToString();
                txtGioihan.Text = dataGridViewphong.Rows[numrow].Cells[3].Value.ToString();
                cbomaloaiphong.Text = Tenlp(dataGridViewphong.Rows[numrow].Cells[4].Value.ToString());
            }
        }

        private string Tenlp(string Malp)
        {
            string tenlp = "";
            ac.connsql.Open();
            string sql = $" select Tenloaiphong from Loaiphong where Maloaiphong = '{Malp}' ";
            SqlCommand com = new SqlCommand(sql, ac.connsql);
            com.CommandType = CommandType.Text;
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                tenlp = dr["Tenloaiphong"].ToString();
            }
            dr.Close();
            ac.connsql.Close();
            return tenlp;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsonguoi.Clear();
            txtdaynha.Clear();
            txtMaphong.Clear();
            cbomaloaiphong.Text = "";
            txtGioihan.Clear();
            txtMaphong.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text == "" || txtdaynha.Text == "" || txtsonguoi.Text == "" || cbomaloaiphong.Text == "" || txtGioihan.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramaphong(txtMaphong.Text) == false)
                    MessageBox.Show("MÃ phòng đã tồn tại", "thông báo");
                else
                {
                    try
                    {
                        txtsonguoi.Text = "0";//k cho nhap so nguoi
                        ac.Action("insert into Phong values ( N'" + txtMaphong.Text + "', N'" + txtdaynha.Text + "' , '" + txtsonguoi.Text + "' , '" + txtGioihan.Text + "', N'" + cbomaloaiphong.SelectedValue + "' ) ");
                        laydulieuphong();                       
                    }
                    catch
                    {
                        MessageBox.Show("co loi nhap lieu", "thong bao");
                    }
                }
            }
        }

        private bool ktramaphong(string maphong)
        {
            ac.connsql.Open();
            string sql = $" select * from Phong where Maphong = '{maphong}' ";
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
            if (txtMaphong.Text == "" || txtdaynha.Text == "" || txtsonguoi.Text == "" || cbomaloaiphong.Text == "" || txtGioihan.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin ", "Thông báo");
            else
            {
                if (ktramaphong(txtMaphong.Text) == true)
                    MessageBox.Show("Mã phòng không tồn tại", "thông báo");
                else
                {   //thu du lieu khi khong cho nhap so nguoi, cut di    Songuoi = '" + txtsonguoi.Text + "',
                    try
                    {
                        ac.Action("update Phong set Daynha = N'" + txtdaynha.Text + "',  Maloaiphong = N'" + cbomaloaiphong.SelectedValue + "', GioiHan = '" + txtGioihan.Text + "' Where Maphong = N'" + txtMaphong.Text + "' ");
                        laydulieuphong();
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
            if (txtMaphong.Text == "" || txtdaynha.Text == "" || txtsonguoi.Text == "" || cbomaloaiphong.Text == "" || txtGioihan.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "thông báo");
            else
            {
                if (ktramaphong(txtMaphong.Text) == true)
                    MessageBox.Show("Mã phòng không tồn tại", "thông báo");
                else
                {
                    try
                    {
                        ac.Action(" delete from Phong Where Maphong = N'" + txtMaphong.Text + "' ");
                        laydulieuphong();
                    }
                    catch
                    {
                        MessageBox.Show("Phòng đang có người ở không thể xóa ???", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Phong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void txtsonguoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
