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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.checkBinhDan = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkPhongDon = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkCaoCap = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkPhongDoi = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnXong = new MaterialSkin.Controls.MaterialButton();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewKetQua = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(59, 98);
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
            this.materialLabel2.Location = new System.Drawing.Point(95, 135);
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
            this.materialLabel3.Location = new System.Drawing.Point(95, 178);
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
            this.materialLabel4.Location = new System.Drawing.Point(59, 218);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(120, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Kết quả tìm kiếm";
            // 
            // checkBinhDan
            // 
            this.checkBinhDan.AutoSize = true;
            this.checkBinhDan.Depth = 0;
            this.checkBinhDan.Location = new System.Drawing.Point(248, 128);
            this.checkBinhDan.Margin = new System.Windows.Forms.Padding(0);
            this.checkBinhDan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBinhDan.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBinhDan.Name = "checkBinhDan";
            this.checkBinhDan.ReadOnly = false;
            this.checkBinhDan.Ripple = true;
            this.checkBinhDan.Size = new System.Drawing.Size(106, 37);
            this.checkBinhDan.TabIndex = 4;
            this.checkBinhDan.Text = "2.000.000";
            this.checkBinhDan.UseVisualStyleBackColor = true;
            // 
            // checkPhongDon
            // 
            this.checkPhongDon.AutoSize = true;
            this.checkPhongDon.Depth = 0;
            this.checkPhongDon.Location = new System.Drawing.Point(248, 169);
            this.checkPhongDon.Margin = new System.Windows.Forms.Padding(0);
            this.checkPhongDon.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkPhongDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkPhongDon.Name = "checkPhongDon";
            this.checkPhongDon.ReadOnly = false;
            this.checkPhongDon.Ripple = true;
            this.checkPhongDon.Size = new System.Drawing.Size(113, 37);
            this.checkPhongDon.TabIndex = 5;
            this.checkPhongDon.Text = "Phòng đơn";
            this.checkPhongDon.UseVisualStyleBackColor = true;
            // 
            // checkCaoCap
            // 
            this.checkCaoCap.AutoSize = true;
            this.checkCaoCap.Depth = 0;
            this.checkCaoCap.Location = new System.Drawing.Point(421, 128);
            this.checkCaoCap.Margin = new System.Windows.Forms.Padding(0);
            this.checkCaoCap.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkCaoCap.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkCaoCap.Name = "checkCaoCap";
            this.checkCaoCap.ReadOnly = false;
            this.checkCaoCap.Ripple = true;
            this.checkCaoCap.Size = new System.Drawing.Size(106, 37);
            this.checkCaoCap.TabIndex = 6;
            this.checkCaoCap.Text = "5.000.000";
            this.checkCaoCap.UseVisualStyleBackColor = true;
            // 
            // checkPhongDoi
            // 
            this.checkPhongDoi.AutoSize = true;
            this.checkPhongDoi.Depth = 0;
            this.checkPhongDoi.Location = new System.Drawing.Point(421, 169);
            this.checkPhongDoi.Margin = new System.Windows.Forms.Padding(0);
            this.checkPhongDoi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkPhongDoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkPhongDoi.Name = "checkPhongDoi";
            this.checkPhongDoi.ReadOnly = false;
            this.checkPhongDoi.Ripple = true;
            this.checkPhongDoi.Size = new System.Drawing.Size(108, 37);
            this.checkPhongDoi.TabIndex = 7;
            this.checkPhongDoi.Text = "Phòng đôi";
            this.checkPhongDoi.UseVisualStyleBackColor = true;
            // 
            // btnXong
            // 
            this.btnXong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXong.Depth = 0;
            this.btnXong.HighEmphasis = true;
            this.btnXong.Icon = null;
            this.btnXong.Location = new System.Drawing.Point(671, 439);
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
            this.btnTimKiem.Location = new System.Drawing.Point(550, 439);
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
            // dataGridViewKetQua
            // 
            this.dataGridViewKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKetQua.Location = new System.Drawing.Point(62, 254);
            this.dataGridViewKetQua.Name = "dataGridViewKetQua";
            this.dataGridViewKetQua.RowHeadersWidth = 51;
            this.dataGridViewKetQua.Size = new System.Drawing.Size(673, 149);
            this.dataGridViewKetQua.TabIndex = 11;
            // 
            // fRoomSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dataGridViewKetQua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.checkPhongDoi);
            this.Controls.Add(this.checkCaoCap);
            this.Controls.Add(this.checkPhongDon);
            this.Controls.Add(this.checkBinhDan);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fRoomSearch";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Tìm kiếm phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckbox checkBinhDan;
        private MaterialSkin.Controls.MaterialCheckbox checkPhongDon;
        private MaterialSkin.Controls.MaterialCheckbox checkCaoCap;
        private MaterialSkin.Controls.MaterialCheckbox checkPhongDoi;
        private MaterialSkin.Controls.MaterialButton btnXong;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewKetQua;
    }
}