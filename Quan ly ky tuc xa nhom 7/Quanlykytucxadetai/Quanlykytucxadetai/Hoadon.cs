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
    public partial class Hoadon : Form
    {
        Connect ac = new Connect();
        public Hoadon()
        {
            InitializeComponent();
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            laydulieubanghoadon();
            laydulieumaphong();
            txtmahd.Focus();
        }

        private void laydulieubanghoadon()
        {
            dataGridViewHoadon.DataSource = ac.Get("select * from Hoadon");
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
            cbomaphong.DisplayMember = "Phong.Maphong";
            cbomaphong.ValueMember = "Maphong";
        }

        private bool ktramahd(string mahd)
        {
            ac.connsql.Open();
            string sql = $" select * from Hoadon where Mahd = '{mahd}' ";
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
            if (txtmahd.Text == "" || txtsodien.Text == "" || txtsokhoinuoc.Text == "" || cbomaphong.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramahd(txtmahd.Text) == false)
                    MessageBox.Show("Mã hóa đơn Đã tồn tại", "Thông báo");
                else
                {
                    ac.connsql.Open();
                    string sql = $"select Songuoi from Phong where Maphong = '{cbomaphong.SelectedValue}'";
                    SqlCommand com = new SqlCommand(sql, ac.connsql);
                    com.CommandType = CommandType.Text;
                    SqlDataReader dr = com.ExecuteReader();
                    int songuoi = -1;
                    while (dr.Read())
                    {
                        songuoi = int.Parse(dr.GetValue(0).ToString());
                    }
                    if (songuoi == 0)
                        MessageBox.Show("Phòng này không có người ở không thể tạo hóa đơn !", "Notification");
                    else
                    {
                        try
                        {
                            ac.Action("insert into Hoadon values ( N'" + txtmahd.Text + "','" + dateTimePicker1.Value + "', N'" + cbomaphong.SelectedValue + "','" + txtsodien.Text + "','" + txtsokhoinuoc.Text + "' ) ");
                            laydulieubanghoadon();
                        }
                        catch
                        {
                            MessageBox.Show(" Hóa đơn phòng " + cbomaphong.SelectedValue + " đã tồn tại!!\n Bạn vui lòng chọn phòng khác!! \n  Cảm ơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    ac.connsql.Close();
                }
            }
        }

        private void btnquayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }

        private void dataGridViewHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = e.RowIndex;
            if (a > -1)
            {
                txtmahd.Text = dataGridViewHoadon.Rows[a].Cells[0].Value.ToString();
                dateTimePicker1.Text = dataGridViewHoadon.Rows[a].Cells[1].Value.ToString();
                cbomaphong.Text = dataGridViewHoadon.Rows[a].Cells[2].Value.ToString();
                txtsodien.Text = dataGridViewHoadon.Rows[a].Cells[3].Value.ToString();
                txtsokhoinuoc.Text = dataGridViewHoadon.Rows[a].Cells[4].Value.ToString();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text == "" || txtsodien.Text == "" || txtsokhoinuoc.Text == "" || cbomaphong.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramahd(txtmahd.Text) == true)
                    MessageBox.Show("Mã hóa đơn không tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        ac.Action(" update Hoadon set Ngaythu = '"+ dateTimePicker1.Value+"', Maphong = N'"+cbomaphong.SelectedValue+"', Sodien = '"+txtsodien.Text+"', Sonuoc = '" + txtsokhoinuoc.Text + "' where Mahd = N'" + txtmahd.Text + "' ");
                        laydulieubanghoadon();
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
            if (txtmahd.Text == "" || txtsodien.Text == "" || txtsokhoinuoc.Text == "" || cbomaphong.Text == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
            else
            {
                if (ktramahd(txtmahd.Text) == true)
                    MessageBox.Show("Mã hóa đơn không tồn tại", "Thông báo");
                else
                {
                    try
                    {
                        ac.Action(" delete from Hoadon where Mahd = N'" + txtmahd.Text + "' ");
                        laydulieubanghoadon();
                    }
                    catch
                    {
                        MessageBox.Show("Co loi nhap lieu!!!", "thong bao");
                    }
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmahd.Clear();
            cbomaphong.Text = "";
            txtsodien.Clear();
            txtsokhoinuoc.Clear();
            txtmahd.Focus();
        }

        private void Hoadon_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Trangchu gg = new Trangchu();
            gg.Show();
        }
    }
}
