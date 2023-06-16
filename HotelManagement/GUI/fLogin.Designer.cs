namespace HotelManagement.GUI
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.tabControlMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.linkLblRegister = new System.Windows.Forms.LinkLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblHello = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.lblCCCD = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.registerTxtID = new MaterialSkin.Controls.MaterialTextBox();
            this.registerTxtPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.registerTxtFax = new MaterialSkin.Controls.MaterialTextBox();
            this.registerTxtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.registerTxtAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.registerTxtFullName = new MaterialSkin.Controls.MaterialTextBox();
            this.registerTxtConfirmPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.registerTxtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.registerTxtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.tabControlMenu.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabLogin);
            this.tabControlMenu.Controls.Add(this.tabRegister);
            this.tabControlMenu.Depth = 0;
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.ImageList = this.icon;
            this.tabControlMenu.Location = new System.Drawing.Point(4, 79);
            this.tabControlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMenu.Multiline = true;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1363, 654);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.materialLabel7);
            this.tabLogin.Controls.Add(this.linkLblRegister);
            this.tabLogin.Controls.Add(this.materialLabel1);
            this.tabLogin.Controls.Add(this.lblHello);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.lblPassword);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.lblUsername);
            this.tabLogin.Controls.Add(this.txtUsername);
            this.tabLogin.ImageKey = "icons8-login-48.png";
            this.tabLogin.Location = new System.Drawing.Point(4, 39);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(4);
            this.tabLogin.Size = new System.Drawing.Size(1355, 611);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Đăng nhập";
            this.tabLogin.UseVisualStyleBackColor = true;
            this.tabLogin.Click += new System.EventHandler(this.tabLogin_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(243, 484);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(168, 19);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "Bạn chưa có tài khoản?";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // linkLblRegister
            // 
            this.linkLblRegister.AutoSize = true;
            this.linkLblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLblRegister.Location = new System.Drawing.Point(468, 486);
            this.linkLblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblRegister.Name = "linkLblRegister";
            this.linkLblRegister.Size = new System.Drawing.Size(92, 26);
            this.linkLblRegister.TabIndex = 7;
            this.linkLblRegister.TabStop = true;
            this.linkLblRegister.Text = "Đăng ký";
            this.linkLblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegister_LinkClicked);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(747, 268);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(264, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "hãy đăng nhập để sử dụng ứng dụng";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Depth = 0;
            this.lblHello.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHello.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblHello.Location = new System.Drawing.Point(747, 175);
            this.lblHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHello.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(209, 58);
            this.lblHello.TabIndex = 5;
            this.lblHello.Text = "Xin chào! ";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.ImageKey = "icons8-login-96.png";
            this.btnLogin.ImageList = this.icon;
            this.btnLogin.Location = new System.Drawing.Point(243, 404);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(349, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // icon
            // 
            this.icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon.ImageStream")));
            this.icon.TransparentColor = System.Drawing.Color.Transparent;
            this.icon.Images.SetKeyName(0, "icons8-login-96.png");
            this.icon.Images.SetKeyName(1, "icons8-login-48.png");
            this.icon.Images.SetKeyName(2, "icons8-register-48.png");
            this.icon.Images.SetKeyName(3, "icons8-chart-48.png");
            this.icon.Images.SetKeyName(4, "icons8-accounting-48.png");
            this.icon.Images.SetKeyName(5, "icons8-receptionist-48.png");
            this.icon.Images.SetKeyName(6, "icons8-admin-48.png");
            this.icon.Images.SetKeyName(7, "icons8-username-48.png");
            this.icon.Images.SetKeyName(8, "icons8-password-48.png");
            this.icon.Images.SetKeyName(9, "icons8-password-key-48.png");
            this.icon.Images.SetKeyName(10, "icons8-print-48.png");
            this.icon.Images.SetKeyName(11, "icons8-bill-48.png");
            this.icon.Images.SetKeyName(12, "icons8-payment-48.png");
            this.icon.Images.SetKeyName(13, "icons8-edit-48.png");
            this.icon.Images.SetKeyName(14, "icons8-home-48.png");
            this.icon.Images.SetKeyName(15, "icons8-male-user-48.png");
            this.icon.Images.SetKeyName(16, "icons8-trash-48.png");
            this.icon.Images.SetKeyName(17, "icons8-plus-48.png");
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.ImageList = this.icon;
            this.lblPassword.Location = new System.Drawing.Point(243, 268);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsername.Location = new System.Drawing.Point(243, 143);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tên tài khoản";
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "tên tài khoản";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(243, 175);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(349, 50);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.lblCCCD);
            this.tabRegister.Controls.Add(this.materialLabel9);
            this.tabRegister.Controls.Add(this.materialLabel6);
            this.tabRegister.Controls.Add(this.materialLabel5);
            this.tabRegister.Controls.Add(this.materialLabel8);
            this.tabRegister.Controls.Add(this.materialLabel4);
            this.tabRegister.Controls.Add(this.materialLabel10);
            this.tabRegister.Controls.Add(this.materialLabel3);
            this.tabRegister.Controls.Add(this.materialLabel2);
            this.tabRegister.Controls.Add(this.registerTxtID);
            this.tabRegister.Controls.Add(this.registerTxtPhone);
            this.tabRegister.Controls.Add(this.registerTxtFax);
            this.tabRegister.Controls.Add(this.registerTxtEmail);
            this.tabRegister.Controls.Add(this.registerTxtAddress);
            this.tabRegister.Controls.Add(this.registerTxtFullName);
            this.tabRegister.Controls.Add(this.registerTxtConfirmPassword);
            this.tabRegister.Controls.Add(this.registerTxtPassword);
            this.tabRegister.Controls.Add(this.registerTxtUsername);
            this.tabRegister.ImageKey = "icons8-register-48.png";
            this.tabRegister.Location = new System.Drawing.Point(4, 39);
            this.tabRegister.Margin = new System.Windows.Forms.Padding(4);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(4);
            this.tabRegister.Size = new System.Drawing.Size(1355, 611);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Đăng ký";
            this.tabRegister.UseVisualStyleBackColor = true;
            this.tabRegister.Click += new System.EventHandler(this.tabRegister_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = false;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(976, 489);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(248, 44);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Depth = 0;
            this.lblCCCD.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCCCD.Location = new System.Drawing.Point(920, 50);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCCD.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(138, 19);
            this.lblCCCD.TabIndex = 3;
            this.lblCCCD.Text = "Căn cước công dân";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(511, 439);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(95, 19);
            this.materialLabel9.TabIndex = 3;
            this.materialLabel9.Text = "Số điện thoại";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(507, 304);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Số fax";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(507, 186);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(41, 19);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "Email";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(507, 50);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(50, 19);
            this.materialLabel8.TabIndex = 3;
            this.materialLabel8.Text = "Địa chỉ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(72, 439);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Họ tên";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(76, 304);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(139, 19);
            this.materialLabel10.TabIndex = 3;
            this.materialLabel10.Text = "Xác nhận mật khẩu";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(72, 169);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Mật khẩu";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(68, 50);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Tên tài khoản";
            // 
            // registerTxtID
            // 
            this.registerTxtID.AnimateReadOnly = false;
            this.registerTxtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtID.Depth = 0;
            this.registerTxtID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerTxtID.Hint = "căn cước công dân";
            this.registerTxtID.LeadingIcon = null;
            this.registerTxtID.Location = new System.Drawing.Point(920, 82);
            this.registerTxtID.Margin = new System.Windows.Forms.Padding(4);
            this.registerTxtID.MaxLength = 50;
            this.registerTxtID.MouseState = MaterialSkin.MouseState.OUT;
            this.registerTxtID.Multiline = false;
            this.registerTxtID.Name = "registerTxtID";
            this.registerTxtID.Size = new System.Drawing.Size(349, 50);
            this.registerTxtID.TabIndex = 9;
            this.registerTxtID.Text = "";
            this.registerTxtID.TrailingIcon = null;
            // 
            // registerTxtPhone
            // 
            this.registerTxtPhone.AnimateReadOnly = false;
            this.registerTxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtPhone.Depth = 0;
            this.registerTxtPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerTxtPhone.Hint = "số điện thoại";
            this.registerTxtPhone.LeadingIcon = null;
            this.registerTxtPhone.Location = new System.Drawing.Point(511, 471);
            this.registerTxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.registerTxtPhone.MaxLength = 50;
            this.registerTxtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.registerTxtPhone.Multiline = false;
            this.registerTxtPhone.Name = "registerTxtPhone";
            this.registerTxtPhone.Size = new System.Drawing.Size(349, 50);
            this.registerTxtPhone.TabIndex = 8;
            this.registerTxtPhone.Text = "";
            this.registerTxtPhone.TrailingIcon = null;
            // 
            // registerTxtFax
            // 
            this.registerTxtFax.AnimateReadOnly = false;
            this.registerTxtFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtFax.Depth = 0;
            this.registerTxtFax.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerTxtFax.Hint = "số fax";
            this.registerTxtFax.LeadingIcon = null;
            this.registerTxtFax.Location = new System.Drawing.Point(507, 336);
            this.registerTxtFax.Margin = new System.Windows.Forms.Padding(4);
            this.registerTxtFax.MaxLength = 50;
            this.registerTxtFax.MouseState = MaterialSkin.MouseState.OUT;
            this.registerTxtFax.Multiline = false;
            this.registerTxtFax.Name = "registerTxtFax";
            this.registerTxtFax.Size = new System.Drawing.Size(349, 50);
            this.registerTxtFax.TabIndex = 7;
            this.registerTxtFax.Text = "";
            this.registerTxtFax.TrailingIcon = null;
            // 
            // registerTxtEmail
            // 
            this.registerTxtEmail.AnimateReadOnly = false;
            this.registerTxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtEmail.Depth = 0;
            this.registerTxtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerTxtEmail.Hint = "email";
            this.registerTxtEmail.LeadingIcon = null;
            this.registerTxtEmail.Location = new System.Drawing.Point(507, 218);
            this.registerTxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.registerTxtEmail.MaxLength = 50;
            this.registerTxtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.registerTxtEmail.Multiline = false;
            this.registerTxtEmail.Name = "registerTxtEmail";
            this.registerTxtEmail.Size = new System.Drawing.Size(349, 50);
            this.registerTxtEmail.TabIndex = 6;
            this.registerTxtEmail.Text = "";
            this.registerTxtEmail.TrailingIcon = null;
            // 
            // registerTxtAddress
            // 
            this.registerTxtAddress.AnimateReadOnly = false;
            this.registerTxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtAddress.Depth = 0;
            this.registerTxtAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerTxtAddress.Hint = "địa chỉ";
            this.registerTxtAddress.LeadingIcon = null;
            this.registerTxtAddress.Location = new System.Drawing.Point(507, 82);
            this.registerTxtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.registerTxtAddress.MaxLength = 50;
            this.registerTxtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.registerTxtAddress.Multiline = false;
            this.registerTxtAddress.Name = "registerTxtAddress";
            this.registerTxtAddress.Size = new System.Drawing.Size(349, 50);
            this.registerTxtAddress.TabIndex = 5;
            this.registerTxtAddress.Text = "";
            this.registerTxtAddress.TrailingIcon = null;
            // 
            // registerTxtFullName
            // 
            this.registerTxtFullName.AnimateReadOnly = false;
            this.registerTxtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtFullName.Depth = 0;
            this.registerTxtFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerTxtFullName.Hint = "họ tên";
            this.registerTxtFullName.LeadingIcon = null;
            this.registerTxtFullName.Location = new System.Drawing.Point(72, 471);
            this.registerTxtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.registerTxtFullName.MaxLength = 50;
            this.registerTxtFullName.MouseState = MaterialSkin.MouseState.OUT;
            this.registerTxtFullName.Multiline = false;
            this.registerTxtFullName.Name = "registerTxtFullName";
            this.registerTxtFullName.Size = new System.Drawing.Size(349, 50);
            this.registerTxtFullName.TabIndex = 4;
            this.registerTxtFullName.Text = "";
            this.registerTxtFullName.TrailingIcon = null;
            // 
            // registerTxtConfirmPassword
            // 
            this.registerTxtConfirmPassword.AnimateReadOnly = false;
            this.registerTxtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtConfirmPassword.Depth = 0;
            this.registerTxtConfirmPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerTxtConfirmPassword.Hint = "xác nhận mật khẩu";
            this.registerTxtConfirmPassword.LeadingIcon = null;
            this.registerTxtConfirmPassword.Location = new System.Drawing.Point(76, 336);
            this.registerTxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.registerTxtConfirmPassword.MaxLength = 50;
            this.registerTxtConfirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.registerTxtConfirmPassword.Multiline = false;
            this.registerTxtConfirmPassword.Name = "registerTxtConfirmPassword";
            this.registerTxtConfirmPassword.Password = true;
            this.registerTxtConfirmPassword.Size = new System.Drawing.Size(349, 50);
            this.registerTxtConfirmPassword.TabIndex = 3;
            this.registerTxtConfirmPassword.Text = "";
            this.registerTxtConfirmPassword.TrailingIcon = null;
            // 
            // registerTxtPassword
            // 
            this.registerTxtPassword.AnimateReadOnly = false;
            this.registerTxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtPassword.Depth = 0;
            this.registerTxtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerTxtPassword.Hint = "mật khẩu";
            this.registerTxtPassword.LeadingIcon = null;
            this.registerTxtPassword.Location = new System.Drawing.Point(72, 201);
            this.registerTxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.registerTxtPassword.MaxLength = 50;
            this.registerTxtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.registerTxtPassword.Multiline = false;
            this.registerTxtPassword.Name = "registerTxtPassword";
            this.registerTxtPassword.Password = true;
            this.registerTxtPassword.Size = new System.Drawing.Size(349, 50);
            this.registerTxtPassword.TabIndex = 2;
            this.registerTxtPassword.Text = "";
            this.registerTxtPassword.TrailingIcon = null;
            // 
            // registerTxtUsername
            // 
            this.registerTxtUsername.AnimateReadOnly = false;
            this.registerTxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerTxtUsername.Depth = 0;
            this.registerTxtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registerTxtUsername.Hint = "tên tài khoản";
            this.registerTxtUsername.LeadingIcon = null;
            this.registerTxtUsername.Location = new System.Drawing.Point(68, 82);
            this.registerTxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.registerTxtUsername.MaxLength = 50;
            this.registerTxtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.registerTxtUsername.Multiline = false;
            this.registerTxtUsername.Name = "registerTxtUsername";
            this.registerTxtUsername.Size = new System.Drawing.Size(349, 50);
            this.registerTxtUsername.TabIndex = 1;
            this.registerTxtUsername.Text = "";
            this.registerTxtUsername.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "mật khẩu";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(243, 300);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(349, 50);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 737);
            this.Controls.Add(this.tabControlMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControlMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLogin";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.ImageList icon;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialLabel lblHello;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnRegister;
        private MaterialSkin.Controls.MaterialLabel lblCCCD;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox registerTxtID;
        private MaterialSkin.Controls.MaterialTextBox registerTxtFax;
        private MaterialSkin.Controls.MaterialTextBox registerTxtEmail;
        private MaterialSkin.Controls.MaterialTextBox registerTxtAddress;
        private MaterialSkin.Controls.MaterialTextBox registerTxtFullName;
        private MaterialSkin.Controls.MaterialTextBox registerTxtPassword;
        private MaterialSkin.Controls.MaterialTextBox registerTxtUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.LinkLabel linkLblRegister;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox registerTxtConfirmPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox registerTxtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
    }
}