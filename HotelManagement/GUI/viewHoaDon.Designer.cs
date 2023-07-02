namespace HotelManagement.GUI
{
    partial class viewHoaDon
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
            this.lblMaPhieuDatPhong = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.lblTienDichVu = new System.Windows.Forms.Label();
            this.lblTienThucPham = new System.Windows.Forms.Label();
            this.lblTienHuHong = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblDaTra = new System.Windows.Forms.Label();
            this.txtConLai = new System.Windows.Forms.Label();
            this.btnThanhToan = new MaterialSkin.Controls.MaterialButton();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblKeToan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOÁ ĐƠN";
            // 
            // lblMaPhieuDatPhong
            // 
            this.lblMaPhieuDatPhong.AutoSize = true;
            this.lblMaPhieuDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuDatPhong.Location = new System.Drawing.Point(25, 92);
            this.lblMaPhieuDatPhong.Name = "lblMaPhieuDatPhong";
            this.lblMaPhieuDatPhong.Size = new System.Drawing.Size(175, 20);
            this.lblMaPhieuDatPhong.TabIndex = 2;
            this.lblMaPhieuDatPhong.Text = "Mã Phiếu Đặt Phòng: ...";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(25, 132);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(143, 20);
            this.lblTenKhachHang.TabIndex = 2;
            this.lblTenKhachHang.Text = "Tên khách hàng: ...";
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienPhong.Location = new System.Drawing.Point(25, 172);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(108, 20);
            this.lblTienPhong.TabIndex = 2;
            this.lblTienPhong.Text = "Tiền phòng: ...";
            this.lblTienPhong.Click += new System.EventHandler(this.lblTienPhong_Click);
            // 
            // lblTienDichVu
            // 
            this.lblTienDichVu.AutoSize = true;
            this.lblTienDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDichVu.Location = new System.Drawing.Point(25, 212);
            this.lblTienDichVu.Name = "lblTienDichVu";
            this.lblTienDichVu.Size = new System.Drawing.Size(112, 20);
            this.lblTienDichVu.TabIndex = 2;
            this.lblTienDichVu.Text = "Tiền dịch vụ: ...";
            this.lblTienDichVu.Click += new System.EventHandler(this.lblTienPhong_Click);
            // 
            // lblTienThucPham
            // 
            this.lblTienThucPham.AutoSize = true;
            this.lblTienThucPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThucPham.Location = new System.Drawing.Point(25, 252);
            this.lblTienThucPham.Name = "lblTienThucPham";
            this.lblTienThucPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTienThucPham.Size = new System.Drawing.Size(138, 20);
            this.lblTienThucPham.TabIndex = 2;
            this.lblTienThucPham.Text = "Tiền thực phẩm: ...";
            this.lblTienThucPham.Click += new System.EventHandler(this.lblTienPhong_Click);
            // 
            // lblTienHuHong
            // 
            this.lblTienHuHong.AutoSize = true;
            this.lblTienHuHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienHuHong.Location = new System.Drawing.Point(25, 292);
            this.lblTienHuHong.Name = "lblTienHuHong";
            this.lblTienHuHong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTienHuHong.Size = new System.Drawing.Size(178, 20);
            this.lblTienHuHong.TabIndex = 2;
            this.lblTienHuHong.Text = "Tiền hư hỏng nội thất: ...";
            this.lblTienHuHong.Click += new System.EventHandler(this.lblTienPhong_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(25, 332);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTongTien.Size = new System.Drawing.Size(95, 20);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng tiền: ...";
            this.lblTongTien.Click += new System.EventHandler(this.lblTienPhong_Click);
            // 
            // lblDaTra
            // 
            this.lblDaTra.AutoSize = true;
            this.lblDaTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaTra.Location = new System.Drawing.Point(25, 412);
            this.lblDaTra.Name = "lblDaTra";
            this.lblDaTra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDaTra.Size = new System.Drawing.Size(182, 20);
            this.lblDaTra.TabIndex = 2;
            this.lblDaTra.Text = "Số tiền đã thanh toán: ...";
            this.lblDaTra.Click += new System.EventHandler(this.lblTienPhong_Click);
            // 
            // txtConLai
            // 
            this.txtConLai.AutoSize = true;
            this.txtConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConLai.Location = new System.Drawing.Point(25, 452);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConLai.Size = new System.Drawing.Size(77, 20);
            this.txtConLai.TabIndex = 2;
            this.txtConLai.Text = "Còn lại: ...";
            this.txtConLai.Click += new System.EventHandler(this.lblTienPhong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThanhToan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThanhToan.Depth = 0;
            this.btnThanhToan.HighEmphasis = true;
            this.btnThanhToan.Icon = null;
            this.btnThanhToan.Location = new System.Drawing.Point(442, 92);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThanhToan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThanhToan.Size = new System.Drawing.Size(114, 36);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThanhToan.UseAccentColor = false;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(25, 372);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTinhTrang.Size = new System.Drawing.Size(100, 20);
            this.lblTinhTrang.TabIndex = 2;
            this.lblTinhTrang.Text = "Tình trạng: ...";
            this.lblTinhTrang.Click += new System.EventHandler(this.lblTienPhong_Click);
            // 
            // lblKeToan
            // 
            this.lblKeToan.AutoSize = true;
            this.lblKeToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeToan.Location = new System.Drawing.Point(25, 492);
            this.lblKeToan.Name = "lblKeToan";
            this.lblKeToan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKeToan.Size = new System.Drawing.Size(72, 20);
            this.lblKeToan.TabIndex = 2;
            this.lblKeToan.Text = "Kế toán: ";
            this.lblKeToan.Click += new System.EventHandler(this.lblTienPhong_Click);
            // 
            // viewHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 561);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblKeToan);
            this.Controls.Add(this.txtConLai);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblDaTra);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTienHuHong);
            this.Controls.Add(this.lblTienThucPham);
            this.Controls.Add(this.lblTienDichVu);
            this.Controls.Add(this.lblTienPhong);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblMaPhieuDatPhong);
            this.Controls.Add(this.label1);
            this.Name = "viewHoaDon";
            this.Text = "Thông Tin Hoá Đơn";
            this.Load += new System.EventHandler(this.viewHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaPhieuDatPhong;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label lblTienDichVu;
        private System.Windows.Forms.Label lblTienThucPham;
        private System.Windows.Forms.Label lblTienHuHong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblDaTra;
        private System.Windows.Forms.Label txtConLai;
        private MaterialSkin.Controls.MaterialButton btnThanhToan;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblKeToan;
    }
}