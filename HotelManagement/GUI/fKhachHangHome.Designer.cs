
namespace HotelManagement.GUI
{
    partial class fKhachHangHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKhachHangHome));
            this.tabTour = new System.Windows.Forms.TabPage();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tour = new System.Windows.Forms.DataGridViewButtonColumn();
            this.checkout = new System.Windows.Forms.DataGridViewButtonColumn();
            this.phanHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chinhSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.DSPhongDaCheckin = new System.Windows.Forms.DataGridView();
            this.tabDatPhong = new System.Windows.Forms.TabPage();
            this.phongCuaToi = new System.Windows.Forms.TabPage();
            this.thongTinTaiKhoan = new System.Windows.Forms.TabPage();
            this.tabKhachHang = new MaterialSkin.Controls.MaterialTabControl();
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.tabDVCuaToi = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabDSDV = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabDVcon = new MaterialSkin.Controls.MaterialTabControl();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.maphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikhoaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tinhtrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhongDaCheckin)).BeginInit();
            this.tabDatPhong.SuspendLayout();
            this.thongTinTaiKhoan.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            this.tabDVCuaToi.SuspendLayout();
            this.tabDSDV.SuspendLayout();
            this.tabDVcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTour
            // 
            this.tabTour.ImageKey = "destination.png";
            this.tabTour.Location = new System.Drawing.Point(4, 39);
            this.tabTour.Name = "tabTour";
            this.tabTour.Padding = new System.Windows.Forms.Padding(3);
            this.tabTour.Size = new System.Drawing.Size(1180, 473);
            this.tabTour.TabIndex = 4;
            this.tabTour.Text = "Tour";
            this.tabTour.UseVisualStyleBackColor = true;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(144, 15);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(301, 48);
            this.materialTextBox21.TabIndex = 2;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.Text = "Nhập mã phòng";
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(42, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mã phòng:";
            // 
            // tour
            // 
            this.tour.DataPropertyName = "maphong";
            this.tour.HeaderText = "Tour";
            this.tour.MinimumWidth = 6;
            this.tour.Name = "tour";
            this.tour.Text = "Tour";
            this.tour.UseColumnTextForButtonValue = true;
            this.tour.Width = 70;
            // 
            // checkout
            // 
            this.checkout.DataPropertyName = "maphong";
            this.checkout.HeaderText = "CheckOut";
            this.checkout.MinimumWidth = 6;
            this.checkout.Name = "checkout";
            this.checkout.Text = "CheckOut";
            this.checkout.UseColumnTextForButtonValue = true;
            this.checkout.Width = 70;
            // 
            // phanHoi
            // 
            this.phanHoi.DataPropertyName = "maphong";
            this.phanHoi.HeaderText = "Phản hồi";
            this.phanHoi.MinimumWidth = 6;
            this.phanHoi.Name = "phanHoi";
            this.phanHoi.Width = 70;
            // 
            // DichVu
            // 
            this.DichVu.DataPropertyName = "maphong";
            this.DichVu.HeaderText = "Dịch vụ";
            this.DichVu.MinimumWidth = 6;
            this.DichVu.Name = "DichVu";
            this.DichVu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DichVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DichVu.Text = "Dịch vụ";
            this.DichVu.UseColumnTextForButtonValue = true;
            this.DichVu.Width = 70;
            // 
            // chinhSua
            // 
            this.chinhSua.DataPropertyName = "maphong";
            this.chinhSua.HeaderText = "Chỉnh sửa";
            this.chinhSua.MinimumWidth = 6;
            this.chinhSua.Name = "chinhSua";
            this.chinhSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chinhSua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chinhSua.Text = "Chỉnh sửa";
            this.chinhSua.UseColumnTextForButtonValue = true;
            this.chinhSua.Width = 70;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.tabDVcon);
            this.tabDichVu.ImageKey = "hotel-bell.png";
            this.tabDichVu.Location = new System.Drawing.Point(4, 39);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichVu.Size = new System.Drawing.Size(1180, 473);
            this.tabDichVu.TabIndex = 3;
            this.tabDichVu.Text = "Dịch vụ";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // DSPhongDaCheckin
            // 
            this.DSPhongDaCheckin.AutoGenerateColumns = false;
            this.DSPhongDaCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSPhongDaCheckin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphongDataGridViewTextBoxColumn,
            this.sophongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.bikhoaDataGridViewCheckBoxColumn,
            this.tinhtrangDataGridViewTextBoxColumn,
            this.chinhSua,
            this.DichVu,
            this.phanHoi,
            this.checkout,
            this.tour});
            this.DSPhongDaCheckin.DataSource = this.phongBindingSource;
            this.DSPhongDaCheckin.Location = new System.Drawing.Point(26, 86);
            this.DSPhongDaCheckin.Name = "DSPhongDaCheckin";
            this.DSPhongDaCheckin.RowHeadersWidth = 51;
            this.DSPhongDaCheckin.RowTemplate.Height = 24;
            this.DSPhongDaCheckin.Size = new System.Drawing.Size(1133, 433);
            this.DSPhongDaCheckin.TabIndex = 5;
            // 
            // tabDatPhong
            // 
            this.tabDatPhong.Controls.Add(this.materialLabel4);
            this.tabDatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDatPhong.ImageKey = "booking.png";
            this.tabDatPhong.Location = new System.Drawing.Point(4, 39);
            this.tabDatPhong.Name = "tabDatPhong";
            this.tabDatPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatPhong.Size = new System.Drawing.Size(1180, 473);
            this.tabDatPhong.TabIndex = 0;
            this.tabDatPhong.Text = "Đặt phòng";
            this.tabDatPhong.UseVisualStyleBackColor = true;
            // 
            // phongCuaToi
            // 
            this.phongCuaToi.ImageKey = "bed.png";
            this.phongCuaToi.Location = new System.Drawing.Point(4, 39);
            this.phongCuaToi.Name = "phongCuaToi";
            this.phongCuaToi.Padding = new System.Windows.Forms.Padding(3);
            this.phongCuaToi.Size = new System.Drawing.Size(1180, 473);
            this.phongCuaToi.TabIndex = 2;
            this.phongCuaToi.Text = "Phòng của tôi";
            this.phongCuaToi.UseVisualStyleBackColor = true;
            this.phongCuaToi.Click += new System.EventHandler(this.phongCuaToi_Click);
            // 
            // thongTinTaiKhoan
            // 
            this.thongTinTaiKhoan.Controls.Add(this.DSPhongDaCheckin);
            this.thongTinTaiKhoan.Controls.Add(this.materialTextBox21);
            this.thongTinTaiKhoan.Controls.Add(this.materialLabel1);
            this.thongTinTaiKhoan.ImageKey = "user.png";
            this.thongTinTaiKhoan.Location = new System.Drawing.Point(4, 39);
            this.thongTinTaiKhoan.Name = "thongTinTaiKhoan";
            this.thongTinTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.thongTinTaiKhoan.Size = new System.Drawing.Size(1180, 473);
            this.thongTinTaiKhoan.TabIndex = 1;
            this.thongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.thongTinTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.tabDatPhong);
            this.tabKhachHang.Controls.Add(this.phongCuaToi);
            this.tabKhachHang.Controls.Add(this.tabDichVu);
            this.tabKhachHang.Controls.Add(this.tabTour);
            this.tabKhachHang.Controls.Add(this.thongTinTaiKhoan);
            this.tabKhachHang.Depth = 0;
            this.tabKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKhachHang.ImageList = this.icon;
            this.tabKhachHang.Location = new System.Drawing.Point(3, 64);
            this.tabKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabKhachHang.Multiline = true;
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.SelectedIndex = 0;
            this.tabKhachHang.Size = new System.Drawing.Size(1188, 516);
            this.tabKhachHang.TabIndex = 1;
            // 
            // icon
            // 
            this.icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon.ImageStream")));
            this.icon.TransparentColor = System.Drawing.Color.Transparent;
            this.icon.Images.SetKeyName(0, "search.png");
            this.icon.Images.SetKeyName(1, "booking.png");
            this.icon.Images.SetKeyName(2, "check-in.png");
            this.icon.Images.SetKeyName(3, "destination.png");
            this.icon.Images.SetKeyName(4, "hotel-bell.png");
            this.icon.Images.SetKeyName(5, "bed.png");
            this.icon.Images.SetKeyName(6, "user.png");
            this.icon.Images.SetKeyName(7, "list.png");
            this.icon.Images.SetKeyName(8, "shopping-list.png");
            // 
            // tabDVCuaToi
            // 
            this.tabDVCuaToi.Controls.Add(this.materialLabel3);
            this.tabDVCuaToi.ImageKey = "shopping-list.png";
            this.tabDVCuaToi.Location = new System.Drawing.Point(4, 39);
            this.tabDVCuaToi.Name = "tabDVCuaToi";
            this.tabDVCuaToi.Padding = new System.Windows.Forms.Padding(3);
            this.tabDVCuaToi.Size = new System.Drawing.Size(1166, 424);
            this.tabDVCuaToi.TabIndex = 1;
            this.tabDVCuaToi.Text = "Dịch vụ của tôi";
            this.tabDVCuaToi.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(448, 184);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(74, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "DV của tôi";
            // 
            // tabDSDV
            // 
            this.tabDSDV.Controls.Add(this.materialLabel2);
            this.tabDSDV.ImageKey = "list.png";
            this.tabDSDV.Location = new System.Drawing.Point(4, 39);
            this.tabDSDV.Name = "tabDSDV";
            this.tabDSDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSDV.Size = new System.Drawing.Size(1166, 424);
            this.tabDSDV.TabIndex = 0;
            this.tabDSDV.Text = "Danh sách dịch vụ";
            this.tabDSDV.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(361, 131);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "DS dịch vụ";
            // 
            // tabDVcon
            // 
            this.tabDVcon.Controls.Add(this.tabDSDV);
            this.tabDVcon.Controls.Add(this.tabDVCuaToi);
            this.tabDVcon.Depth = 0;
            this.tabDVcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDVcon.ImageList = this.icon;
            this.tabDVcon.Location = new System.Drawing.Point(3, 3);
            this.tabDVcon.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabDVcon.Multiline = true;
            this.tabDVcon.Name = "tabDVcon";
            this.tabDVcon.SelectedIndex = 0;
            this.tabDVcon.Size = new System.Drawing.Size(1174, 467);
            this.tabDVcon.TabIndex = 0;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(415, 207);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(61, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "xin chào";
            // 
            // maphongDataGridViewTextBoxColumn
            // 
            this.maphongDataGridViewTextBoxColumn.DataPropertyName = "maphong";
            this.maphongDataGridViewTextBoxColumn.HeaderText = "maphong";
            this.maphongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maphongDataGridViewTextBoxColumn.Name = "maphongDataGridViewTextBoxColumn";
            this.maphongDataGridViewTextBoxColumn.Width = 70;
            // 
            // sophongDataGridViewTextBoxColumn
            // 
            this.sophongDataGridViewTextBoxColumn.DataPropertyName = "sophong";
            this.sophongDataGridViewTextBoxColumn.HeaderText = "sophong";
            this.sophongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sophongDataGridViewTextBoxColumn.Name = "sophongDataGridViewTextBoxColumn";
            this.sophongDataGridViewTextBoxColumn.Width = 70;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 70;
            // 
            // bikhoaDataGridViewCheckBoxColumn
            // 
            this.bikhoaDataGridViewCheckBoxColumn.DataPropertyName = "bikhoa";
            this.bikhoaDataGridViewCheckBoxColumn.HeaderText = "bikhoa";
            this.bikhoaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.bikhoaDataGridViewCheckBoxColumn.Name = "bikhoaDataGridViewCheckBoxColumn";
            this.bikhoaDataGridViewCheckBoxColumn.Width = 70;
            // 
            // tinhtrangDataGridViewTextBoxColumn
            // 
            this.tinhtrangDataGridViewTextBoxColumn.DataPropertyName = "tinhtrang";
            this.tinhtrangDataGridViewTextBoxColumn.HeaderText = "tinhtrang";
            this.tinhtrangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhtrangDataGridViewTextBoxColumn.Name = "tinhtrangDataGridViewTextBoxColumn";
            this.tinhtrangDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataSource = typeof(HotelManagement.Phong);
            this.phongBindingSource.CurrentChanged += new System.EventHandler(this.phongBindingSource_CurrentChanged);
            // 
            // fKhachHangHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 583);
            this.Controls.Add(this.tabKhachHang);
            this.Name = "fKhachHangHome";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.fKhachHangHome_Load);
            this.tabDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSPhongDaCheckin)).EndInit();
            this.tabDatPhong.ResumeLayout(false);
            this.tabDatPhong.PerformLayout();
            this.thongTinTaiKhoan.ResumeLayout(false);
            this.thongTinTaiKhoan.PerformLayout();
            this.tabKhachHang.ResumeLayout(false);
            this.tabDVCuaToi.ResumeLayout(false);
            this.tabDVCuaToi.PerformLayout();
            this.tabDSDV.ResumeLayout(false);
            this.tabDSDV.PerformLayout();
            this.tabDVcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabTour;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn tour;
        private System.Windows.Forms.DataGridViewButtonColumn checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanHoi;
        private System.Windows.Forms.DataGridViewButtonColumn DichVu;
        private System.Windows.Forms.DataGridViewButtonColumn chinhSua;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DSPhongDaCheckin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bikhoaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TabPage tabDatPhong;
        private System.Windows.Forms.TabPage phongCuaToi;
        private System.Windows.Forms.TabPage thongTinTaiKhoan;
        private MaterialSkin.Controls.MaterialTabControl tabKhachHang;
        private System.Windows.Forms.ImageList icon;
        private MaterialSkin.Controls.MaterialTabControl tabDVcon;
        private System.Windows.Forms.TabPage tabDSDV;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TabPage tabDVCuaToi;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}