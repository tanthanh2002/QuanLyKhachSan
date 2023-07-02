namespace HotelManagement.GUI
{
    partial class fQuanLyDichVu
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.dsDV = new System.Windows.Forms.TabPage();
            this.dgvDSDV = new System.Windows.Forms.DataGridView();
            this.suaDV = new System.Windows.Forms.TabPage();
            this.txtTenDVSua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDVSua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_GiaMoi = new System.Windows.Forms.Label();
            this.text_GiaCu = new System.Windows.Forms.Label();
            this.btnSuaDV = new MaterialSkin.Controls.MaterialButton();
            this.txtGiaMoi = new System.Windows.Forms.TextBox();
            this.txtGiaCu = new System.Windows.Forms.TextBox();
            this.dgvDSDVSua = new System.Windows.Forms.DataGridView();
            this.themDV = new System.Windows.Forms.TabPage();
            this.btnThemDV = new MaterialSkin.Controls.MaterialButton();
            this.text_GiaThem = new System.Windows.Forms.Label();
            this.text_tenDVThem = new System.Windows.Forms.Label();
            this.txtGiaDVMoi = new System.Windows.Forms.TextBox();
            this.txtTenDVMoi = new System.Windows.Forms.TextBox();
            this.dgvThemDV = new System.Windows.Forms.DataGridView();
            this.giaCu = new System.Windows.Forms.Label();
            this.giaMoi = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.dsDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).BeginInit();
            this.suaDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDVSua)).BeginInit();
            this.themDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemDV)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.dsDV);
            this.materialTabControl1.Controls.Add(this.suaDV);
            this.materialTabControl1.Controls.Add(this.themDV);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(1, 86);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(860, 432);
            this.materialTabControl1.TabIndex = 0;
            // 
            // dsDV
            // 
            this.dsDV.Controls.Add(this.dgvDSDV);
            this.dsDV.Location = new System.Drawing.Point(4, 25);
            this.dsDV.Name = "dsDV";
            this.dsDV.Padding = new System.Windows.Forms.Padding(3);
            this.dsDV.Size = new System.Drawing.Size(852, 403);
            this.dsDV.TabIndex = 0;
            this.dsDV.Text = "Danh Sách Dịch Vụ";
            this.dsDV.UseVisualStyleBackColor = true;
            // 
            // dgvDSDV
            // 
            this.dgvDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDV.Location = new System.Drawing.Point(161, 26);
            this.dgvDSDV.Name = "dgvDSDV";
            this.dgvDSDV.RowHeadersWidth = 51;
            this.dgvDSDV.RowTemplate.Height = 24;
            this.dgvDSDV.Size = new System.Drawing.Size(547, 336);
            this.dgvDSDV.TabIndex = 0;
            // 
            // suaDV
            // 
            this.suaDV.Controls.Add(this.txtTenDVSua);
            this.suaDV.Controls.Add(this.label2);
            this.suaDV.Controls.Add(this.txtMaDVSua);
            this.suaDV.Controls.Add(this.label1);
            this.suaDV.Controls.Add(this.text_GiaMoi);
            this.suaDV.Controls.Add(this.text_GiaCu);
            this.suaDV.Controls.Add(this.btnSuaDV);
            this.suaDV.Controls.Add(this.txtGiaMoi);
            this.suaDV.Controls.Add(this.txtGiaCu);
            this.suaDV.Controls.Add(this.dgvDSDVSua);
            this.suaDV.Location = new System.Drawing.Point(4, 25);
            this.suaDV.Name = "suaDV";
            this.suaDV.Padding = new System.Windows.Forms.Padding(3);
            this.suaDV.Size = new System.Drawing.Size(852, 403);
            this.suaDV.TabIndex = 1;
            this.suaDV.Text = "Sửa Dịch Vụ";
            this.suaDV.UseVisualStyleBackColor = true;
            // 
            // txtTenDVSua
            // 
            this.txtTenDVSua.Location = new System.Drawing.Point(691, 136);
            this.txtTenDVSua.Name = "txtTenDVSua";
            this.txtTenDVSua.Size = new System.Drawing.Size(129, 22);
            this.txtTenDVSua.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên DV";
            // 
            // txtMaDVSua
            // 
            this.txtMaDVSua.Location = new System.Drawing.Point(691, 96);
            this.txtMaDVSua.Name = "txtMaDVSua";
            this.txtMaDVSua.Size = new System.Drawing.Size(129, 22);
            this.txtMaDVSua.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã DV";
            // 
            // text_GiaMoi
            // 
            this.text_GiaMoi.AutoSize = true;
            this.text_GiaMoi.Location = new System.Drawing.Point(615, 219);
            this.text_GiaMoi.Name = "text_GiaMoi";
            this.text_GiaMoi.Size = new System.Drawing.Size(53, 16);
            this.text_GiaMoi.TabIndex = 9;
            this.text_GiaMoi.Text = "Giá Mới";
            this.text_GiaMoi.Click += new System.EventHandler(this.text_GiaMoi_Click);
            // 
            // text_GiaCu
            // 
            this.text_GiaCu.AutoSize = true;
            this.text_GiaCu.Location = new System.Drawing.Point(615, 176);
            this.text_GiaCu.Name = "text_GiaCu";
            this.text_GiaCu.Size = new System.Drawing.Size(47, 16);
            this.text_GiaCu.TabIndex = 8;
            this.text_GiaCu.Text = "Giá Cũ";
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuaDV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSuaDV.Depth = 0;
            this.btnSuaDV.HighEmphasis = true;
            this.btnSuaDV.Icon = null;
            this.btnSuaDV.Location = new System.Drawing.Point(640, 279);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuaDV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSuaDV.Size = new System.Drawing.Size(110, 36);
            this.btnSuaDV.TabIndex = 7;
            this.btnSuaDV.Text = "Sửa Dịch Vụ";
            this.btnSuaDV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSuaDV.UseAccentColor = false;
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // txtGiaMoi
            // 
            this.txtGiaMoi.Location = new System.Drawing.Point(691, 219);
            this.txtGiaMoi.Name = "txtGiaMoi";
            this.txtGiaMoi.Size = new System.Drawing.Size(129, 22);
            this.txtGiaMoi.TabIndex = 6;
            // 
            // txtGiaCu
            // 
            this.txtGiaCu.Location = new System.Drawing.Point(691, 176);
            this.txtGiaCu.Name = "txtGiaCu";
            this.txtGiaCu.Size = new System.Drawing.Size(129, 22);
            this.txtGiaCu.TabIndex = 5;
            // 
            // dgvDSDVSua
            // 
            this.dgvDSDVSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDVSua.Location = new System.Drawing.Point(34, 44);
            this.dgvDSDVSua.Name = "dgvDSDVSua";
            this.dgvDSDVSua.RowHeadersWidth = 51;
            this.dgvDSDVSua.RowTemplate.Height = 24;
            this.dgvDSDVSua.Size = new System.Drawing.Size(524, 328);
            this.dgvDSDVSua.TabIndex = 0;
            this.dgvDSDVSua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDVSua_CellContentClick);
            // 
            // themDV
            // 
            this.themDV.Controls.Add(this.btnThemDV);
            this.themDV.Controls.Add(this.text_GiaThem);
            this.themDV.Controls.Add(this.text_tenDVThem);
            this.themDV.Controls.Add(this.txtGiaDVMoi);
            this.themDV.Controls.Add(this.txtTenDVMoi);
            this.themDV.Controls.Add(this.dgvThemDV);
            this.themDV.Location = new System.Drawing.Point(4, 25);
            this.themDV.Name = "themDV";
            this.themDV.Padding = new System.Windows.Forms.Padding(3);
            this.themDV.Size = new System.Drawing.Size(852, 403);
            this.themDV.TabIndex = 2;
            this.themDV.Text = "Thêm Dịch Vụ";
            this.themDV.UseVisualStyleBackColor = true;
            // 
            // btnThemDV
            // 
            this.btnThemDV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemDV.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemDV.Depth = 0;
            this.btnThemDV.HighEmphasis = true;
            this.btnThemDV.Icon = null;
            this.btnThemDV.Location = new System.Drawing.Point(594, 246);
            this.btnThemDV.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemDV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemDV.Size = new System.Drawing.Size(122, 36);
            this.btnThemDV.TabIndex = 16;
            this.btnThemDV.Text = "Thêm Dịch Vụ";
            this.btnThemDV.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemDV.UseAccentColor = false;
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // text_GiaThem
            // 
            this.text_GiaThem.AutoSize = true;
            this.text_GiaThem.Location = new System.Drawing.Point(545, 181);
            this.text_GiaThem.Name = "text_GiaThem";
            this.text_GiaThem.Size = new System.Drawing.Size(28, 16);
            this.text_GiaThem.TabIndex = 15;
            this.text_GiaThem.Text = "Giá";
            // 
            // text_tenDVThem
            // 
            this.text_tenDVThem.AutoSize = true;
            this.text_tenDVThem.Location = new System.Drawing.Point(545, 134);
            this.text_tenDVThem.Name = "text_tenDVThem";
            this.text_tenDVThem.Size = new System.Drawing.Size(80, 16);
            this.text_tenDVThem.TabIndex = 14;
            this.text_tenDVThem.Text = "Tên Dịch Vụ";
            // 
            // txtGiaDVMoi
            // 
            this.txtGiaDVMoi.Location = new System.Drawing.Point(641, 181);
            this.txtGiaDVMoi.Name = "txtGiaDVMoi";
            this.txtGiaDVMoi.Size = new System.Drawing.Size(129, 22);
            this.txtGiaDVMoi.TabIndex = 13;
            // 
            // txtTenDVMoi
            // 
            this.txtTenDVMoi.Location = new System.Drawing.Point(641, 134);
            this.txtTenDVMoi.Name = "txtTenDVMoi";
            this.txtTenDVMoi.Size = new System.Drawing.Size(129, 22);
            this.txtTenDVMoi.TabIndex = 12;
            // 
            // dgvThemDV
            // 
            this.dgvThemDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemDV.Location = new System.Drawing.Point(89, 52);
            this.dgvThemDV.Name = "dgvThemDV";
            this.dgvThemDV.RowHeadersWidth = 51;
            this.dgvThemDV.RowTemplate.Height = 24;
            this.dgvThemDV.Size = new System.Drawing.Size(424, 281);
            this.dgvThemDV.TabIndex = 0;
            this.dgvThemDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemDV_CellContentClick);
            // 
            // giaCu
            // 
            this.giaCu.Location = new System.Drawing.Point(0, 0);
            this.giaCu.Name = "giaCu";
            this.giaCu.Size = new System.Drawing.Size(100, 23);
            this.giaCu.TabIndex = 0;
            // 
            // giaMoi
            // 
            this.giaMoi.Location = new System.Drawing.Point(0, 0);
            this.giaMoi.Name = "giaMoi";
            this.giaMoi.Size = new System.Drawing.Size(100, 23);
            this.giaMoi.TabIndex = 0;
            // 
            // fQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 524);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerHighlightWithAccent = false;
            this.DrawerIsOpen = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "fQuanLyDichVu";
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.fQuanLyDichVu_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.dsDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).EndInit();
            this.suaDV.ResumeLayout(false);
            this.suaDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDVSua)).EndInit();
            this.themDV.ResumeLayout(false);
            this.themDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage dsDV;
        private System.Windows.Forms.TabPage suaDV;
        private System.Windows.Forms.DataGridView dgvDSDV;
        private System.Windows.Forms.Label txtgiaMoi;
        private System.Windows.Forms.Label txtgiaCu;
        private System.Windows.Forms.DataGridView dgvDSDVSua;
        private MaterialSkin.Controls.MaterialButton btnSuaDV;
        private System.Windows.Forms.TextBox txtGiaMoi;
        private System.Windows.Forms.TextBox txtGiaCu;
        private System.Windows.Forms.Label giaCu;
        private System.Windows.Forms.Label giaMoi;
        private System.Windows.Forms.Label text_GiaCu;
        private System.Windows.Forms.Label text_GiaMoi;
        private System.Windows.Forms.TabPage themDV;
        private System.Windows.Forms.Label text_GiaThem;
        private System.Windows.Forms.Label text_tenDVThem;
        private System.Windows.Forms.TextBox txtGiaDVMoi;
        private System.Windows.Forms.TextBox txtTenDVMoi;
        private System.Windows.Forms.DataGridView dgvThemDV;
        private MaterialSkin.Controls.MaterialButton btnThemDV;
        private System.Windows.Forms.TextBox txtTenDVSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDVSua;
        private System.Windows.Forms.Label label1;
    }
}