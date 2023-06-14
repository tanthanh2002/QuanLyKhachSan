namespace HotelManagement.GUI
{
    partial class fChinhSuaTaiKhoan
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
            this.txtTenTK = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMKMoi = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtXacNhanMK = new MaterialSkin.Controls.MaterialTextBox2();
            this.btDoiMK = new MaterialSkin.Controls.MaterialButton();
            this.txtMKCu = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(40, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tên Tài Khoản";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(40, 212);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Mật Khẩu Mới";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(40, 273);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(143, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Xác Nhận Mật Khẩu";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // txtTenTK
            // 
            this.txtTenTK.AnimateReadOnly = false;
            this.txtTenTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenTK.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenTK.Depth = 0;
            this.txtTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenTK.HideSelection = true;
            this.txtTenTK.LeadingIcon = null;
            this.txtTenTK.Location = new System.Drawing.Point(260, 80);
            this.txtTenTK.MaxLength = 32767;
            this.txtTenTK.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.PasswordChar = '\0';
            this.txtTenTK.PrefixSuffixText = null;
            this.txtTenTK.ReadOnly = false;
            this.txtTenTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenTK.SelectedText = "";
            this.txtTenTK.SelectionLength = 0;
            this.txtTenTK.SelectionStart = 0;
            this.txtTenTK.ShortcutsEnabled = true;
            this.txtTenTK.Size = new System.Drawing.Size(407, 48);
            this.txtTenTK.TabIndex = 3;
            this.txtTenTK.TabStop = false;
            this.txtTenTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenTK.TrailingIcon = null;
            this.txtTenTK.UseSystemPasswordChar = false;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.AnimateReadOnly = false;
            this.txtMKMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMKMoi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMKMoi.Depth = 0;
            this.txtMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMKMoi.HideSelection = true;
            this.txtMKMoi.LeadingIcon = null;
            this.txtMKMoi.Location = new System.Drawing.Point(260, 197);
            this.txtMKMoi.MaxLength = 32767;
            this.txtMKMoi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '\0';
            this.txtMKMoi.PrefixSuffixText = null;
            this.txtMKMoi.ReadOnly = false;
            this.txtMKMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMKMoi.SelectedText = "";
            this.txtMKMoi.SelectionLength = 0;
            this.txtMKMoi.SelectionStart = 0;
            this.txtMKMoi.ShortcutsEnabled = true;
            this.txtMKMoi.Size = new System.Drawing.Size(407, 48);
            this.txtMKMoi.TabIndex = 4;
            this.txtMKMoi.TabStop = false;
            this.txtMKMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMKMoi.TrailingIcon = null;
            this.txtMKMoi.UseSystemPasswordChar = false;
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.AnimateReadOnly = false;
            this.txtXacNhanMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtXacNhanMK.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtXacNhanMK.Depth = 0;
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtXacNhanMK.HideSelection = true;
            this.txtXacNhanMK.LeadingIcon = null;
            this.txtXacNhanMK.Location = new System.Drawing.Point(260, 257);
            this.txtXacNhanMK.MaxLength = 32767;
            this.txtXacNhanMK.MouseState = MaterialSkin.MouseState.OUT;
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PasswordChar = '\0';
            this.txtXacNhanMK.PrefixSuffixText = null;
            this.txtXacNhanMK.ReadOnly = false;
            this.txtXacNhanMK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtXacNhanMK.SelectedText = "";
            this.txtXacNhanMK.SelectionLength = 0;
            this.txtXacNhanMK.SelectionStart = 0;
            this.txtXacNhanMK.ShortcutsEnabled = true;
            this.txtXacNhanMK.Size = new System.Drawing.Size(407, 48);
            this.txtXacNhanMK.TabIndex = 5;
            this.txtXacNhanMK.TabStop = false;
            this.txtXacNhanMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtXacNhanMK.TrailingIcon = null;
            this.txtXacNhanMK.UseSystemPasswordChar = false;
            // 
            // btDoiMK
            // 
            this.btDoiMK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDoiMK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btDoiMK.Depth = 0;
            this.btDoiMK.HighEmphasis = true;
            this.btDoiMK.Icon = null;
            this.btDoiMK.Location = new System.Drawing.Point(426, 327);
            this.btDoiMK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDoiMK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDoiMK.Name = "btDoiMK";
            this.btDoiMK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btDoiMK.Size = new System.Drawing.Size(95, 36);
            this.btDoiMK.TabIndex = 6;
            this.btDoiMK.Text = "Xác Nhận";
            this.btDoiMK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btDoiMK.UseAccentColor = false;
            this.btDoiMK.UseVisualStyleBackColor = true;
            this.btDoiMK.Click += new System.EventHandler(this.btDoiMK_Click);
            // 
            // txtMKCu
            // 
            this.txtMKCu.AnimateReadOnly = false;
            this.txtMKCu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMKCu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMKCu.Depth = 0;
            this.txtMKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMKCu.HideSelection = true;
            this.txtMKCu.LeadingIcon = null;
            this.txtMKCu.Location = new System.Drawing.Point(260, 139);
            this.txtMKCu.MaxLength = 32767;
            this.txtMKCu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '\0';
            this.txtMKCu.PrefixSuffixText = null;
            this.txtMKCu.ReadOnly = false;
            this.txtMKCu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMKCu.SelectedText = "";
            this.txtMKCu.SelectionLength = 0;
            this.txtMKCu.SelectionStart = 0;
            this.txtMKCu.ShortcutsEnabled = true;
            this.txtMKCu.Size = new System.Drawing.Size(407, 48);
            this.txtMKCu.TabIndex = 8;
            this.txtMKCu.TabStop = false;
            this.txtMKCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMKCu.TrailingIcon = null;
            this.txtMKCu.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(40, 153);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(93, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Mật Khẩu Cũ";
            // 
            // fChinhSuaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 381);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btDoiMK);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "fChinhSuaTaiKhoan";
            this.Text = "Chỉnh Sửa Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenTK;
        private MaterialSkin.Controls.MaterialTextBox2 txtMKMoi;
        private MaterialSkin.Controls.MaterialTextBox2 txtXacNhanMK;
        private MaterialSkin.Controls.MaterialButton btDoiMK;
        private MaterialSkin.Controls.MaterialTextBox2 txtMKCu;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}