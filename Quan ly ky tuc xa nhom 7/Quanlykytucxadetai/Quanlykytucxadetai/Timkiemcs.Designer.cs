namespace Quanlykytucxadetai
{
    partial class Timkiemcs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbotim1 = new System.Windows.Forms.Button();
            this.dgvtimkiem1 = new System.Windows.Forms.DataGridView();
            this.Masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbomalop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.btntk1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbotim2 = new System.Windows.Forms.Button();
            this.dgvtimkiem2 = new System.Windows.Forms.DataGridView();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sonuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Songuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tienphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboloaiphong = new System.Windows.Forms.ComboBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btntk2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnquayve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbotim1);
            this.groupBox1.Controls.Add(this.dgvtimkiem1);
            this.groupBox1.Controls.Add(this.cbomalop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmasv);
            this.groupBox1.Controls.Add(this.btntk1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(721, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo sinh viên";
            // 
            // btnbotim1
            // 
            this.btnbotim1.Location = new System.Drawing.Point(466, 37);
            this.btnbotim1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbotim1.Name = "btnbotim1";
            this.btnbotim1.Size = new System.Drawing.Size(56, 19);
            this.btnbotim1.TabIndex = 9;
            this.btnbotim1.Text = "Bỏ tìm";
            this.btnbotim1.UseVisualStyleBackColor = true;
            this.btnbotim1.Click += new System.EventHandler(this.btnbotim1_Click);
            // 
            // dgvtimkiem1
            // 
            this.dgvtimkiem1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiem1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masv,
            this.Maphong,
            this.Tensv,
            this.Gioitinh,
            this.Sdt,
            this.Quequan,
            this.Tenlop,
            this.Tenkhoa});
            this.dgvtimkiem1.Location = new System.Drawing.Point(11, 91);
            this.dgvtimkiem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvtimkiem1.Name = "dgvtimkiem1";
            this.dgvtimkiem1.RowHeadersWidth = 51;
            this.dgvtimkiem1.RowTemplate.Height = 24;
            this.dgvtimkiem1.Size = new System.Drawing.Size(698, 108);
            this.dgvtimkiem1.TabIndex = 8;
            this.dgvtimkiem1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtimkiem1_CellClick);
            // 
            // Masv
            // 
            this.Masv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Masv.DataPropertyName = "Masv";
            this.Masv.HeaderText = "Mã sinh viên";
            this.Masv.MinimumWidth = 6;
            this.Masv.Name = "Masv";
            this.Masv.Width = 92;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.Width = 125;
            // 
            // Tensv
            // 
            this.Tensv.DataPropertyName = "Tensv";
            this.Tensv.HeaderText = "Tên sinh viên";
            this.Tensv.MinimumWidth = 6;
            this.Tensv.Name = "Tensv";
            this.Tensv.Width = 125;
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 6;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Width = 125;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 125;
            // 
            // Quequan
            // 
            this.Quequan.DataPropertyName = "Quequan";
            this.Quequan.HeaderText = "Quê quán";
            this.Quequan.MinimumWidth = 6;
            this.Quequan.Name = "Quequan";
            this.Quequan.Width = 125;
            // 
            // Tenlop
            // 
            this.Tenlop.DataPropertyName = "Tenlop";
            this.Tenlop.HeaderText = "Tên lớp";
            this.Tenlop.MinimumWidth = 6;
            this.Tenlop.Name = "Tenlop";
            this.Tenlop.Width = 125;
            // 
            // Tenkhoa
            // 
            this.Tenkhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tenkhoa.DataPropertyName = "Tenkhoa";
            this.Tenkhoa.HeaderText = "Tên khoa";
            this.Tenkhoa.MinimumWidth = 6;
            this.Tenkhoa.Name = "Tenkhoa";
            this.Tenkhoa.Width = 125;
            // 
            // cbomalop
            // 
            this.cbomalop.FormattingEnabled = true;
            this.cbomalop.Location = new System.Drawing.Point(208, 51);
            this.cbomalop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbomalop.Name = "cbomalop";
            this.cbomalop.Size = new System.Drawing.Size(123, 21);
            this.cbomalop.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên lớp";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(208, 23);
            this.txtmasv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(123, 20);
            this.txtmasv.TabIndex = 5;
            // 
            // btntk1
            // 
            this.btntk1.Location = new System.Drawing.Point(381, 37);
            this.btntk1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntk1.Name = "btntk1";
            this.btntk1.Size = new System.Drawing.Size(56, 19);
            this.btntk1.TabIndex = 4;
            this.btntk1.Text = "Tìm kiếm";
            this.btntk1.UseVisualStyleBackColor = true;
            this.btntk1.Click += new System.EventHandler(this.btntk1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbotim2);
            this.groupBox2.Controls.Add(this.dgvtimkiem2);
            this.groupBox2.Controls.Add(this.cboloaiphong);
            this.groupBox2.Controls.Add(this.txtmaphong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btntk2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(36, 255);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(721, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo phòng";
            // 
            // btnbotim2
            // 
            this.btnbotim2.Location = new System.Drawing.Point(466, 32);
            this.btnbotim2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbotim2.Name = "btnbotim2";
            this.btnbotim2.Size = new System.Drawing.Size(56, 19);
            this.btnbotim2.TabIndex = 11;
            this.btnbotim2.Text = "Bỏ tìm";
            this.btnbotim2.UseVisualStyleBackColor = true;
            this.btnbotim2.Click += new System.EventHandler(this.btnbotim2_Click);
            // 
            // dgvtimkiem2
            // 
            this.dgvtimkiem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiem2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phong,
            this.Maloaiphong,
            this.Sodien,
            this.Sonuoc,
            this.Songuoi,
            this.Tenloaiphong,
            this.Giatien,
            this.Tienphong});
            this.dgvtimkiem2.Location = new System.Drawing.Point(11, 77);
            this.dgvtimkiem2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvtimkiem2.Name = "dgvtimkiem2";
            this.dgvtimkiem2.RowHeadersWidth = 51;
            this.dgvtimkiem2.RowTemplate.Height = 24;
            this.dgvtimkiem2.Size = new System.Drawing.Size(698, 108);
            this.dgvtimkiem2.TabIndex = 10;
            this.dgvtimkiem2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtimkiem2_CellClick);
            // 
            // Phong
            // 
            this.Phong.DataPropertyName = "Maphong";
            this.Phong.HeaderText = "Mã phòng";
            this.Phong.MinimumWidth = 6;
            this.Phong.Name = "Phong";
            this.Phong.Width = 125;
            // 
            // Maloaiphong
            // 
            this.Maloaiphong.DataPropertyName = "Maloaiphong";
            this.Maloaiphong.HeaderText = "Mã loại phòng";
            this.Maloaiphong.MinimumWidth = 6;
            this.Maloaiphong.Name = "Maloaiphong";
            this.Maloaiphong.Width = 125;
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
            this.Sonuoc.DataPropertyName = "Sonuoc";
            this.Sonuoc.HeaderText = "Số khối nước";
            this.Sonuoc.MinimumWidth = 6;
            this.Sonuoc.Name = "Sonuoc";
            this.Sonuoc.Width = 125;
            // 
            // Songuoi
            // 
            this.Songuoi.DataPropertyName = "Songuoi";
            this.Songuoi.HeaderText = "Số người ở";
            this.Songuoi.MinimumWidth = 6;
            this.Songuoi.Name = "Songuoi";
            this.Songuoi.Width = 125;
            // 
            // Tenloaiphong
            // 
            this.Tenloaiphong.DataPropertyName = "Tenloaiphong";
            this.Tenloaiphong.HeaderText = "Tên loại phòng";
            this.Tenloaiphong.MinimumWidth = 6;
            this.Tenloaiphong.Name = "Tenloaiphong";
            this.Tenloaiphong.Width = 125;
            // 
            // Giatien
            // 
            this.Giatien.DataPropertyName = "Giatien";
            this.Giatien.HeaderText = "Giá phòng";
            this.Giatien.MinimumWidth = 6;
            this.Giatien.Name = "Giatien";
            this.Giatien.Width = 125;
            // 
            // Tienphong
            // 
            this.Tienphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tienphong.DataPropertyName = "Tienphong";
            this.Tienphong.HeaderText = "Tiền phòng";
            this.Tienphong.MinimumWidth = 6;
            this.Tienphong.Name = "Tienphong";
            this.Tienphong.Width = 125;
            // 
            // cboloaiphong
            // 
            this.cboloaiphong.FormattingEnabled = true;
            this.cboloaiphong.Location = new System.Drawing.Point(208, 47);
            this.cboloaiphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboloaiphong.Name = "cboloaiphong";
            this.cboloaiphong.Size = new System.Drawing.Size(123, 21);
            this.cboloaiphong.TabIndex = 9;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(208, 15);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(123, 20);
            this.txtmaphong.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại phòng";
            // 
            // btntk2
            // 
            this.btntk2.Location = new System.Drawing.Point(381, 32);
            this.btntk2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntk2.Name = "btntk2";
            this.btntk2.Size = new System.Drawing.Size(56, 19);
            this.btntk2.TabIndex = 1;
            this.btntk2.Text = "Tìm kiếm";
            this.btntk2.UseVisualStyleBackColor = true;
            this.btntk2.Click += new System.EventHandler(this.btntk2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnquayve
            // 
            this.btnquayve.Location = new System.Drawing.Point(676, 465);
            this.btnquayve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnquayve.Name = "btnquayve";
            this.btnquayve.Size = new System.Drawing.Size(104, 26);
            this.btnquayve.TabIndex = 2;
            this.btnquayve.Text = "Quay lại trang chủ";
            this.btnquayve.UseVisualStyleBackColor = true;
            this.btnquayve.Click += new System.EventHandler(this.btnquayve_Click);
            // 
            // Timkiemcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(806, 500);
            this.Controls.Add(this.btnquayve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Timkiemcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Timkiemcs_FormClosed);
            this.Load += new System.EventHandler(this.Timkiemcs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Button btntk1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntk2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnquayve;
        private System.Windows.Forms.ComboBox cbomalop;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.DataGridView dgvtimkiem1;
        private System.Windows.Forms.DataGridView dgvtimkiem2;
        private System.Windows.Forms.ComboBox cboloaiphong;
        private System.Windows.Forms.Button btnbotim1;
        private System.Windows.Forms.Button btnbotim2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sonuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giatien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tienphong;
    }
}