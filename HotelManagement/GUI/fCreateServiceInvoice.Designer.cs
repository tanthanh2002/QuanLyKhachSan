namespace HotelManagement.GUI
{
    partial class fCreateServiceInvoice
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
            this.listViewDSDonDatPhong = new MaterialSkin.Controls.MaterialListView();
            this.btnTaoHoaDon = new MaterialSkin.Controls.MaterialButton();
            this.tabcontrol = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDanhSach = new System.Windows.Forms.TabPage();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabcontrol.SuspendLayout();
            this.tabDanhSach.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(26, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(215, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Danh sách các đơn đặt phòng";
            // 
            // listViewDSDonDatPhong
            // 
            this.listViewDSDonDatPhong.AutoSizeTable = false;
            this.listViewDSDonDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewDSDonDatPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDSDonDatPhong.Depth = 0;
            this.listViewDSDonDatPhong.FullRowSelect = true;
            this.listViewDSDonDatPhong.HideSelection = false;
            this.listViewDSDonDatPhong.Location = new System.Drawing.Point(29, 86);
            this.listViewDSDonDatPhong.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewDSDonDatPhong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewDSDonDatPhong.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewDSDonDatPhong.Name = "listViewDSDonDatPhong";
            this.listViewDSDonDatPhong.OwnerDraw = true;
            this.listViewDSDonDatPhong.Size = new System.Drawing.Size(675, 206);
            this.listViewDSDonDatPhong.TabIndex = 1;
            this.listViewDSDonDatPhong.UseCompatibleStateImageBehavior = false;
            this.listViewDSDonDatPhong.View = System.Windows.Forms.View.Details;
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaoHoaDon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTaoHoaDon.Depth = 0;
            this.btnTaoHoaDon.HighEmphasis = true;
            this.btnTaoHoaDon.Icon = null;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(586, 313);
            this.btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTaoHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTaoHoaDon.Size = new System.Drawing.Size(118, 36);
            this.btnTaoHoaDon.TabIndex = 2;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTaoHoaDon.UseAccentColor = false;
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabDanhSach);
            this.tabcontrol.Controls.Add(this.tabHoaDon);
            this.tabcontrol.Depth = 0;
            this.tabcontrol.Location = new System.Drawing.Point(20, 79);
            this.tabcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabcontrol.Multiline = true;
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(751, 397);
            this.tabcontrol.TabIndex = 3;
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Controls.Add(this.listViewDSDonDatPhong);
            this.tabDanhSach.Controls.Add(this.btnTaoHoaDon);
            this.tabDanhSach.Controls.Add(this.materialLabel1);
            this.tabDanhSach.Location = new System.Drawing.Point(4, 25);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhSach.Size = new System.Drawing.Size(743, 368);
            this.tabDanhSach.TabIndex = 0;
            this.tabDanhSach.Text = "DanhSach";
            this.tabDanhSach.UseVisualStyleBackColor = true;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.materialLabel3);
            this.tabHoaDon.Controls.Add(this.materialLabel2);
            this.tabHoaDon.Controls.Add(this.materialButton1);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 25);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoaDon.Size = new System.Drawing.Size(743, 368);
            this.tabHoaDon.TabIndex = 1;
            this.tabHoaDon.Text = "HoaDon";
            this.tabHoaDon.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(578, 297);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(117, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Lưu Hóa Đơn";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel2.Location = new System.Drawing.Point(47, 33);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Mã hóa đơn";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel3.Location = new System.Drawing.Point(47, 81);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Tổng tiền";
            // 
            // fCreateServiceInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabcontrol);
            this.Name = "fCreateServiceInvoice";
            this.Text = "Tạo hóa đơn dịch vụ";
            this.tabcontrol.ResumeLayout(false);
            this.tabDanhSach.ResumeLayout(false);
            this.tabDanhSach.PerformLayout();
            this.tabHoaDon.ResumeLayout(false);
            this.tabHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView listViewDSDonDatPhong;
        private MaterialSkin.Controls.MaterialButton btnTaoHoaDon;
        private MaterialSkin.Controls.MaterialTabControl tabcontrol;
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.TabPage tabHoaDon;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}