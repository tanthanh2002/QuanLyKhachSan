namespace HotelManagement.GUI
{
    partial class fOnlinePayment
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
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnThanhCong = new MaterialSkin.Controls.MaterialButton();
            this.txtMaDatPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSoTienDaThanhToan = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTongTien = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNoiDungThanhToan = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(62, 132);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đặt phòng";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(62, 272);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(143, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Tiền cần thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(62, 200);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(62, 340);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Nội dung thanh toán";
            // 
            // btnThanhCong
            // 
            this.btnThanhCong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThanhCong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThanhCong.Depth = 0;
            this.btnThanhCong.HighEmphasis = true;
            this.btnThanhCong.Icon = null;
            this.btnThanhCong.Location = new System.Drawing.Point(408, 416);
            this.btnThanhCong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThanhCong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThanhCong.Name = "btnThanhCong";
            this.btnThanhCong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThanhCong.Size = new System.Drawing.Size(116, 36);
            this.btnThanhCong.TabIndex = 4;
            this.btnThanhCong.Text = "Thành công";
            this.btnThanhCong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThanhCong.UseAccentColor = false;
            this.btnThanhCong.UseVisualStyleBackColor = true;
            this.btnThanhCong.Click += new System.EventHandler(this.btnThanhCong_Click);
            // 
            // txtMaDatPhong
            // 
            this.txtMaDatPhong.AnimateReadOnly = false;
            this.txtMaDatPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaDatPhong.Depth = 0;
            this.txtMaDatPhong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaDatPhong.LeadingIcon = null;
            this.txtMaDatPhong.Location = new System.Drawing.Point(290, 101);
            this.txtMaDatPhong.MaxLength = 50;
            this.txtMaDatPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaDatPhong.Multiline = false;
            this.txtMaDatPhong.Name = "txtMaDatPhong";
            this.txtMaDatPhong.Size = new System.Drawing.Size(234, 50);
            this.txtMaDatPhong.TabIndex = 5;
            this.txtMaDatPhong.Text = "";
            this.txtMaDatPhong.TrailingIcon = null;
            // 
            // txtSoTienDaThanhToan
            // 
            this.txtSoTienDaThanhToan.AnimateReadOnly = false;
            this.txtSoTienDaThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTienDaThanhToan.Depth = 0;
            this.txtSoTienDaThanhToan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoTienDaThanhToan.LeadingIcon = null;
            this.txtSoTienDaThanhToan.Location = new System.Drawing.Point(290, 241);
            this.txtSoTienDaThanhToan.MaxLength = 50;
            this.txtSoTienDaThanhToan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoTienDaThanhToan.Multiline = false;
            this.txtSoTienDaThanhToan.Name = "txtSoTienDaThanhToan";
            this.txtSoTienDaThanhToan.Size = new System.Drawing.Size(234, 50);
            this.txtSoTienDaThanhToan.TabIndex = 6;
            this.txtSoTienDaThanhToan.Text = "";
            this.txtSoTienDaThanhToan.TrailingIcon = null;
            // 
            // txtTongTien
            // 
            this.txtTongTien.AnimateReadOnly = false;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Depth = 0;
            this.txtTongTien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTongTien.LeadingIcon = null;
            this.txtTongTien.Location = new System.Drawing.Point(290, 169);
            this.txtTongTien.MaxLength = 50;
            this.txtTongTien.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTongTien.Multiline = false;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(234, 50);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.Text = "";
            this.txtTongTien.TrailingIcon = null;
            // 
            // txtNoiDungThanhToan
            // 
            this.txtNoiDungThanhToan.AnimateReadOnly = false;
            this.txtNoiDungThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoiDungThanhToan.Depth = 0;
            this.txtNoiDungThanhToan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoiDungThanhToan.LeadingIcon = null;
            this.txtNoiDungThanhToan.Location = new System.Drawing.Point(290, 309);
            this.txtNoiDungThanhToan.MaxLength = 50;
            this.txtNoiDungThanhToan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoiDungThanhToan.Multiline = false;
            this.txtNoiDungThanhToan.Name = "txtNoiDungThanhToan";
            this.txtNoiDungThanhToan.Size = new System.Drawing.Size(234, 50);
            this.txtNoiDungThanhToan.TabIndex = 8;
            this.txtNoiDungThanhToan.Text = "";
            this.txtNoiDungThanhToan.TrailingIcon = null;
            // 
            // fOnlinePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.txtNoiDungThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtSoTienDaThanhToan);
            this.Controls.Add(this.txtMaDatPhong);
            this.Controls.Add(this.btnThanhCong);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.label1);
            this.Name = "fOnlinePayment";
            this.Text = "Thanh toán cọc Online";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnThanhCong;
        private MaterialSkin.Controls.MaterialTextBox txtMaDatPhong;
        private MaterialSkin.Controls.MaterialTextBox txtSoTienDaThanhToan;
        private MaterialSkin.Controls.MaterialTextBox txtTongTien;
        private MaterialSkin.Controls.MaterialTextBox txtNoiDungThanhToan;
    }
}