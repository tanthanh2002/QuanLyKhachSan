namespace HotelManagement.GUI
{
    partial class fRoomSearch
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.checkGia1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkSoLuong1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkGia2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkSoLuong2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnXong = new MaterialSkin.Controls.MaterialButton();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.dgvDSPhong = new System.Windows.Forms.DataGridView();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkGia3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkSoLuong3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnXemChiTiet = new MaterialSkin.Controls.MaterialButton();
            this.btnDatPhong = new MaterialSkin.Controls.MaterialButton();
            this.maphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaiphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apDungKhuyenMaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiThatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(29, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Bộ lọc tìm kiếm";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(65, 123);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(99, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Theo mức giá";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(65, 157);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(107, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Theo số phòng";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(29, 199);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(120, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Kết quả tìm kiếm";
            // 
            // checkGia1
            // 
            this.checkGia1.AutoSize = true;
            this.checkGia1.Depth = 0;
            this.checkGia1.Location = new System.Drawing.Point(223, 114);
            this.checkGia1.Margin = new System.Windows.Forms.Padding(0);
            this.checkGia1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkGia1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkGia1.Name = "checkGia1";
            this.checkGia1.ReadOnly = false;
            this.checkGia1.Ripple = true;
            this.checkGia1.Size = new System.Drawing.Size(118, 37);
            this.checkGia1.TabIndex = 4;
            this.checkGia1.Text = "> 2.000.000";
            this.checkGia1.UseVisualStyleBackColor = true;
            // 
            // checkSoLuong1
            // 
            this.checkSoLuong1.AutoSize = true;
            this.checkSoLuong1.Depth = 0;
            this.checkSoLuong1.Location = new System.Drawing.Point(223, 148);
            this.checkSoLuong1.Margin = new System.Windows.Forms.Padding(0);
            this.checkSoLuong1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkSoLuong1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkSoLuong1.Name = "checkSoLuong1";
            this.checkSoLuong1.ReadOnly = false;
            this.checkSoLuong1.Ripple = true;
            this.checkSoLuong1.Size = new System.Drawing.Size(113, 37);
            this.checkSoLuong1.TabIndex = 5;
            this.checkSoLuong1.Text = "Phòng đơn";
            this.checkSoLuong1.UseVisualStyleBackColor = true;
            // 
            // checkGia2
            // 
            this.checkGia2.AutoSize = true;
            this.checkGia2.Depth = 0;
            this.checkGia2.Location = new System.Drawing.Point(384, 114);
            this.checkGia2.Margin = new System.Windows.Forms.Padding(0);
            this.checkGia2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkGia2.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkGia2.Name = "checkGia2";
            this.checkGia2.ReadOnly = false;
            this.checkGia2.Ripple = true;
            this.checkGia2.Size = new System.Drawing.Size(118, 37);
            this.checkGia2.TabIndex = 6;
            this.checkGia2.Text = "> 5.000.000";
            this.checkGia2.UseVisualStyleBackColor = true;
            // 
            // checkSoLuong2
            // 
            this.checkSoLuong2.AutoSize = true;
            this.checkSoLuong2.Depth = 0;
            this.checkSoLuong2.Location = new System.Drawing.Point(384, 148);
            this.checkSoLuong2.Margin = new System.Windows.Forms.Padding(0);
            this.checkSoLuong2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkSoLuong2.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkSoLuong2.Name = "checkSoLuong2";
            this.checkSoLuong2.ReadOnly = false;
            this.checkSoLuong2.Ripple = true;
            this.checkSoLuong2.Size = new System.Drawing.Size(108, 37);
            this.checkSoLuong2.TabIndex = 7;
            this.checkSoLuong2.Text = "Phòng đôi";
            this.checkSoLuong2.UseVisualStyleBackColor = true;
            // 
            // btnXong
            // 
            this.btnXong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXong.Depth = 0;
            this.btnXong.HighEmphasis = true;
            this.btnXong.Icon = null;
            this.btnXong.Location = new System.Drawing.Point(683, 445);
            this.btnXong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXong.Name = "btnXong";
            this.btnXong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXong.Size = new System.Drawing.Size(64, 36);
            this.btnXong.TabIndex = 9;
            this.btnXong.Text = "Xong";
            this.btnXong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXong.UseAccentColor = false;
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = null;
            this.btnTimKiem.Location = new System.Drawing.Point(661, 189);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(86, 36);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm ";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseMnemonic = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.AutoGenerateColumns = false;
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphongDataGridViewTextBoxColumn,
            this.sophongDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.maloaiphongDataGridViewTextBoxColumn,
            this.apDungKhuyenMaisDataGridViewTextBoxColumn,
            this.loaiPhongDataGridViewTextBoxColumn,
            this.noiThatsDataGridViewTextBoxColumn});
            this.dgvDSPhong.DataSource = this.phongBindingSource;
            this.dgvDSPhong.Location = new System.Drawing.Point(29, 234);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.RowHeadersWidth = 51;
            this.dgvDSPhong.Size = new System.Drawing.Size(718, 185);
            this.dgvDSPhong.TabIndex = 11;
            this.dgvDSPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhong_CellContentClick);
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataSource = typeof(HotelManagement.Phong);
            // 
            // checkGia3
            // 
            this.checkGia3.AutoSize = true;
            this.checkGia3.Depth = 0;
            this.checkGia3.Location = new System.Drawing.Point(538, 114);
            this.checkGia3.Margin = new System.Windows.Forms.Padding(0);
            this.checkGia3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkGia3.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkGia3.Name = "checkGia3";
            this.checkGia3.ReadOnly = false;
            this.checkGia3.Ripple = true;
            this.checkGia3.Size = new System.Drawing.Size(84, 37);
            this.checkGia3.TabIndex = 12;
            this.checkGia3.Text = "Tất cả ";
            this.checkGia3.UseVisualStyleBackColor = true;
            // 
            // checkSoLuong3
            // 
            this.checkSoLuong3.AutoSize = true;
            this.checkSoLuong3.Depth = 0;
            this.checkSoLuong3.Location = new System.Drawing.Point(538, 151);
            this.checkSoLuong3.Margin = new System.Windows.Forms.Padding(0);
            this.checkSoLuong3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkSoLuong3.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkSoLuong3.Name = "checkSoLuong3";
            this.checkSoLuong3.ReadOnly = false;
            this.checkSoLuong3.Ripple = true;
            this.checkSoLuong3.Size = new System.Drawing.Size(84, 37);
            this.checkSoLuong3.TabIndex = 13;
            this.checkSoLuong3.Text = "Tất cả ";
            this.checkSoLuong3.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXemChiTiet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXemChiTiet.Depth = 0;
            this.btnXemChiTiet.HighEmphasis = true;
            this.btnXemChiTiet.Icon = null;
            this.btnXemChiTiet.Location = new System.Drawing.Point(368, 445);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXemChiTiet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXemChiTiet.Size = new System.Drawing.Size(114, 36);
            this.btnXemChiTiet.TabIndex = 14;
            this.btnXemChiTiet.Text = "Xem chi tiết ";
            this.btnXemChiTiet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXemChiTiet.UseAccentColor = false;
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDatPhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDatPhong.Depth = 0;
            this.btnDatPhong.HighEmphasis = true;
            this.btnDatPhong.Icon = null;
            this.btnDatPhong.Location = new System.Drawing.Point(538, 445);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDatPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDatPhong.Size = new System.Drawing.Size(104, 36);
            this.btnDatPhong.TabIndex = 15;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDatPhong.UseAccentColor = false;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // maphongDataGridViewTextBoxColumn
            // 
            this.maphongDataGridViewTextBoxColumn.DataPropertyName = "maphong";
            this.maphongDataGridViewTextBoxColumn.HeaderText = "maphong";
            this.maphongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maphongDataGridViewTextBoxColumn.Name = "maphongDataGridViewTextBoxColumn";
            this.maphongDataGridViewTextBoxColumn.Width = 125;
            // 
            // sophongDataGridViewTextBoxColumn
            // 
            this.sophongDataGridViewTextBoxColumn.DataPropertyName = "sophong";
            this.sophongDataGridViewTextBoxColumn.HeaderText = "sophong";
            this.sophongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sophongDataGridViewTextBoxColumn.Name = "sophongDataGridViewTextBoxColumn";
            this.sophongDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 125;
            // 
            // maloaiphongDataGridViewTextBoxColumn
            // 
            this.maloaiphongDataGridViewTextBoxColumn.DataPropertyName = "maloaiphong";
            this.maloaiphongDataGridViewTextBoxColumn.HeaderText = "maloaiphong";
            this.maloaiphongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maloaiphongDataGridViewTextBoxColumn.Name = "maloaiphongDataGridViewTextBoxColumn";
            this.maloaiphongDataGridViewTextBoxColumn.Width = 125;
            // 
            // apDungKhuyenMaisDataGridViewTextBoxColumn
            // 
            this.apDungKhuyenMaisDataGridViewTextBoxColumn.DataPropertyName = "ApDungKhuyenMais";
            this.apDungKhuyenMaisDataGridViewTextBoxColumn.HeaderText = "ApDungKhuyenMais";
            this.apDungKhuyenMaisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apDungKhuyenMaisDataGridViewTextBoxColumn.Name = "apDungKhuyenMaisDataGridViewTextBoxColumn";
            this.apDungKhuyenMaisDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaiPhongDataGridViewTextBoxColumn
            // 
            this.loaiPhongDataGridViewTextBoxColumn.DataPropertyName = "LoaiPhong";
            this.loaiPhongDataGridViewTextBoxColumn.HeaderText = "LoaiPhong";
            this.loaiPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiPhongDataGridViewTextBoxColumn.Name = "loaiPhongDataGridViewTextBoxColumn";
            this.loaiPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // noiThatsDataGridViewTextBoxColumn
            // 
            this.noiThatsDataGridViewTextBoxColumn.DataPropertyName = "NoiThats";
            this.noiThatsDataGridViewTextBoxColumn.HeaderText = "NoiThats";
            this.noiThatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiThatsDataGridViewTextBoxColumn.Name = "noiThatsDataGridViewTextBoxColumn";
            this.noiThatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // fRoomSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.checkSoLuong3);
            this.Controls.Add(this.checkGia3);
            this.Controls.Add(this.dgvDSPhong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.checkSoLuong2);
            this.Controls.Add(this.checkGia2);
            this.Controls.Add(this.checkSoLuong1);
            this.Controls.Add(this.checkGia1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fRoomSearch";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Tìm kiếm phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckbox checkGia1;
        private MaterialSkin.Controls.MaterialCheckbox checkSoLuong1;
        private MaterialSkin.Controls.MaterialCheckbox checkGia2;
        private MaterialSkin.Controls.MaterialCheckbox checkSoLuong2;
        private MaterialSkin.Controls.MaterialButton btnXong;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSPhong;
        private MaterialSkin.Controls.MaterialCheckbox checkGia3;
        private MaterialSkin.Controls.MaterialCheckbox checkSoLuong3;
        private MaterialSkin.Controls.MaterialButton btnXemChiTiet;
        private MaterialSkin.Controls.MaterialButton btnDatPhong;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaiphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apDungKhuyenMaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiThatsDataGridViewTextBoxColumn;
    }
}