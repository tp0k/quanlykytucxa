namespace Quanlykytucxadetai
{
    partial class Loaiphong
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
            this.txtmalp = new System.Windows.Forms.TextBox();
            this.txttenlp = new System.Windows.Forms.TextBox();
            this.txtgiatien = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewbangloaiphong = new System.Windows.Forms.DataGridView();
            this.Maloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbangloaiphong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá tiền";
            // 
            // txtmalp
            // 
            this.txtmalp.Location = new System.Drawing.Point(115, 23);
            this.txtmalp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmalp.Name = "txtmalp";
            this.txtmalp.Size = new System.Drawing.Size(136, 20);
            this.txtmalp.TabIndex = 3;
            // 
            // txttenlp
            // 
            this.txttenlp.Location = new System.Drawing.Point(115, 59);
            this.txttenlp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttenlp.Name = "txttenlp";
            this.txttenlp.Size = new System.Drawing.Size(136, 20);
            this.txttenlp.TabIndex = 4;
            // 
            // txtgiatien
            // 
            this.txtgiatien.Location = new System.Drawing.Point(115, 96);
            this.txtgiatien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtgiatien.Name = "txtgiatien";
            this.txtgiatien.Size = new System.Drawing.Size(136, 20);
            this.txtgiatien.TabIndex = 5;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(362, 18);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 19);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(459, 18);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(56, 19);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(362, 58);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(56, 19);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(459, 58);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(56, 19);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(422, 142);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 22);
            this.button5.TabIndex = 10;
            this.button5.Text = "Quay về trang chủ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewbangloaiphong
            // 
            this.dataGridViewbangloaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbangloaiphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maloaiphong,
            this.Tenloaiphong,
            this.Giatien});
            this.dataGridViewbangloaiphong.Location = new System.Drawing.Point(20, 184);
            this.dataGridViewbangloaiphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewbangloaiphong.Name = "dataGridViewbangloaiphong";
            this.dataGridViewbangloaiphong.RowHeadersWidth = 51;
            this.dataGridViewbangloaiphong.RowTemplate.Height = 24;
            this.dataGridViewbangloaiphong.Size = new System.Drawing.Size(548, 122);
            this.dataGridViewbangloaiphong.TabIndex = 11;
            this.dataGridViewbangloaiphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewbangloaiphong_CellClick);
            // 
            // Maloaiphong
            // 
            this.Maloaiphong.DataPropertyName = "Maloaiphong";
            this.Maloaiphong.HeaderText = "Mã loại phòng";
            this.Maloaiphong.MinimumWidth = 6;
            this.Maloaiphong.Name = "Maloaiphong";
            this.Maloaiphong.Width = 125;
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
            this.Giatien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Giatien.DataPropertyName = "Giatien";
            this.Giatien.HeaderText = "Giá tiền";
            this.Giatien.MinimumWidth = 6;
            this.Giatien.Name = "Giatien";
            // 
            // Loaiphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 329);
            this.Controls.Add(this.dataGridViewbangloaiphong);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtgiatien);
            this.Controls.Add(this.txttenlp);
            this.Controls.Add(this.txtmalp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Loaiphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Loaiphong_FormClosed);
            this.Load += new System.EventHandler(this.Loaiphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbangloaiphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmalp;
        private System.Windows.Forms.TextBox txttenlp;
        private System.Windows.Forms.TextBox txtgiatien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewbangloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giatien;
    }
}