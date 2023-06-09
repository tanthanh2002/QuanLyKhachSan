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
            this.txtMatk = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMKMoi = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtXacNhanMK = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mã Tài Khoản";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(40, 148);
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
            this.materialLabel3.Location = new System.Drawing.Point(40, 203);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(143, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Xác Nhận Mật Khẩu";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // txtMatk
            // 
            this.txtMatk.AnimateReadOnly = false;
            this.txtMatk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMatk.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatk.Depth = 0;
            this.txtMatk.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatk.HideSelection = true;
            this.txtMatk.LeadingIcon = null;
            this.txtMatk.Location = new System.Drawing.Point(214, 80);
            this.txtMatk.MaxLength = 32767;
            this.txtMatk.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatk.Name = "txtMatk";
            this.txtMatk.PasswordChar = '\0';
            this.txtMatk.PrefixSuffixText = null;
            this.txtMatk.ReadOnly = false;
            this.txtMatk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMatk.SelectedText = "";
            this.txtMatk.SelectionLength = 0;
            this.txtMatk.SelectionStart = 0;
            this.txtMatk.ShortcutsEnabled = true;
            this.txtMatk.Size = new System.Drawing.Size(407, 48);
            this.txtMatk.TabIndex = 3;
            this.txtMatk.TabStop = false;
            this.txtMatk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatk.TrailingIcon = null;
            this.txtMatk.UseSystemPasswordChar = false;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.AnimateReadOnly = false;
            this.txtMKMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMKMoi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMKMoi.Depth = 0;
            this.txtMKMoi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMKMoi.HideSelection = true;
            this.txtMKMoi.LeadingIcon = null;
            this.txtMKMoi.Location = new System.Drawing.Point(214, 134);
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
            this.txtXacNhanMK.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtXacNhanMK.HideSelection = true;
            this.txtXacNhanMK.LeadingIcon = null;
            this.txtXacNhanMK.Location = new System.Drawing.Point(214, 188);
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
            // fChinhSuaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 283);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMatk);
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
        private MaterialSkin.Controls.MaterialTextBox2 txtMatk;
        private MaterialSkin.Controls.MaterialTextBox2 txtMKMoi;
        private MaterialSkin.Controls.MaterialTextBox2 txtXacNhanMK;
    }
}