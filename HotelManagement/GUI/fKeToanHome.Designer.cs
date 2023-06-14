namespace HotelManagement.GUI
{
    partial class fKeToanHome
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
            this.tabControlLeTan = new System.Windows.Forms.TabControl();
            this.tabPageTKDT = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTextBox24 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageQLBL = new System.Windows.Forms.TabPage();
            this.dataGridViewDSNVL = new System.Windows.Forms.DataGridView();
            this.txtLuong = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaNV = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePickertk = new System.Windows.Forms.DateTimePicker();
            this.tabControlLeTan.SuspendLayout();
            this.tabPageTKDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageQLBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNVL)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlLeTan
            // 
            this.tabControlLeTan.Controls.Add(this.tabPageTKDT);
            this.tabControlLeTan.Controls.Add(this.tabPageQLBL);
            this.tabControlLeTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlLeTan.Location = new System.Drawing.Point(6, 67);
            this.tabControlLeTan.Name = "tabControlLeTan";
            this.tabControlLeTan.SelectedIndex = 0;
            this.tabControlLeTan.Size = new System.Drawing.Size(988, 527);
            this.tabControlLeTan.TabIndex = 0;
            // 
            // tabPageTKDT
            // 
            this.tabPageTKDT.Controls.Add(this.dateTimePickertk);
            this.tabPageTKDT.Controls.Add(this.dataGridView1);
            this.tabPageTKDT.Controls.Add(this.materialTextBox24);
            this.tabPageTKDT.Controls.Add(this.materialLabel4);
            this.tabPageTKDT.Controls.Add(this.materialLabel1);
            this.tabPageTKDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTKDT.Location = new System.Drawing.Point(4, 34);
            this.tabPageTKDT.Name = "tabPageTKDT";
            this.tabPageTKDT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTKDT.Size = new System.Drawing.Size(980, 489);
            this.tabPageTKDT.TabIndex = 0;
            this.tabPageTKDT.Text = "Thống Kê Doanh Thu";
            this.tabPageTKDT.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 287);
            this.dataGridView1.TabIndex = 16;
            // 
            // materialTextBox24
            // 
            this.materialTextBox24.AnimateReadOnly = false;
            this.materialTextBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox24.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox24.Depth = 0;
            this.materialTextBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox24.HideSelection = true;
            this.materialTextBox24.LeadingIcon = null;
            this.materialTextBox24.Location = new System.Drawing.Point(635, 62);
            this.materialTextBox24.MaxLength = 32767;
            this.materialTextBox24.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox24.Name = "materialTextBox24";
            this.materialTextBox24.PasswordChar = '\0';
            this.materialTextBox24.PrefixSuffixText = null;
            this.materialTextBox24.ReadOnly = false;
            this.materialTextBox24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox24.SelectedText = "";
            this.materialTextBox24.SelectionLength = 0;
            this.materialTextBox24.SelectionStart = 0;
            this.materialTextBox24.ShortcutsEnabled = true;
            this.materialTextBox24.Size = new System.Drawing.Size(211, 48);
            this.materialTextBox24.TabIndex = 15;
            this.materialTextBox24.TabStop = false;
            this.materialTextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox24.TrailingIcon = null;
            this.materialTextBox24.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(561, 78);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(38, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Tổng";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel1.Location = new System.Drawing.Point(29, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Ngày";
            // 
            // tabPageQLBL
            // 
            this.tabPageQLBL.Controls.Add(this.dataGridViewDSNVL);
            this.tabPageQLBL.Controls.Add(this.txtLuong);
            this.tabPageQLBL.Controls.Add(this.txtMaNV);
            this.tabPageQLBL.Controls.Add(this.materialLabel6);
            this.tabPageQLBL.Controls.Add(this.materialLabel5);
            this.tabPageQLBL.Controls.Add(this.materialButton1);
            this.tabPageQLBL.Location = new System.Drawing.Point(4, 34);
            this.tabPageQLBL.Name = "tabPageQLBL";
            this.tabPageQLBL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQLBL.Size = new System.Drawing.Size(980, 489);
            this.tabPageQLBL.TabIndex = 1;
            this.tabPageQLBL.Text = "Quản Lý Bảng Lương";
            this.tabPageQLBL.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDSNVL
            // 
            this.dataGridViewDSNVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNVL.Location = new System.Drawing.Point(14, 181);
            this.dataGridViewDSNVL.Name = "dataGridViewDSNVL";
            this.dataGridViewDSNVL.RowHeadersWidth = 51;
            this.dataGridViewDSNVL.RowTemplate.Height = 24;
            this.dataGridViewDSNVL.Size = new System.Drawing.Size(953, 307);
            this.dataGridViewDSNVL.TabIndex = 6;
            // 
            // txtLuong
            // 
            this.txtLuong.AnimateReadOnly = false;
            this.txtLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLuong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLuong.Depth = 0;
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLuong.HideSelection = true;
            this.txtLuong.LeadingIcon = null;
            this.txtLuong.Location = new System.Drawing.Point(193, 109);
            this.txtLuong.MaxLength = 32767;
            this.txtLuong.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PasswordChar = '\0';
            this.txtLuong.PrefixSuffixText = null;
            this.txtLuong.ReadOnly = false;
            this.txtLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLuong.SelectedText = "";
            this.txtLuong.SelectionLength = 0;
            this.txtLuong.SelectionStart = 0;
            this.txtLuong.ShortcutsEnabled = true;
            this.txtLuong.Size = new System.Drawing.Size(305, 48);
            this.txtLuong.TabIndex = 5;
            this.txtLuong.TabStop = false;
            this.txtLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLuong.TrailingIcon = null;
            this.txtLuong.UseSystemPasswordChar = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AnimateReadOnly = false;
            this.txtMaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaNV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaNV.Depth = 0;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaNV.HideSelection = true;
            this.txtMaNV.LeadingIcon = null;
            this.txtMaNV.Location = new System.Drawing.Point(193, 40);
            this.txtMaNV.MaxLength = 32767;
            this.txtMaNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PrefixSuffixText = null;
            this.txtMaNV.ReadOnly = false;
            this.txtMaNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.SelectionLength = 0;
            this.txtMaNV.SelectionStart = 0;
            this.txtMaNV.ShortcutsEnabled = true;
            this.txtMaNV.Size = new System.Drawing.Size(305, 48);
            this.txtMaNV.TabIndex = 4;
            this.txtMaNV.TabStop = false;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaNV.TrailingIcon = null;
            this.txtMaNV.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(35, 128);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Lương";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(35, 51);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(101, 19);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "Mã Nhân Viên";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(575, 77);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(103, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Thay Đổi";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickertk
            // 
            this.dateTimePickertk.Location = new System.Drawing.Point(102, 70);
            this.dateTimePickertk.Name = "dateTimePickertk";
            this.dateTimePickertk.Size = new System.Drawing.Size(256, 34);
            this.dateTimePickertk.TabIndex = 17;
            // 
            // fKeToanHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControlLeTan);
            this.Name = "fKeToanHome";
            this.Text = "Kế Toán";
            this.tabControlLeTan.ResumeLayout(false);
            this.tabPageTKDT.ResumeLayout(false);
            this.tabPageTKDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageQLBL.ResumeLayout(false);
            this.tabPageQLBL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNVL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLeTan;
        private System.Windows.Forms.TabPage tabPageTKDT;
        private System.Windows.Forms.TabPage tabPageQLBL;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox24;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewDSNVL;
        private MaterialSkin.Controls.MaterialTextBox2 txtLuong;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaNV;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DateTimePicker dateTimePickertk;
    }
}