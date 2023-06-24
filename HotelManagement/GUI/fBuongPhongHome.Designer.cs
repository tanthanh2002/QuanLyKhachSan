
namespace HotelManagement.GUI
{
    partial class fBuongPhongHome
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
            this.dgvDSPhong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatTinhTrangPhong = new MaterialSkin.Controls.MaterialButton();
            this.cbTinhTrangPhong = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemPhieuSuDungThucPham = new MaterialSkin.Controls.MaterialButton();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cbTenThucPham = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPhieuHuHongNoiThat = new MaterialSkin.Controls.MaterialButton();
            this.cbTenNoiThat = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cbMaPhieuDat = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.tbMaPhong = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.btnTimKiemMaPhong = new MaterialSkin.Controls.MaterialButton();
            this.maphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikhoaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tinhtrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTimMaPhong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(22, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mã phòng:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(259, 139);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(126, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Danh sách phòng";
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.AutoGenerateColumns = false;
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphongDataGridViewTextBoxColumn,
            this.sophongDataGridViewTextBoxColumn,
            this.bikhoaDataGridViewCheckBoxColumn,
            this.tinhtrangDataGridViewTextBoxColumn});
            this.dgvDSPhong.DataSource = this.phongBindingSource;
            this.dgvDSPhong.Location = new System.Drawing.Point(25, 175);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.RowHeadersWidth = 51;
            this.dgvDSPhong.RowTemplate.Height = 24;
            this.dgvDSPhong.Size = new System.Drawing.Size(654, 402);
            this.dgvDSPhong.TabIndex = 3;
            this.dgvDSPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhong_CellClick);
            this.dgvDSPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhong_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhatTinhTrangPhong);
            this.groupBox1.Controls.Add(this.cbTinhTrangPhong);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Location = new System.Drawing.Point(685, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật tình trạng phòng";
            // 
            // btnCapNhatTinhTrangPhong
            // 
            this.btnCapNhatTinhTrangPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapNhatTinhTrangPhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCapNhatTinhTrangPhong.Depth = 0;
            this.btnCapNhatTinhTrangPhong.HighEmphasis = true;
            this.btnCapNhatTinhTrangPhong.Icon = null;
            this.btnCapNhatTinhTrangPhong.Location = new System.Drawing.Point(359, 40);
            this.btnCapNhatTinhTrangPhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapNhatTinhTrangPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapNhatTinhTrangPhong.Name = "btnCapNhatTinhTrangPhong";
            this.btnCapNhatTinhTrangPhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCapNhatTinhTrangPhong.Size = new System.Drawing.Size(93, 36);
            this.btnCapNhatTinhTrangPhong.TabIndex = 4;
            this.btnCapNhatTinhTrangPhong.Text = "Cập nhật";
            this.btnCapNhatTinhTrangPhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhatTinhTrangPhong.UseAccentColor = false;
            this.btnCapNhatTinhTrangPhong.UseVisualStyleBackColor = true;
            this.btnCapNhatTinhTrangPhong.Click += new System.EventHandler(this.btnCapNhatTinhTrangPhong_Click);
            // 
            // cbTinhTrangPhong
            // 
            this.cbTinhTrangPhong.AutoResize = false;
            this.cbTinhTrangPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTinhTrangPhong.Depth = 0;
            this.cbTinhTrangPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTinhTrangPhong.DropDownHeight = 174;
            this.cbTinhTrangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrangPhong.DropDownWidth = 121;
            this.cbTinhTrangPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTinhTrangPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTinhTrangPhong.FormattingEnabled = true;
            this.cbTinhTrangPhong.IntegralHeight = false;
            this.cbTinhTrangPhong.ItemHeight = 43;
            this.cbTinhTrangPhong.Location = new System.Drawing.Point(114, 35);
            this.cbTinhTrangPhong.MaxDropDownItems = 4;
            this.cbTinhTrangPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTinhTrangPhong.Name = "cbTinhTrangPhong";
            this.cbTinhTrangPhong.Size = new System.Drawing.Size(180, 49);
            this.cbTinhTrangPhong.StartIndex = 0;
            this.cbTinhTrangPhong.TabIndex = 3;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(13, 50);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(78, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Tình trạng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemPhieuSuDungThucPham);
            this.groupBox2.Controls.Add(this.nudSoLuong);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.cbTenThucPham);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Location = new System.Drawing.Point(685, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu sử dụng thực phẩm ";
            // 
            // btnThemPhieuSuDungThucPham
            // 
            this.btnThemPhieuSuDungThucPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemPhieuSuDungThucPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemPhieuSuDungThucPham.Depth = 0;
            this.btnThemPhieuSuDungThucPham.HighEmphasis = true;
            this.btnThemPhieuSuDungThucPham.Icon = null;
            this.btnThemPhieuSuDungThucPham.Location = new System.Drawing.Point(391, 93);
            this.btnThemPhieuSuDungThucPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemPhieuSuDungThucPham.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemPhieuSuDungThucPham.Name = "btnThemPhieuSuDungThucPham";
            this.btnThemPhieuSuDungThucPham.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemPhieuSuDungThucPham.Size = new System.Drawing.Size(64, 36);
            this.btnThemPhieuSuDungThucPham.TabIndex = 8;
            this.btnThemPhieuSuDungThucPham.Text = "Thêm";
            this.btnThemPhieuSuDungThucPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemPhieuSuDungThucPham.UseAccentColor = false;
            this.btnThemPhieuSuDungThucPham.UseVisualStyleBackColor = true;
            this.btnThemPhieuSuDungThucPham.Click += new System.EventHandler(this.btnThemPhieuSuDungThucPham_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(384, 39);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(66, 27);
            this.nudSoLuong.TabIndex = 3;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(300, 39);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(69, 19);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Số lượng:";
            // 
            // cbTenThucPham
            // 
            this.cbTenThucPham.AutoResize = false;
            this.cbTenThucPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTenThucPham.Depth = 0;
            this.cbTenThucPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTenThucPham.DropDownHeight = 174;
            this.cbTenThucPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenThucPham.DropDownWidth = 121;
            this.cbTenThucPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTenThucPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTenThucPham.FormattingEnabled = true;
            this.cbTenThucPham.IntegralHeight = false;
            this.cbTenThucPham.ItemHeight = 43;
            this.cbTenThucPham.Location = new System.Drawing.Point(114, 30);
            this.cbTenThucPham.MaxDropDownItems = 4;
            this.cbTenThucPham.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTenThucPham.Name = "cbTenThucPham";
            this.cbTenThucPham.Size = new System.Drawing.Size(180, 49);
            this.cbTenThucPham.StartIndex = 0;
            this.cbTenThucPham.TabIndex = 1;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(16, 39);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(36, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Loại:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPhieuHuHongNoiThat);
            this.groupBox3.Controls.Add(this.cbTenNoiThat);
            this.groupBox3.Controls.Add(this.materialLabel9);
            this.groupBox3.Location = new System.Drawing.Point(685, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 110);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu hư hỏng nội thất";
            // 
            // btnPhieuHuHongNoiThat
            // 
            this.btnPhieuHuHongNoiThat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPhieuHuHongNoiThat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPhieuHuHongNoiThat.Depth = 0;
            this.btnPhieuHuHongNoiThat.HighEmphasis = true;
            this.btnPhieuHuHongNoiThat.Icon = null;
            this.btnPhieuHuHongNoiThat.Location = new System.Drawing.Point(391, 40);
            this.btnPhieuHuHongNoiThat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPhieuHuHongNoiThat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPhieuHuHongNoiThat.Name = "btnPhieuHuHongNoiThat";
            this.btnPhieuHuHongNoiThat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPhieuHuHongNoiThat.Size = new System.Drawing.Size(64, 36);
            this.btnPhieuHuHongNoiThat.TabIndex = 12;
            this.btnPhieuHuHongNoiThat.Text = "Thêm";
            this.btnPhieuHuHongNoiThat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPhieuHuHongNoiThat.UseAccentColor = false;
            this.btnPhieuHuHongNoiThat.UseVisualStyleBackColor = true;
            this.btnPhieuHuHongNoiThat.Click += new System.EventHandler(this.btnPhieuHuHongNoiThat_Click);
            // 
            // cbTenNoiThat
            // 
            this.cbTenNoiThat.AutoResize = false;
            this.cbTenNoiThat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTenNoiThat.Depth = 0;
            this.cbTenNoiThat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTenNoiThat.DropDownHeight = 174;
            this.cbTenNoiThat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenNoiThat.DropDownWidth = 121;
            this.cbTenNoiThat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTenNoiThat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTenNoiThat.FormattingEnabled = true;
            this.cbTenNoiThat.IntegralHeight = false;
            this.cbTenNoiThat.ItemHeight = 43;
            this.cbTenNoiThat.Location = new System.Drawing.Point(114, 35);
            this.cbTenNoiThat.MaxDropDownItems = 4;
            this.cbTenNoiThat.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTenNoiThat.Name = "cbTenNoiThat";
            this.cbTenNoiThat.Size = new System.Drawing.Size(180, 49);
            this.cbTenNoiThat.StartIndex = 0;
            this.cbTenNoiThat.TabIndex = 11;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(19, 50);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(61, 19);
            this.materialLabel9.TabIndex = 10;
            this.materialLabel9.Text = "Nội thất:";
            // 
            // cbMaPhieuDat
            // 
            this.cbMaPhieuDat.AutoResize = false;
            this.cbMaPhieuDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMaPhieuDat.Depth = 0;
            this.cbMaPhieuDat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMaPhieuDat.DropDownHeight = 174;
            this.cbMaPhieuDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhieuDat.DropDownWidth = 121;
            this.cbMaPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMaPhieuDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMaPhieuDat.FormattingEnabled = true;
            this.cbMaPhieuDat.IntegralHeight = false;
            this.cbMaPhieuDat.ItemHeight = 43;
            this.cbMaPhieuDat.Location = new System.Drawing.Point(1012, 90);
            this.cbMaPhieuDat.MaxDropDownItems = 4;
            this.cbMaPhieuDat.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMaPhieuDat.Name = "cbMaPhieuDat";
            this.cbMaPhieuDat.Size = new System.Drawing.Size(156, 49);
            this.cbMaPhieuDat.StartIndex = 0;
            this.cbMaPhieuDat.TabIndex = 11;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(928, 105);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(56, 19);
            this.materialLabel12.TabIndex = 10;
            this.materialLabel12.Text = "Mã đặt:";
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.AnimateReadOnly = false;
            this.tbMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaPhong.Depth = 0;
            this.tbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMaPhong.LeadingIcon = null;
            this.tbMaPhong.Location = new System.Drawing.Point(796, 91);
            this.tbMaPhong.MaxLength = 50;
            this.tbMaPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMaPhong.Multiline = false;
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.Size = new System.Drawing.Size(115, 50);
            this.tbMaPhong.TabIndex = 9;
            this.tbMaPhong.Text = "";
            this.tbMaPhong.TrailingIcon = null;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(698, 105);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(77, 19);
            this.materialLabel13.TabIndex = 8;
            this.materialLabel13.Text = "Mã phòng:";
            // 
            // btnTimKiemMaPhong
            // 
            this.btnTimKiemMaPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiemMaPhong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiemMaPhong.Depth = 0;
            this.btnTimKiemMaPhong.HighEmphasis = true;
            this.btnTimKiemMaPhong.Icon = null;
            this.btnTimKiemMaPhong.Location = new System.Drawing.Point(376, 84);
            this.btnTimKiemMaPhong.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiemMaPhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiemMaPhong.Name = "btnTimKiemMaPhong";
            this.btnTimKiemMaPhong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiemMaPhong.Size = new System.Drawing.Size(86, 36);
            this.btnTimKiemMaPhong.TabIndex = 12;
            this.btnTimKiemMaPhong.Text = "Tìm kiếm";
            this.btnTimKiemMaPhong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiemMaPhong.UseAccentColor = false;
            this.btnTimKiemMaPhong.UseVisualStyleBackColor = true;
            this.btnTimKiemMaPhong.Click += new System.EventHandler(this.btnTimKiemMaPhong_Click);
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
            // bikhoaDataGridViewCheckBoxColumn
            // 
            this.bikhoaDataGridViewCheckBoxColumn.DataPropertyName = "bikhoa";
            this.bikhoaDataGridViewCheckBoxColumn.HeaderText = "bikhoa";
            this.bikhoaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.bikhoaDataGridViewCheckBoxColumn.Name = "bikhoaDataGridViewCheckBoxColumn";
            this.bikhoaDataGridViewCheckBoxColumn.Width = 125;
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
            // 
            // cbTimMaPhong
            // 
            this.cbTimMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimMaPhong.FormattingEnabled = true;
            this.cbTimMaPhong.Location = new System.Drawing.Point(116, 85);
            this.cbTimMaPhong.Name = "cbTimMaPhong";
            this.cbTimMaPhong.Size = new System.Drawing.Size(222, 33);
            this.cbTimMaPhong.TabIndex = 13;
            // 
            // fBuongPhongHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 583);
            this.Controls.Add(this.cbTimMaPhong);
            this.Controls.Add(this.btnTimKiemMaPhong);
            this.Controls.Add(this.cbMaPhieuDat);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.tbMaPhong);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDSPhong);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.Name = "fBuongPhongHome";
            this.Text = "Buồng phòng";
            this.Load += new System.EventHandler(this.fBuongPhongHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgvDSPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bikhoaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnCapNhatTinhTrangPhong;
        private MaterialSkin.Controls.MaterialComboBox cbTinhTrangPhong;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnThemPhieuSuDungThucPham;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox cbTenThucPham;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnPhieuHuHongNoiThat;
        private MaterialSkin.Controls.MaterialComboBox cbTenNoiThat;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialComboBox cbMaPhieuDat;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialTextBox tbMaPhong;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialButton btnTimKiemMaPhong;
        private System.Windows.Forms.ComboBox cbTimMaPhong;
    }
}