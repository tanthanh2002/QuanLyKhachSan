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
            this.listViewTimPhong = new MaterialSkin.Controls.MaterialListView();
            this.btnXong = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(44, 80);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.materialLabel2.Location = new System.Drawing.Point(71, 110);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.materialLabel3.Location = new System.Drawing.Point(71, 145);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.materialLabel4.Location = new System.Drawing.Point(44, 177);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.checkBinhDan.Location = new System.Drawing.Point(186, 104);
            this.checkBinhDan.Margin = new System.Windows.Forms.Padding(0);
            this.checkBinhDan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBinhDan.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBinhDan.Name = "checkBinhDan";
            this.checkBinhDan.ReadOnly = false;
            this.checkBinhDan.Ripple = true;
            this.checkBinhDan.Size = new System.Drawing.Size(98, 37);
            this.checkBinhDan.TabIndex = 4;
            this.checkBinhDan.Text = "Bình dân";
            this.checkBinhDan.UseVisualStyleBackColor = true;
            // 
            // checkPhongDon
            // 
            this.checkPhongDon.AutoSize = true;
            this.checkPhongDon.Depth = 0;
            this.checkPhongDon.Location = new System.Drawing.Point(186, 137);
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
            this.checkCaoCap.Location = new System.Drawing.Point(316, 104);
            this.checkCaoCap.Margin = new System.Windows.Forms.Padding(0);
            this.checkCaoCap.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkCaoCap.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkCaoCap.Name = "checkCaoCap";
            this.checkCaoCap.ReadOnly = false;
            this.checkCaoCap.Ripple = true;
            this.checkCaoCap.Size = new System.Drawing.Size(93, 37);
            this.checkCaoCap.TabIndex = 6;
            this.checkCaoCap.Text = "Cao cấp";
            this.checkCaoCap.UseVisualStyleBackColor = true;
            // 
            // checkPhongDoi
            // 
            this.checkPhongDoi.AutoSize = true;
            this.checkPhongDoi.Depth = 0;
            this.checkPhongDoi.Location = new System.Drawing.Point(316, 137);
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
            // listViewTimPhong
            // 
            this.listViewTimPhong.AutoSizeTable = false;
            this.listViewTimPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewTimPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTimPhong.Depth = 0;
            this.listViewTimPhong.FullRowSelect = true;
            this.listViewTimPhong.HideSelection = false;
            this.listViewTimPhong.Location = new System.Drawing.Point(46, 215);
            this.listViewTimPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewTimPhong.MinimumSize = new System.Drawing.Size(150, 81);
            this.listViewTimPhong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewTimPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewTimPhong.Name = "listViewTimPhong";
            this.listViewTimPhong.OwnerDraw = true;
            this.listViewTimPhong.Size = new System.Drawing.Size(521, 122);
            this.listViewTimPhong.TabIndex = 8;
            this.listViewTimPhong.UseCompatibleStateImageBehavior = false;
            this.listViewTimPhong.View = System.Windows.Forms.View.Details;
            // 
            // btnXong
            // 
            this.btnXong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXong.Depth = 0;
            this.btnXong.HighEmphasis = true;
            this.btnXong.Icon = null;
            this.btnXong.Location = new System.Drawing.Point(503, 357);
            this.btnXong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnXong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXong.Name = "btnXong";
            this.btnXong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXong.Size = new System.Drawing.Size(64, 36);
            this.btnXong.TabIndex = 9;
            this.btnXong.Text = "Xong";
            this.btnXong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXong.UseAccentColor = false;
            this.btnXong.UseVisualStyleBackColor = true;
            // 
            // fRoomSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.listViewTimPhong);
            this.Controls.Add(this.checkPhongDoi);
            this.Controls.Add(this.checkCaoCap);
            this.Controls.Add(this.checkPhongDon);
            this.Controls.Add(this.checkBinhDan);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fRoomSearch";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Tìm kiếm phòng";
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
        private MaterialSkin.Controls.MaterialListView listViewTimPhong;
        private MaterialSkin.Controls.MaterialButton btnXong;
    }
}