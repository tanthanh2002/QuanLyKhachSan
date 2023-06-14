
namespace HotelManagement.GUI
{
    partial class fLeTanHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLeTanHome));
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.tabLeTan = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDatPhong = new System.Windows.Forms.TabPage();
            this.tabCheckin = new System.Windows.Forms.TabPage();
            this.tabTimKiemPhong = new System.Windows.Forms.TabPage();
            this.DSPhongDaCheckin = new System.Windows.Forms.DataGridView();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.tabTour = new System.Windows.Forms.TabPage();
            this.chinhSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DichVu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.phanHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tour = new System.Windows.Forms.DataGridViewButtonColumn();
            this.maphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikhoaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tinhtrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabLeTan.SuspendLayout();
            this.tabTimKiemPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhongDaCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // 
            // tabLeTan
            // 
            this.tabLeTan.Controls.Add(this.tabDatPhong);
            this.tabLeTan.Controls.Add(this.tabCheckin);
            this.tabLeTan.Controls.Add(this.tabTimKiemPhong);
            this.tabLeTan.Controls.Add(this.tabDichVu);
            this.tabLeTan.Controls.Add(this.tabTour);
            this.tabLeTan.Depth = 0;
            this.tabLeTan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLeTan.ImageList = this.icon;
            this.tabLeTan.Location = new System.Drawing.Point(3, 64);
            this.tabLeTan.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabLeTan.Multiline = true;
            this.tabLeTan.Name = "tabLeTan";
            this.tabLeTan.SelectedIndex = 0;
            this.tabLeTan.Size = new System.Drawing.Size(1194, 583);
            this.tabLeTan.TabIndex = 0;
            // 
            // tabDatPhong
            // 
            this.tabDatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDatPhong.ImageKey = "booking.png";
            this.tabDatPhong.Location = new System.Drawing.Point(4, 39);
            this.tabDatPhong.Name = "tabDatPhong";
            this.tabDatPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatPhong.Size = new System.Drawing.Size(1186, 540);
            this.tabDatPhong.TabIndex = 0;
            this.tabDatPhong.Text = "Đặt phòng";
            this.tabDatPhong.UseVisualStyleBackColor = true;
            // 
            // tabCheckin
            // 
            this.tabCheckin.ImageKey = "check-in.png";
            this.tabCheckin.Location = new System.Drawing.Point(4, 39);
            this.tabCheckin.Name = "tabCheckin";
            this.tabCheckin.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckin.Size = new System.Drawing.Size(1186, 540);
            this.tabCheckin.TabIndex = 2;
            this.tabCheckin.Text = "Checkin";
            this.tabCheckin.UseVisualStyleBackColor = true;
            // 
            // tabTimKiemPhong
            // 
            this.tabTimKiemPhong.Controls.Add(this.DSPhongDaCheckin);
            this.tabTimKiemPhong.Controls.Add(this.materialTextBox21);
            this.tabTimKiemPhong.Controls.Add(this.materialLabel1);
            this.tabTimKiemPhong.ImageKey = "search.png";
            this.tabTimKiemPhong.Location = new System.Drawing.Point(4, 39);
            this.tabTimKiemPhong.Name = "tabTimKiemPhong";
            this.tabTimKiemPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimKiemPhong.Size = new System.Drawing.Size(1186, 540);
            this.tabTimKiemPhong.TabIndex = 1;
            this.tabTimKiemPhong.Text = "Tìm kiếm phòng";
            this.tabTimKiemPhong.UseVisualStyleBackColor = true;
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
            this.DSPhongDaCheckin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSPhongDaCheckin_CellContentClick);
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
            // tabDichVu
            // 
            this.tabDichVu.ImageKey = "hotel-bell.png";
            this.tabDichVu.Location = new System.Drawing.Point(4, 39);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichVu.Size = new System.Drawing.Size(1186, 540);
            this.tabDichVu.TabIndex = 3;
            this.tabDichVu.Text = "Dịch vụ";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // tabTour
            // 
            this.tabTour.ImageKey = "destination.png";
            this.tabTour.Location = new System.Drawing.Point(4, 39);
            this.tabTour.Name = "tabTour";
            this.tabTour.Padding = new System.Windows.Forms.Padding(3);
            this.tabTour.Size = new System.Drawing.Size(1186, 540);
            this.tabTour.TabIndex = 4;
            this.tabTour.Text = "Tour";
            this.tabTour.UseVisualStyleBackColor = true;
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
            // phanHoi
            // 
            this.phanHoi.DataPropertyName = "maphong";
            this.phanHoi.HeaderText = "Phản hồi";
            this.phanHoi.MinimumWidth = 6;
            this.phanHoi.Name = "phanHoi";
            this.phanHoi.Width = 70;
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
            // fLeTanHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabLeTan);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabLeTan;
            this.Name = "fLeTanHome";
            this.Text = "Lễ tân";
            this.Load += new System.EventHandler(this.fKhachHangHome_Load);
            this.tabLeTan.ResumeLayout(false);
            this.tabTimKiemPhong.ResumeLayout(false);
            this.tabTimKiemPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhongDaCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList icon;
        private MaterialSkin.Controls.MaterialTabControl tabLeTan;
        private System.Windows.Forms.TabPage tabDatPhong;
        private System.Windows.Forms.TabPage tabTimKiemPhong;
        private System.Windows.Forms.TabPage tabCheckin;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.TabPage tabTour;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private System.Windows.Forms.DataGridView DSPhongDaCheckin;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bikhoaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn chinhSua;
        private System.Windows.Forms.DataGridViewButtonColumn DichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanHoi;
        private System.Windows.Forms.DataGridViewButtonColumn checkout;
        private System.Windows.Forms.DataGridViewButtonColumn tour;
    }
}