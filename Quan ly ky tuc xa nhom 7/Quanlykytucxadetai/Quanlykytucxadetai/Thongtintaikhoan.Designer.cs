namespace Quanlykytucxadetai
{
    partial class Thongtintaikhoan
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
            this.dgvlaydulieu = new System.Windows.Forms.DataGridView();
            this.Hotennguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txthienthi = new System.Windows.Forms.Button();
            this.txtlogout = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtquayve = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaydulieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlaydulieu
            // 
            this.dgvlaydulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlaydulieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotennguoidung,
            this.Username,
            this.Sdt,
            this.Gioitinh,
            this.Pass});
            this.dgvlaydulieu.Location = new System.Drawing.Point(22, 119);
            this.dgvlaydulieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvlaydulieu.Name = "dgvlaydulieu";
            this.dgvlaydulieu.RowHeadersWidth = 51;
            this.dgvlaydulieu.RowTemplate.Height = 24;
            this.dgvlaydulieu.Size = new System.Drawing.Size(538, 84);
            this.dgvlaydulieu.TabIndex = 0;
            // 
            // Hotennguoidung
            // 
            this.Hotennguoidung.DataPropertyName = "Hotennguoidung";
            this.Hotennguoidung.HeaderText = "Họ và tên";
            this.Hotennguoidung.MinimumWidth = 6;
            this.Hotennguoidung.Name = "Hotennguoidung";
            this.Hotennguoidung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hotennguoidung.Width = 125;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 125;
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 6;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Width = 125;
            // 
            // Pass
            // 
            this.Pass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pass.DataPropertyName = "Pass";
            this.Pass.HeaderText = "Password";
            this.Pass.MinimumWidth = 6;
            this.Pass.Name = "Pass";
            this.Pass.Width = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // txthienthi
            // 
            this.txthienthi.Location = new System.Drawing.Point(462, 77);
            this.txthienthi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txthienthi.Name = "txthienthi";
            this.txthienthi.Size = new System.Drawing.Size(98, 25);
            this.txthienthi.TabIndex = 2;
            this.txthienthi.Text = "Hiển thị thông tin";
            this.txthienthi.UseVisualStyleBackColor = true;
            this.txthienthi.Click += new System.EventHandler(this.txtedit_Click);
            // 
            // txtlogout
            // 
            this.txtlogout.Location = new System.Drawing.Point(22, 228);
            this.txtlogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlogout.Name = "txtlogout";
            this.txtlogout.Size = new System.Drawing.Size(56, 29);
            this.txtlogout.TabIndex = 3;
            this.txtlogout.Text = "Log out";
            this.txtlogout.UseVisualStyleBackColor = true;
            this.txtlogout.Click += new System.EventHandler(this.txtlogout_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(191, 78);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(120, 20);
            this.txtPass.TabIndex = 4;
            // 
            // txtquayve
            // 
            this.txtquayve.Location = new System.Drawing.Point(464, 228);
            this.txtquayve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtquayve.Name = "txtquayve";
            this.txtquayve.Size = new System.Drawing.Size(104, 29);
            this.txtquayve.TabIndex = 6;
            this.txtquayve.Text = "Quay lại trang chủ";
            this.txtquayve.UseVisualStyleBackColor = true;
            this.txtquayve.Click += new System.EventHandler(this.txtquayve_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(22, 78);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(120, 20);
            this.txtUser.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu";
            // 
            // Thongtintaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(578, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtquayve);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtlogout);
            this.Controls.Add(this.txthienthi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlaydulieu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Thongtintaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu thông tin tài khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Thongtintaikhoan_FormClosed);
            this.Load += new System.EventHandler(this.Thongtintaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaydulieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlaydulieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txthienthi;
        private System.Windows.Forms.Button txtlogout;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotennguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.Button txtquayve;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}