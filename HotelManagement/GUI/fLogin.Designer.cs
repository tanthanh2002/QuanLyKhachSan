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
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.lblHello = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabControlMenu.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabLogin);
            this.tabControlMenu.Controls.Add(this.tabRegister);
            this.tabControlMenu.Depth = 0;
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.ImageList = this.icon;
            this.tabControlMenu.Location = new System.Drawing.Point(3, 64);
            this.tabControlMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMenu.Multiline = true;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(794, 383);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.materialLabel1);
            this.tabLogin.Controls.Add(this.lblHello);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.lblPassword);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.lblUsername);
            this.tabLogin.Controls.Add(this.txtUsername);
            this.tabLogin.ImageKey = "icons8-login-48.png";
            this.tabLogin.Location = new System.Drawing.Point(4, 39);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(786, 340);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Đăng nhập";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // tabRegister
            // 
            this.tabRegister.ImageKey = "icons8-register-48.png";
            this.tabRegister.Location = new System.Drawing.Point(4, 39);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(192, 57);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Đăng ký";
            this.tabRegister.UseVisualStyleBackColor = true;
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
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "username";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(28, 55);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(262, 50);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsername.Location = new System.Drawing.Point(28, 29);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "********";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(28, 157);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(262, 50);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.ImageList = this.icon;
            this.lblPassword.Location = new System.Drawing.Point(28, 131);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "password";
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
            this.btnLogin.Location = new System.Drawing.Point(28, 237);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(262, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Depth = 0;
            this.lblHello.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHello.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblHello.Location = new System.Drawing.Point(406, 55);
            this.lblHello.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(209, 58);
            this.lblHello.TabIndex = 5;
            this.lblHello.Text = "Xin chào! ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(406, 131);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(262, 20);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "hãy đăng nhập để sử dụng ứng dụng";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControlMenu;
            this.Name = "fLogin";
            this.Sizable = false;
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.ImageList icon;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialLabel lblHello;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}