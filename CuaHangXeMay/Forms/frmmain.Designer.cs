namespace CuaHangXeMay
{
    partial class frmmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnudanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnukhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunhacungcap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadonnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhoadonban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaonhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaoban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaodoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutknhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutkban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudanhmuc,
            this.mnuhoadon,
            this.mnubaocao,
            this.mnutimkiem,
            this.mnuthoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnudanhmuc
            // 
            this.mnudanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnunhanvien,
            this.mnukhachhang,
            this.mnusanpham,
            this.mnunhacungcap});
            this.mnudanhmuc.Name = "mnudanhmuc";
            this.mnudanhmuc.Size = new System.Drawing.Size(74, 20);
            this.mnudanhmuc.Text = "Danh mục";
            // 
            // mnunhanvien
            // 
            this.mnunhanvien.Name = "mnunhanvien";
            this.mnunhanvien.Size = new System.Drawing.Size(180, 22);
            this.mnunhanvien.Text = "Nhân viên";
            this.mnunhanvien.Click += new System.EventHandler(this.mnunhanvien_Click);
            // 
            // mnukhachhang
            // 
            this.mnukhachhang.Name = "mnukhachhang";
            this.mnukhachhang.Size = new System.Drawing.Size(180, 22);
            this.mnukhachhang.Text = "Khách hàng";
            // 
            // mnusanpham
            // 
            this.mnusanpham.Name = "mnusanpham";
            this.mnusanpham.Size = new System.Drawing.Size(180, 22);
            this.mnusanpham.Text = "Sản phẩm";
            // 
            // mnunhacungcap
            // 
            this.mnunhacungcap.Name = "mnunhacungcap";
            this.mnunhacungcap.Size = new System.Drawing.Size(180, 22);
            this.mnunhacungcap.Text = "Nhà cung cấp";
            // 
            // mnuhoadon
            // 
            this.mnuhoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhoadonnhap,
            this.mnuhoadonban});
            this.mnuhoadon.Name = "mnuhoadon";
            this.mnuhoadon.Size = new System.Drawing.Size(65, 20);
            this.mnuhoadon.Text = "Hóa đơn";
            // 
            // mnuhoadonnhap
            // 
            this.mnuhoadonnhap.Name = "mnuhoadonnhap";
            this.mnuhoadonnhap.Size = new System.Drawing.Size(180, 22);
            this.mnuhoadonnhap.Text = "Hóa đơn nhập";
            // 
            // mnuhoadonban
            // 
            this.mnuhoadonban.Name = "mnuhoadonban";
            this.mnuhoadonban.Size = new System.Drawing.Size(180, 22);
            this.mnuhoadonban.Text = "Hóa đơn bán";
            // 
            // mnubaocao
            // 
            this.mnubaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubaocaonhap,
            this.mnubaocaoban,
            this.mnubaocaodoanhthu});
            this.mnubaocao.Name = "mnubaocao";
            this.mnubaocao.Size = new System.Drawing.Size(61, 20);
            this.mnubaocao.Text = "Báo cáo";
            // 
            // mnubaocaonhap
            // 
            this.mnubaocaonhap.Name = "mnubaocaonhap";
            this.mnubaocaonhap.Size = new System.Drawing.Size(180, 22);
            this.mnubaocaonhap.Text = "Báo cáo nhập hàng";
            // 
            // mnubaocaoban
            // 
            this.mnubaocaoban.Name = "mnubaocaoban";
            this.mnubaocaoban.Size = new System.Drawing.Size(180, 22);
            this.mnubaocaoban.Text = "Báo cáo bán hàng";
            // 
            // mnubaocaodoanhthu
            // 
            this.mnubaocaodoanhthu.Name = "mnubaocaodoanhthu";
            this.mnubaocaodoanhthu.Size = new System.Drawing.Size(180, 22);
            this.mnubaocaodoanhthu.Text = "Báo cáo doanh thu";
            // 
            // mnutimkiem
            // 
            this.mnutimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutknhap,
            this.mnutkban});
            this.mnutimkiem.Name = "mnutimkiem";
            this.mnutimkiem.Size = new System.Drawing.Size(68, 20);
            this.mnutimkiem.Text = "Tìm kiếm";
            // 
            // mnutknhap
            // 
            this.mnutknhap.Name = "mnutknhap";
            this.mnutknhap.Size = new System.Drawing.Size(200, 22);
            this.mnutknhap.Text = "Tìm kiếm hóa đơn nhập";
            // 
            // mnutkban
            // 
            this.mnutkban.Name = "mnutkban";
            this.mnutkban.Size = new System.Drawing.Size(200, 22);
            this.mnutkban.Text = "Tìm kiếm hóa đơn bán";
            // 
            // mnuthoat
            // 
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(49, 20);
            this.mnuthoat.Text = "Thoát";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.Text = "Cửa hàng xe máy";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnunhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnukhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnusanpham;
        private System.Windows.Forms.ToolStripMenuItem mnunhacungcap;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadonnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuhoadonban;
        private System.Windows.Forms.ToolStripMenuItem mnubaocao;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaonhap;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaoban;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaodoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnutimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnutknhap;
        private System.Windows.Forms.ToolStripMenuItem mnutkban;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
    }
}

