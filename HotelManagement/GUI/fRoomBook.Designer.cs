namespace HotelManagement.GUI
{
    partial class fRoomBook
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDatPhong = new MaterialSkin.Controls.MaterialButton();
            this.txtTenKhachHang = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDiaChi = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSoDienThoai = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoFax = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCCCD = new MaterialSkin.Controls.MaterialTextBox();
            this.txtYeuCauDacBiet = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoDemLuuTru = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNgayDen = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(153, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(156, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Thông tin khách hàng";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(621, 78);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Thông tin phòng đặt";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(39, 270);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Địa chỉ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(39, 206);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(95, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Số điện thoại";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(39, 140);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(47, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Họ tên";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDatPhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDatPhong.Depth = 0;
            this.btnDatPhong.HighEmphasis = true;
            this.btnDatPhong.Icon = null;
            this.btnDatPhong.Location = new System.Drawing.Point(752, 385);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDatPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDatPhong.Size = new System.Drawing.Size(104, 36);
            this.btnDatPhong.TabIndex = 5;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDatPhong.UseAccentColor = false;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.AnimateReadOnly = false;
            this.txtTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKhachHang.Depth = 0;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenKhachHang.LeadingIcon = null;
            this.txtTenKhachHang.Location = new System.Drawing.Point(205, 109);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhachHang.MaxLength = 50;
            this.txtTenKhachHang.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenKhachHang.Multiline = false;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(247, 50);
            this.txtTenKhachHang.TabIndex = 6;
            this.txtTenKhachHang.Text = "";
            this.txtTenKhachHang.TrailingIcon = null;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AnimateReadOnly = false;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Depth = 0;
            this.txtDiaChi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiaChi.LeadingIcon = null;
            this.txtDiaChi.Location = new System.Drawing.Point(205, 239);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.MaxLength = 50;
            this.txtDiaChi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(247, 50);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.Text = "";
            this.txtDiaChi.TrailingIcon = null;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.AnimateReadOnly = false;
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoDienThoai.Depth = 0;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoDienThoai.LeadingIcon = null;
            this.txtSoDienThoai.Location = new System.Drawing.Point(205, 175);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDienThoai.MaxLength = 50;
            this.txtSoDienThoai.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoDienThoai.Multiline = false;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(247, 50);
            this.txtSoDienThoai.TabIndex = 8;
            this.txtSoDienThoai.Text = "";
            this.txtSoDienThoai.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(36, 469);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(42, 19);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "CCCD";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(36, 338);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(50, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Số Fax";
            // 
            // txtSoFax
            // 
            this.txtSoFax.AnimateReadOnly = false;
            this.txtSoFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoFax.Depth = 0;
            this.txtSoFax.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoFax.LeadingIcon = null;
            this.txtSoFax.Location = new System.Drawing.Point(205, 307);
            this.txtSoFax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoFax.MaxLength = 50;
            this.txtSoFax.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoFax.Multiline = false;
            this.txtSoFax.Name = "txtSoFax";
            this.txtSoFax.Size = new System.Drawing.Size(247, 50);
            this.txtSoFax.TabIndex = 12;
            this.txtSoFax.Text = "";
            this.txtSoFax.TrailingIcon = null;
            // 
            // txtCCCD
            // 
            this.txtCCCD.AnimateReadOnly = false;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.Depth = 0;
            this.txtCCCD.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCCCD.LeadingIcon = null;
            this.txtCCCD.Location = new System.Drawing.Point(205, 438);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.MaxLength = 50;
            this.txtCCCD.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCCCD.Multiline = false;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(247, 50);
            this.txtCCCD.TabIndex = 13;
            this.txtCCCD.Text = "";
            this.txtCCCD.TrailingIcon = null;
            // 
            // txtYeuCauDacBiet
            // 
            this.txtYeuCauDacBiet.AnimateReadOnly = false;
            this.txtYeuCauDacBiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYeuCauDacBiet.Depth = 0;
            this.txtYeuCauDacBiet.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtYeuCauDacBiet.LeadingIcon = null;
            this.txtYeuCauDacBiet.Location = new System.Drawing.Point(701, 128);
            this.txtYeuCauDacBiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYeuCauDacBiet.MaxLength = 50;
            this.txtYeuCauDacBiet.MouseState = MaterialSkin.MouseState.OUT;
            this.txtYeuCauDacBiet.Multiline = false;
            this.txtYeuCauDacBiet.Name = "txtYeuCauDacBiet";
            this.txtYeuCauDacBiet.Size = new System.Drawing.Size(250, 50);
            this.txtYeuCauDacBiet.TabIndex = 15;
            this.txtYeuCauDacBiet.Text = "";
            this.txtYeuCauDacBiet.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(533, 159);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(119, 19);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Yêu cầu đặc biệt";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(533, 238);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(106, 19);
            this.materialLabel9.TabIndex = 16;
            this.materialLabel9.Text = "Số đêm lưu trú";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(533, 306);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(69, 19);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Ngày đến";
            // 
            // txtSoDemLuuTru
            // 
            this.txtSoDemLuuTru.AnimateReadOnly = false;
            this.txtSoDemLuuTru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoDemLuuTru.Depth = 0;
            this.txtSoDemLuuTru.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoDemLuuTru.LeadingIcon = null;
            this.txtSoDemLuuTru.Location = new System.Drawing.Point(701, 207);
            this.txtSoDemLuuTru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDemLuuTru.MaxLength = 50;
            this.txtSoDemLuuTru.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoDemLuuTru.Multiline = false;
            this.txtSoDemLuuTru.Name = "txtSoDemLuuTru";
            this.txtSoDemLuuTru.Size = new System.Drawing.Size(250, 50);
            this.txtSoDemLuuTru.TabIndex = 17;
            this.txtSoDemLuuTru.Text = "";
            this.txtSoDemLuuTru.TrailingIcon = null;
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Location = new System.Drawing.Point(701, 302);
            this.txtNgayDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(250, 22);
            this.txtNgayDen.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(205, 372);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 50);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(36, 403);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(41, 19);
            this.materialLabel11.TabIndex = 21;
            this.materialLabel11.Text = "Email";
            // 
            // fRoomBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNgayDen);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.txtSoDemLuuTru);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.txtYeuCauDacBiet);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtSoFax);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fRoomBook";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Đặt phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnDatPhong;
        private MaterialSkin.Controls.MaterialTextBox txtTenKhachHang;
        private MaterialSkin.Controls.MaterialTextBox txtDiaChi;
        private MaterialSkin.Controls.MaterialTextBox txtSoDienThoai;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txtSoFax;
        private MaterialSkin.Controls.MaterialTextBox txtCCCD;
        private MaterialSkin.Controls.MaterialTextBox txtYeuCauDacBiet;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox txtSoDemLuuTru;
        private System.Windows.Forms.DateTimePicker txtNgayDen;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
    }
}