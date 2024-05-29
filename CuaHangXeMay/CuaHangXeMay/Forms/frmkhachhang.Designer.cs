namespace CuaHangXeMay.Forms
{
    partial class frmkhachhang
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
            this.btdong = new System.Windows.Forms.Button();
            this.btboqua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.gridkhachhang = new System.Windows.Forms.DataGridView();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.lbdienthoai = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbtenkhach = new System.Windows.Forms.Label();
            this.lbmakhach = new System.Windows.Forms.Label();
            this.lbdanhmuckhachhang = new System.Windows.Forms.Label();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btdong
            // 
            this.btdong.Location = new System.Drawing.Point(587, 373);
            this.btdong.Margin = new System.Windows.Forms.Padding(2);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(52, 19);
            this.btdong.TabIndex = 31;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // btboqua
            // 
            this.btboqua.Location = new System.Drawing.Point(499, 374);
            this.btboqua.Margin = new System.Windows.Forms.Padding(2);
            this.btboqua.Name = "btboqua";
            this.btboqua.Size = new System.Drawing.Size(56, 19);
            this.btboqua.TabIndex = 30;
            this.btboqua.Text = "Bỏ qua";
            this.btboqua.UseVisualStyleBackColor = true;
            this.btboqua.Click += new System.EventHandler(this.btboqua_Click);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(411, 374);
            this.btluu.Margin = new System.Windows.Forms.Padding(2);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(56, 19);
            this.btluu.TabIndex = 29;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(324, 374);
            this.btsua.Margin = new System.Windows.Forms.Padding(2);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(56, 19);
            this.btsua.TabIndex = 28;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(241, 374);
            this.btxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 19);
            this.btxoa.TabIndex = 27;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(153, 375);
            this.btthem.Margin = new System.Windows.Forms.Padding(2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(55, 18);
            this.btthem.TabIndex = 26;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // gridkhachhang
            // 
            this.gridkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridkhachhang.Location = new System.Drawing.Point(153, 176);
            this.gridkhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.gridkhachhang.Name = "gridkhachhang";
            this.gridkhachhang.RowHeadersWidth = 51;
            this.gridkhachhang.RowTemplate.Height = 24;
            this.gridkhachhang.Size = new System.Drawing.Size(508, 174);
            this.gridkhachhang.TabIndex = 25;
            this.gridkhachhang.Click += new System.EventHandler(this.gridkhachhang_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(523, 92);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(76, 20);
            this.txtdiachi.TabIndex = 23;
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(222, 130);
            this.txttenkhach.Margin = new System.Windows.Forms.Padding(2);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(76, 20);
            this.txttenkhach.TabIndex = 22;
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(222, 92);
            this.txtmakhach.Margin = new System.Windows.Forms.Padding(2);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(76, 20);
            this.txtmakhach.TabIndex = 21;
            // 
            // lbdienthoai
            // 
            this.lbdienthoai.AutoSize = true;
            this.lbdienthoai.Location = new System.Drawing.Point(453, 135);
            this.lbdienthoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdienthoai.Name = "lbdienthoai";
            this.lbdienthoai.Size = new System.Drawing.Size(55, 13);
            this.lbdienthoai.TabIndex = 20;
            this.lbdienthoai.Text = "Điện thoại";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(451, 97);
            this.lbdiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(40, 13);
            this.lbdiachi.TabIndex = 19;
            this.lbdiachi.Text = "Địa chỉ";
            // 
            // lbtenkhach
            // 
            this.lbtenkhach.AutoSize = true;
            this.lbtenkhach.Location = new System.Drawing.Point(142, 136);
            this.lbtenkhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtenkhach.Name = "lbtenkhach";
            this.lbtenkhach.Size = new System.Drawing.Size(59, 13);
            this.lbtenkhach.TabIndex = 18;
            this.lbtenkhach.Text = "Tên khách";
            // 
            // lbmakhach
            // 
            this.lbmakhach.AutoSize = true;
            this.lbmakhach.Location = new System.Drawing.Point(140, 98);
            this.lbmakhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmakhach.Name = "lbmakhach";
            this.lbmakhach.Size = new System.Drawing.Size(55, 13);
            this.lbmakhach.TabIndex = 17;
            this.lbmakhach.Text = "Mã khách";
            // 
            // lbdanhmuckhachhang
            // 
            this.lbdanhmuckhachhang.AutoSize = true;
            this.lbdanhmuckhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbdanhmuckhachhang.Location = new System.Drawing.Point(278, 45);
            this.lbdanhmuckhachhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdanhmuckhachhang.Name = "lbdanhmuckhachhang";
            this.lbdanhmuckhachhang.Size = new System.Drawing.Size(242, 24);
            this.lbdanhmuckhachhang.TabIndex = 16;
            this.lbdanhmuckhachhang.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(523, 135);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(100, 20);
            this.mskdienthoai.TabIndex = 32;
            // 
            // frmkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.btboqua);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.gridkhachhang);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenkhach);
            this.Controls.Add(this.txtmakhach);
            this.Controls.Add(this.lbdienthoai);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.lbtenkhach);
            this.Controls.Add(this.lbmakhach);
            this.Controls.Add(this.lbdanhmuckhachhang);
            this.Name = "frmkhachhang";
            this.Text = "Danh mục Khách hàng";
            this.Load += new System.EventHandler(this.frmkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.Button btboqua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView gridkhachhang;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.Label lbdienthoai;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbtenkhach;
        private System.Windows.Forms.Label lbmakhach;
        private System.Windows.Forms.Label lbdanhmuckhachhang;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
    }
}