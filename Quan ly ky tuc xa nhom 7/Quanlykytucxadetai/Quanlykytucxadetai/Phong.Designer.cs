namespace Quanlykytucxadetai
{
    partial class Phong
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
            this.components = new System.ComponentModel.Container();
            this.gg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.cbomaloaiphong = new System.Windows.Forms.ComboBox();
            this.txtdaynha = new System.Windows.Forms.TextBox();
            this.txtsonguoi = new System.Windows.Forms.TextBox();
            this.dataGridViewphong = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daynha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Songuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnquayxe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGioihan = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewphong)).BeginInit();
            this.SuspendLayout();
            // 
            // gg
            // 
            this.gg.AutoSize = true;
            this.gg.Location = new System.Drawing.Point(36, 33);
            this.gg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(55, 13);
            this.gg.TabIndex = 0;
            this.gg.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dãy nhà";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số người";
            this.toolTip1.SetToolTip(this.label3, "Số người của một phòng khi tạo mới mặc định là 0 và sẽ thay đổi theo số sinh viên" +
        " đăng kí vào phòng");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên loại phòng";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(160, 33);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(151, 20);
            this.txtMaphong.TabIndex = 4;
            // 
            // cbomaloaiphong
            // 
            this.cbomaloaiphong.FormattingEnabled = true;
            this.cbomaloaiphong.Location = new System.Drawing.Point(160, 152);
            this.cbomaloaiphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbomaloaiphong.Name = "cbomaloaiphong";
            this.cbomaloaiphong.Size = new System.Drawing.Size(151, 21);
            this.cbomaloaiphong.TabIndex = 5;
            // 
            // txtdaynha
            // 
            this.txtdaynha.Location = new System.Drawing.Point(160, 58);
            this.txtdaynha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdaynha.Name = "txtdaynha";
            this.txtdaynha.Size = new System.Drawing.Size(151, 20);
            this.txtdaynha.TabIndex = 6;
            // 
            // txtsonguoi
            // 
            this.txtsonguoi.Enabled = false;
            this.txtsonguoi.Location = new System.Drawing.Point(160, 88);
            this.txtsonguoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsonguoi.Name = "txtsonguoi";
            this.txtsonguoi.Size = new System.Drawing.Size(151, 20);
            this.txtsonguoi.TabIndex = 7;
            this.txtsonguoi.TextChanged += new System.EventHandler(this.txtsonguoi_TextChanged);
            // 
            // dataGridViewphong
            // 
            this.dataGridViewphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Daynha,
            this.Songuoi,
            this.Maloaiphong,
            this.GioiHan});
            this.dataGridViewphong.Location = new System.Drawing.Point(38, 194);
            this.dataGridViewphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewphong.Name = "dataGridViewphong";
            this.dataGridViewphong.RowHeadersWidth = 51;
            this.dataGridViewphong.RowTemplate.Height = 24;
            this.dataGridViewphong.Size = new System.Drawing.Size(541, 122);
            this.dataGridViewphong.TabIndex = 8;
            this.dataGridViewphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewphong_CellClick);
            // 
            // Maphong
            // 
            this.Maphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.Width = 74;
            // 
            // Daynha
            // 
            this.Daynha.DataPropertyName = "Daynha";
            this.Daynha.HeaderText = "Dãy nhà";
            this.Daynha.MinimumWidth = 6;
            this.Daynha.Name = "Daynha";
            this.Daynha.Width = 125;
            // 
            // Songuoi
            // 
            this.Songuoi.DataPropertyName = "Songuoi";
            this.Songuoi.HeaderText = "Số người";
            this.Songuoi.MinimumWidth = 6;
            this.Songuoi.Name = "Songuoi";
            this.Songuoi.Width = 125;
            // 
            // Maloaiphong
            // 
            this.Maloaiphong.DataPropertyName = "Maloaiphong";
            this.Maloaiphong.HeaderText = "Mã loại phòng";
            this.Maloaiphong.MinimumWidth = 6;
            this.Maloaiphong.Name = "Maloaiphong";
            this.Maloaiphong.Width = 125;
            // 
            // GioiHan
            // 
            this.GioiHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GioiHan.DataPropertyName = "GioiHan";
            this.GioiHan.HeaderText = "Giới hạn số người";
            this.GioiHan.MinimumWidth = 6;
            this.GioiHan.Name = "GioiHan";
            this.GioiHan.Width = 193;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(410, 29);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(56, 19);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(501, 29);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(56, 19);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(410, 58);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(56, 19);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(501, 58);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(56, 19);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnquayxe
            // 
            this.btnquayxe.Location = new System.Drawing.Point(442, 154);
            this.btnquayxe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnquayxe.Name = "btnquayxe";
            this.btnquayxe.Size = new System.Drawing.Size(124, 23);
            this.btnquayxe.TabIndex = 13;
            this.btnquayxe.Text = "Quay về trang chủ";
            this.btnquayxe.UseVisualStyleBackColor = true;
            this.btnquayxe.Click += new System.EventHandler(this.btnquayxe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giới hạn số người";
            // 
            // txtGioihan
            // 
            this.txtGioihan.Location = new System.Drawing.Point(160, 119);
            this.txtGioihan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGioihan.Name = "txtGioihan";
            this.txtGioihan.Size = new System.Drawing.Size(151, 20);
            this.txtGioihan.TabIndex = 15;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 341);
            this.Controls.Add(this.txtGioihan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnquayxe);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridViewphong);
            this.Controls.Add(this.txtsonguoi);
            this.Controls.Add(this.txtdaynha);
            this.Controls.Add(this.cbomaloaiphong);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gg);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Phong_FormClosed);
            this.Load += new System.EventHandler(this.Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.ComboBox cbomaloaiphong;
        private System.Windows.Forms.TextBox txtdaynha;
        private System.Windows.Forms.TextBox txtsonguoi;
        private System.Windows.Forms.DataGridView dataGridViewphong;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnquayxe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGioihan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daynha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiHan;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}