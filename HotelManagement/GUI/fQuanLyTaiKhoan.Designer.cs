namespace HotelManagement.GUI
{
    partial class fQuanLyTaiKhoan
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
            this.txtMaTK = new MaterialSkin.Controls.MaterialTextBox();
            this.btTHemTK = new MaterialSkin.Controls.MaterialButton();
            this.btChinhSua = new MaterialSkin.Controls.MaterialButton();
            this.btKhoaTK = new MaterialSkin.Controls.MaterialButton();
            this.btMoTK = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewdstk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdstk)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(29, 110);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mã Tài Khoản";
            // 
            // txtMaTK
            // 
            this.txtMaTK.AnimateReadOnly = false;
            this.txtMaTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaTK.Depth = 0;
            this.txtMaTK.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaTK.LeadingIcon = null;
            this.txtMaTK.Location = new System.Drawing.Point(145, 86);
            this.txtMaTK.MaxLength = 50;
            this.txtMaTK.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaTK.Multiline = false;
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(282, 50);
            this.txtMaTK.TabIndex = 1;
            this.txtMaTK.Text = "";
            this.txtMaTK.TrailingIcon = null;
            // 
            // btTHemTK
            // 
            this.btTHemTK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btTHemTK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btTHemTK.Depth = 0;
            this.btTHemTK.HighEmphasis = true;
            this.btTHemTK.Icon = null;
            this.btTHemTK.Location = new System.Drawing.Point(32, 161);
            this.btTHemTK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btTHemTK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btTHemTK.Name = "btTHemTK";
            this.btTHemTK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btTHemTK.Size = new System.Drawing.Size(142, 36);
            this.btTHemTK.TabIndex = 2;
            this.btTHemTK.Text = "Thêm Tài Khoản";
            this.btTHemTK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btTHemTK.UseAccentColor = false;
            this.btTHemTK.UseVisualStyleBackColor = true;
            this.btTHemTK.Click += new System.EventHandler(this.btTHemTK_Click);
            // 
            // btChinhSua
            // 
            this.btChinhSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btChinhSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btChinhSua.Depth = 0;
            this.btChinhSua.HighEmphasis = true;
            this.btChinhSua.Icon = null;
            this.btChinhSua.Location = new System.Drawing.Point(277, 161);
            this.btChinhSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btChinhSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btChinhSua.Name = "btChinhSua";
            this.btChinhSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btChinhSua.Size = new System.Drawing.Size(99, 36);
            this.btChinhSua.TabIndex = 3;
            this.btChinhSua.Text = "Chỉnh Sửa";
            this.btChinhSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btChinhSua.UseAccentColor = false;
            this.btChinhSua.UseVisualStyleBackColor = true;
            this.btChinhSua.Click += new System.EventHandler(this.btChinhSua_Click);
            // 
            // btKhoaTK
            // 
            this.btKhoaTK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btKhoaTK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btKhoaTK.Depth = 0;
            this.btKhoaTK.HighEmphasis = true;
            this.btKhoaTK.Icon = null;
            this.btKhoaTK.Location = new System.Drawing.Point(482, 161);
            this.btKhoaTK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btKhoaTK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btKhoaTK.Name = "btKhoaTK";
            this.btKhoaTK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btKhoaTK.Size = new System.Drawing.Size(141, 36);
            this.btKhoaTK.TabIndex = 4;
            this.btKhoaTK.Text = "Khóa Tài Khoản";
            this.btKhoaTK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btKhoaTK.UseAccentColor = false;
            this.btKhoaTK.UseVisualStyleBackColor = true;
            this.btKhoaTK.Click += new System.EventHandler(this.btKhoaTK_Click);
            // 
            // btMoTK
            // 
            this.btMoTK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btMoTK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btMoTK.Depth = 0;
            this.btMoTK.HighEmphasis = true;
            this.btMoTK.Icon = null;
            this.btMoTK.Location = new System.Drawing.Point(730, 161);
            this.btMoTK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btMoTK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btMoTK.Name = "btMoTK";
            this.btMoTK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btMoTK.Size = new System.Drawing.Size(125, 36);
            this.btMoTK.TabIndex = 5;
            this.btMoTK.Text = "Mở Tài Khoản";
            this.btMoTK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btMoTK.UseAccentColor = false;
            this.btMoTK.UseVisualStyleBackColor = true;
            this.btMoTK.Click += new System.EventHandler(this.btMoTK_Click);
            // 
            // dataGridViewdstk
            // 
            this.dataGridViewdstk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdstk.Location = new System.Drawing.Point(18, 218);
            this.dataGridViewdstk.Name = "dataGridViewdstk";
            this.dataGridViewdstk.RowHeadersWidth = 51;
            this.dataGridViewdstk.RowTemplate.Height = 24;
            this.dataGridViewdstk.Size = new System.Drawing.Size(876, 287);
            this.dataGridViewdstk.TabIndex = 6;
            // 
            // fQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 514);
            this.Controls.Add(this.dataGridViewdstk);
            this.Controls.Add(this.btMoTK);
            this.Controls.Add(this.btKhoaTK);
            this.Controls.Add(this.btChinhSua);
            this.Controls.Add(this.btTHemTK);
            this.Controls.Add(this.txtMaTK);
            this.Controls.Add(this.materialLabel1);
            this.Name = "fQuanLyTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdstk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtMaTK;
        private MaterialSkin.Controls.MaterialButton btTHemTK;
        private MaterialSkin.Controls.MaterialButton btChinhSua;
        private MaterialSkin.Controls.MaterialButton btKhoaTK;
        private MaterialSkin.Controls.MaterialButton btMoTK;
        private System.Windows.Forms.DataGridView dataGridViewdstk;
    }
}