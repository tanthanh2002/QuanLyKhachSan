namespace HotelManagement.GUI
{
    partial class fTakeFeedback
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGhiNhan = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNoiDung = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDiem = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMaPhieuDatPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMaKhachHang = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridViewDS = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Depth = 0;
            this.txt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt.Location = new System.Drawing.Point(629, 112);
            this.txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(111, 19);
            this.txt.TabIndex = 3;
            this.txt.Text = "Mã khách hàng";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(48, 323);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(65, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Nội dung";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(501, 172);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(1, 0);
            this.materialLabel3.TabIndex = 5;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(629, 198);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(144, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Mã phiếu đặt phòng";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(629, 277);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(38, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Điểm";
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGhiNhan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGhiNhan.Depth = 0;
            this.btnGhiNhan.HighEmphasis = true;
            this.btnGhiNhan.Icon = null;
            this.btnGhiNhan.Location = new System.Drawing.Point(850, 434);
            this.btnGhiNhan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGhiNhan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGhiNhan.Size = new System.Drawing.Size(91, 36);
            this.btnGhiNhan.TabIndex = 9;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGhiNhan.UseAccentColor = false;
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(756, 90);
            this.materialTextBox1.MaximumSize = new System.Drawing.Size(100, 50);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(0, 50);
            this.materialTextBox1.TabIndex = 10;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.AnimateReadOnly = false;
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoiDung.Depth = 0;
            this.txtNoiDung.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoiDung.LeadingIcon = null;
            this.txtNoiDung.Location = new System.Drawing.Point(51, 361);
            this.txtNoiDung.MaxLength = 200;
            this.txtNoiDung.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoiDung.Multiline = false;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(903, 50);
            this.txtNoiDung.TabIndex = 8;
            this.txtNoiDung.Text = "";
            this.txtNoiDung.TrailingIcon = null;
            // 
            // txtDiem
            // 
            this.txtDiem.AnimateReadOnly = false;
            this.txtDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiem.Depth = 0;
            this.txtDiem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiem.LeadingIcon = null;
            this.txtDiem.Location = new System.Drawing.Point(794, 246);
            this.txtDiem.MaxLength = 50;
            this.txtDiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiem.Multiline = false;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(160, 50);
            this.txtDiem.TabIndex = 13;
            this.txtDiem.Text = "";
            this.txtDiem.TrailingIcon = null;
            // 
            // txtMaPhieuDatPhong
            // 
            this.txtMaPhieuDatPhong.AnimateReadOnly = false;
            this.txtMaPhieuDatPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuDatPhong.Depth = 0;
            this.txtMaPhieuDatPhong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaPhieuDatPhong.LeadingIcon = null;
            this.txtMaPhieuDatPhong.Location = new System.Drawing.Point(794, 167);
            this.txtMaPhieuDatPhong.MaxLength = 50;
            this.txtMaPhieuDatPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaPhieuDatPhong.Multiline = false;
            this.txtMaPhieuDatPhong.Name = "txtMaPhieuDatPhong";
            this.txtMaPhieuDatPhong.Size = new System.Drawing.Size(160, 50);
            this.txtMaPhieuDatPhong.TabIndex = 12;
            this.txtMaPhieuDatPhong.Text = "";
            this.txtMaPhieuDatPhong.TrailingIcon = null;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.AnimateReadOnly = false;
            this.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKhachHang.Depth = 0;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaKhachHang.LeadingIcon = null;
            this.txtMaKhachHang.Location = new System.Drawing.Point(794, 81);
            this.txtMaKhachHang.MaxLength = 50;
            this.txtMaKhachHang.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaKhachHang.Multiline = false;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(160, 50);
            this.txtMaKhachHang.TabIndex = 11;
            this.txtMaKhachHang.Text = "";
            this.txtMaKhachHang.TrailingIcon = null;
            // 
            // dataGridViewDS
            // 
            this.dataGridViewDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.SoLuong});
            this.dataGridViewDS.Location = new System.Drawing.Point(51, 90);
            this.dataGridViewDS.Name = "dataGridViewDS";
            this.dataGridViewDS.RowHeadersWidth = 51;
            this.dataGridViewDS.RowTemplate.Height = 24;
            this.dataGridViewDS.Size = new System.Drawing.Size(561, 211);
            this.dataGridViewDS.TabIndex = 14;
            // 
            // MaDV
            // 
            this.MaDV.HeaderText = "MaDV";
            this.MaDV.MinimumWidth = 6;
            this.MaDV.Name = "MaDV";
            this.MaDV.Width = 125;
            // 
            // TenDV
            // 
            this.TenDV.HeaderText = "TenDV";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            this.TenDV.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // fTakeFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.dataGridViewDS);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtMaPhieuDatPhong);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.btnGhiNhan);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label3);
            this.Name = "fTakeFeedback";
            this.Text = "Ghi nhận phản hồi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialLabel txt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnGhiNhan;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox txtNoiDung;
        private MaterialSkin.Controls.MaterialTextBox txtDiem;
        private MaterialSkin.Controls.MaterialTextBox txtMaPhieuDatPhong;
        private MaterialSkin.Controls.MaterialTextBox txtMaKhachHang;
        private System.Windows.Forms.DataGridView dataGridViewDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}