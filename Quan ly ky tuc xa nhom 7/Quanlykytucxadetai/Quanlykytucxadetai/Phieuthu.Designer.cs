namespace Quanlykytucxadetai
{
    partial class Phieuthu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PhieuthuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyKyTucXasqlDataSet1 = new Quanlykytucxadetai.QuanLyKyTucXasqlDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.btntaophieu = new System.Windows.Forms.Button();
            this.btnquayve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbomahd = new System.Windows.Forms.ComboBox();
            this.btnbophieu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PhieuthuTableAdapter = new Quanlykytucxadetai.QuanLyKyTucXasqlDataSet1TableAdapters.PhieuthuTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuthuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKyTucXasqlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PhieuthuBindingSource
            // 
            this.PhieuthuBindingSource.DataMember = "Phieuthu";
            this.PhieuthuBindingSource.DataSource = this.QuanLyKyTucXasqlDataSet1;
            // 
            // QuanLyKyTucXasqlDataSet1
            // 
            this.QuanLyKyTucXasqlDataSet1.DataSetName = "QuanLyKyTucXasqlDataSet1";
            this.QuanLyKyTucXasqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn mã khóa đơn cần lập phiếu thu";
            // 
            // btntaophieu
            // 
            this.btntaophieu.Location = new System.Drawing.Point(291, 105);
            this.btntaophieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntaophieu.Name = "btntaophieu";
            this.btntaophieu.Size = new System.Drawing.Size(112, 19);
            this.btntaophieu.TabIndex = 1;
            this.btntaophieu.Text = "Lâp phiếu thu tiền";
            this.btntaophieu.UseVisualStyleBackColor = true;
            this.btntaophieu.Click += new System.EventHandler(this.btntaophieu_Click);
            // 
            // btnquayve
            // 
            this.btnquayve.Location = new System.Drawing.Point(581, 168);
            this.btnquayve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnquayve.Name = "btnquayve";
            this.btnquayve.Size = new System.Drawing.Size(107, 21);
            this.btnquayve.TabIndex = 5;
            this.btnquayve.Text = "Quay về trang chủ";
            this.btnquayve.UseVisualStyleBackColor = true;
            this.btnquayve.Click += new System.EventHandler(this.btnquayve_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 194);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 70);
            this.dataGridView1.TabIndex = 6;
            // 
            // cbomahd
            // 
            this.cbomahd.FormattingEnabled = true;
            this.cbomahd.Location = new System.Drawing.Point(265, 71);
            this.cbomahd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbomahd.Name = "cbomahd";
            this.cbomahd.Size = new System.Drawing.Size(165, 21);
            this.cbomahd.TabIndex = 7;
            // 
            // btnbophieu
            // 
            this.btnbophieu.Location = new System.Drawing.Point(291, 136);
            this.btnbophieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbophieu.Name = "btnbophieu";
            this.btnbophieu.Size = new System.Drawing.Size(112, 19);
            this.btnbophieu.TabIndex = 8;
            this.btnbophieu.Text = "Bỏ phiếu thu tiền";
            this.btnbophieu.UseVisualStyleBackColor = true;
            this.btnbophieu.Click += new System.EventHandler(this.btnbophieu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 19);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xuất phiếu thu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhieuthuTableAdapter
            // 
            this.PhieuthuTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Viewphieuthu";
            reportDataSource1.Value = this.PhieuthuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quanlykytucxadetai.Reportphieuthu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 270);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(679, 328);
            this.reportViewer1.TabIndex = 10;
            // 
            // Phieuthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(700, 607);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbophieu);
            this.Controls.Add(this.cbomahd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnquayve);
            this.Controls.Add(this.btntaophieu);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Phieuthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu thu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Phieuthu_FormClosed);
            this.Load += new System.EventHandler(this.Phieuthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuthuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKyTucXasqlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntaophieu;
        private System.Windows.Forms.Button btnquayve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbomahd;
        private System.Windows.Forms.Button btnbophieu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource PhieuthuBindingSource;
        private QuanLyKyTucXasqlDataSet1 QuanLyKyTucXasqlDataSet1;
        private QuanLyKyTucXasqlDataSet1TableAdapters.PhieuthuTableAdapter PhieuthuTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}