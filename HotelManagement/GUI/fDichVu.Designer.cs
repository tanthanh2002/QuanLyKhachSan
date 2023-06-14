
namespace HotelManagement.GUI
{
    partial class fDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDichVu));
            this.tabDichVu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDSDV = new System.Windows.Forms.TabPage();
            this.tabDVCuaToi = new System.Windows.Forms.TabPage();
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbTenDichVu = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDVHoTro = new System.Windows.Forms.DataGridView();
            this.dgvDVKhongHoTro = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvDSDVDaDK = new System.Windows.Forms.DataGridView();
            this.tabDichVu.SuspendLayout();
            this.tabDSDV.SuspendLayout();
            this.tabDVCuaToi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVHoTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVKhongHoTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDVDaDK)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.tabDSDV);
            this.tabDichVu.Controls.Add(this.tabDVCuaToi);
            this.tabDichVu.Depth = 0;
            this.tabDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDichVu.ImageList = this.icon;
            this.tabDichVu.Location = new System.Drawing.Point(3, 64);
            this.tabDichVu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabDichVu.Multiline = true;
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.SelectedIndex = 0;
            this.tabDichVu.Size = new System.Drawing.Size(1194, 563);
            this.tabDichVu.TabIndex = 0;
            // 
            // tabDSDV
            // 
            this.tabDSDV.Controls.Add(this.groupBox2);
            this.tabDSDV.Controls.Add(this.tbTenDichVu);
            this.tabDSDV.Controls.Add(this.materialLabel1);
            this.tabDSDV.Controls.Add(this.groupBox1);
            this.tabDSDV.ImageKey = "list.png";
            this.tabDSDV.Location = new System.Drawing.Point(4, 39);
            this.tabDSDV.Name = "tabDSDV";
            this.tabDSDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSDV.Size = new System.Drawing.Size(1186, 520);
            this.tabDSDV.TabIndex = 0;
            this.tabDSDV.Text = "Danh sách dịch vụ";
            this.tabDSDV.UseVisualStyleBackColor = true;
            // 
            // tabDVCuaToi
            // 
            this.tabDVCuaToi.Controls.Add(this.dgvDSDVDaDK);
            this.tabDVCuaToi.Controls.Add(this.materialLabel2);
            this.tabDVCuaToi.ImageKey = "shopping-list.png";
            this.tabDVCuaToi.Location = new System.Drawing.Point(4, 39);
            this.tabDVCuaToi.Name = "tabDVCuaToi";
            this.tabDVCuaToi.Padding = new System.Windows.Forms.Padding(3);
            this.tabDVCuaToi.Size = new System.Drawing.Size(1186, 520);
            this.tabDVCuaToi.TabIndex = 1;
            this.tabDVCuaToi.Text = "Dịch vụ của tôi";
            this.tabDVCuaToi.UseVisualStyleBackColor = true;
            // 
            // icon
            // 
            this.icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon.ImageStream")));
            this.icon.TransparentColor = System.Drawing.Color.Transparent;
            this.icon.Images.SetKeyName(0, "list.png");
            this.icon.Images.SetKeyName(1, "shopping-list.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDVHoTro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ có hỗ trợ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(31, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Tên dịch vụ:";
            // 
            // tbTenDichVu
            // 
            this.tbTenDichVu.AnimateReadOnly = false;
            this.tbTenDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenDichVu.Depth = 0;
            this.tbTenDichVu.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTenDichVu.LeadingIcon = null;
            this.tbTenDichVu.Location = new System.Drawing.Point(149, 15);
            this.tbTenDichVu.MaxLength = 50;
            this.tbTenDichVu.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTenDichVu.Multiline = false;
            this.tbTenDichVu.Name = "tbTenDichVu";
            this.tbTenDichVu.Size = new System.Drawing.Size(287, 50);
            this.tbTenDichVu.TabIndex = 2;
            this.tbTenDichVu.Text = "";
            this.tbTenDichVu.TrailingIcon = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDVKhongHoTro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(605, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 408);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ không hỗ trợ";
            // 
            // dgvDVHoTro
            // 
            this.dgvDVHoTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVHoTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDVHoTro.Location = new System.Drawing.Point(3, 26);
            this.dgvDVHoTro.Name = "dgvDVHoTro";
            this.dgvDVHoTro.RowHeadersWidth = 51;
            this.dgvDVHoTro.RowTemplate.Height = 24;
            this.dgvDVHoTro.Size = new System.Drawing.Size(552, 379);
            this.dgvDVHoTro.TabIndex = 0;
            // 
            // dgvDVKhongHoTro
            // 
            this.dgvDVKhongHoTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVKhongHoTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDVKhongHoTro.Location = new System.Drawing.Point(3, 26);
            this.dgvDVKhongHoTro.Name = "dgvDVKhongHoTro";
            this.dgvDVKhongHoTro.RowHeadersWidth = 51;
            this.dgvDVKhongHoTro.RowTemplate.Height = 24;
            this.dgvDVKhongHoTro.Size = new System.Drawing.Size(553, 379);
            this.dgvDVKhongHoTro.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(480, 17);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(216, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Danh sách dịch vụ đã đăng ký";
            // 
            // dgvDSDVDaDK
            // 
            this.dgvDSDVDaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDVDaDK.Location = new System.Drawing.Point(6, 52);
            this.dgvDSDVDaDK.Name = "dgvDSDVDaDK";
            this.dgvDSDVDaDK.RowHeadersWidth = 51;
            this.dgvDSDVDaDK.RowTemplate.Height = 24;
            this.dgvDSDVDaDK.Size = new System.Drawing.Size(1174, 462);
            this.dgvDSDVDaDK.TabIndex = 1;
            this.dgvDSDVDaDK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDVDaDK_CellContentClick);
            // 
            // fDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 630);
            this.Controls.Add(this.tabDichVu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabDichVu;
            this.Name = "fDichVu";
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.fDichVu_Load);
            this.tabDichVu.ResumeLayout(false);
            this.tabDSDV.ResumeLayout(false);
            this.tabDSDV.PerformLayout();
            this.tabDVCuaToi.ResumeLayout(false);
            this.tabDVCuaToi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVHoTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVKhongHoTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDVDaDK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabDichVu;
        private System.Windows.Forms.TabPage tabDSDV;
        private System.Windows.Forms.TabPage tabDVCuaToi;
        private System.Windows.Forms.ImageList icon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDVKhongHoTro;
        private MaterialSkin.Controls.MaterialTextBox tbTenDichVu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvDVHoTro;
        private System.Windows.Forms.DataGridView dgvDSDVDaDK;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}