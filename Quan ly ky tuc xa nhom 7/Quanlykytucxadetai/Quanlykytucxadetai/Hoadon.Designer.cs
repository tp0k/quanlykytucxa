namespace Quanlykytucxadetai
{
    partial class Hoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewHoadon = new System.Windows.Forms.DataGridView();
            this.Mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaythu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.txtsodien = new System.Windows.Forms.TextBox();
            this.txtsokhoinuoc = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnquayve = new System.Windows.Forms.Button();
            this.cbomaphong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số khối nước";
            // 
            // dataGridViewHoadon
            // 
            this.dataGridViewHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahoadon,
            this.Ngaythu,
            this.Maphong,
            this.Sodien,
            this.Sonuoc});
            this.dataGridViewHoadon.Location = new System.Drawing.Point(20, 201);
            this.dataGridViewHoadon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHoadon.Name = "dataGridViewHoadon";
            this.dataGridViewHoadon.RowHeadersWidth = 51;
            this.dataGridViewHoadon.RowTemplate.Height = 24;
            this.dataGridViewHoadon.Size = new System.Drawing.Size(560, 122);
            this.dataGridViewHoadon.TabIndex = 5;
            this.dataGridViewHoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoadon_CellClick);
            // 
            // Mahoadon
            // 
            this.Mahoadon.DataPropertyName = "Mahd";
            this.Mahoadon.HeaderText = "Mã hóa đơn";
            this.Mahoadon.MinimumWidth = 6;
            this.Mahoadon.Name = "Mahoadon";
            this.Mahoadon.Width = 125;
            // 
            // Ngaythu
            // 
            this.Ngaythu.DataPropertyName = "Ngaythu";
            this.Ngaythu.HeaderText = "Ngày thu";
            this.Ngaythu.MinimumWidth = 6;
            this.Ngaythu.Name = "Ngaythu";
            this.Ngaythu.Width = 125;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.Width = 125;
            // 
            // Sodien
            // 
            this.Sodien.DataPropertyName = "Sodien";
            this.Sodien.HeaderText = "Số điện";
            this.Sodien.MinimumWidth = 6;
            this.Sodien.Name = "Sodien";
            this.Sodien.Width = 125;
            // 
            // Sonuoc
            // 
            this.Sonuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sonuoc.DataPropertyName = "Sonuoc";
            this.Sonuoc.HeaderText = "Số khối nước";
            this.Sonuoc.MinimumWidth = 6;
            this.Sonuoc.Name = "Sonuoc";
            this.Sonuoc.Width = 194;
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(106, 37);
            this.txtmahd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(151, 20);
            this.txtmahd.TabIndex = 6;
            // 
            // txtsodien
            // 
            this.txtsodien.Location = new System.Drawing.Point(106, 128);
            this.txtsodien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsodien.Name = "txtsodien";
            this.txtsodien.Size = new System.Drawing.Size(151, 20);
            this.txtsodien.TabIndex = 8;
            // 
            // txtsokhoinuoc
            // 
            this.txtsokhoinuoc.Location = new System.Drawing.Point(106, 156);
            this.txtsokhoinuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsokhoinuoc.Name = "txtsokhoinuoc";
            this.txtsokhoinuoc.Size = new System.Drawing.Size(151, 20);
            this.txtsokhoinuoc.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 67);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 23);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 5, 1, 24, 58, 0);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(361, 35);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 19);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(451, 34);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(56, 19);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(361, 78);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(56, 19);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(451, 78);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(56, 19);
            this.btnreset.TabIndex = 14;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnquayve
            // 
            this.btnquayve.Location = new System.Drawing.Point(451, 158);
            this.btnquayve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnquayve.Name = "btnquayve";
            this.btnquayve.Size = new System.Drawing.Size(115, 24);
            this.btnquayve.TabIndex = 15;
            this.btnquayve.Text = "Quay lại trang chủ";
            this.btnquayve.UseVisualStyleBackColor = true;
            this.btnquayve.Click += new System.EventHandler(this.btnquayve_Click);
            // 
            // cbomaphong
            // 
            this.cbomaphong.FormattingEnabled = true;
            this.cbomaphong.Location = new System.Drawing.Point(106, 96);
            this.cbomaphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbomaphong.Name = "cbomaphong";
            this.cbomaphong.Size = new System.Drawing.Size(151, 21);
            this.cbomaphong.TabIndex = 16;
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 349);
            this.Controls.Add(this.cbomaphong);
            this.Controls.Add(this.btnquayve);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtsokhoinuoc);
            this.Controls.Add(this.txtsodien);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.dataGridViewHoadon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hoadon_FormClosed);
            this.Load += new System.EventHandler(this.Hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewHoadon;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.TextBox txtsodien;
        private System.Windows.Forms.TextBox txtsokhoinuoc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnquayve;
        private System.Windows.Forms.ComboBox cbomaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaythu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonuoc;
    }
}