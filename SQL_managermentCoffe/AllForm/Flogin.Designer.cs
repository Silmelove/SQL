namespace SQL_managermentCoffe.AllForm
{
    partial class Flogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lb_login = new Label();
            txb_User = new Guna.UI2.WinForms.Guna2TextBox();
            txb_passwrod = new Guna.UI2.WinForms.Guna2TextBox();
            btn_lock = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btn_imageUser = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btn_login = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // lb_login
            // 
            lb_login.AutoSize = true;
            lb_login.BackColor = Color.Transparent;
            lb_login.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_login.ForeColor = Color.CadetBlue;
            lb_login.Location = new Point(172, 54);
            lb_login.Name = "lb_login";
            lb_login.Size = new Size(152, 38);
            lb_login.TabIndex = 0;
            lb_login.Text = "Login User";
            // 
            // txb_User
            // 
            txb_User.BorderColor = Color.Black;
            txb_User.CustomizableEdges = customizableEdges1;
            txb_User.DefaultText = "";
            txb_User.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txb_User.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txb_User.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txb_User.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txb_User.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txb_User.Font = new Font("Segoe UI", 9F);
            txb_User.ForeColor = Color.Black;
            txb_User.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txb_User.Location = new Point(112, 127);
            txb_User.Margin = new Padding(3, 4, 3, 4);
            txb_User.Name = "txb_User";
            txb_User.PasswordChar = '\0';
            txb_User.PlaceholderText = "Enter Name";
            txb_User.SelectedText = "";
            txb_User.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txb_User.Size = new Size(286, 35);
            txb_User.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txb_User.TabIndex = 1;
            // 
            // txb_passwrod
            // 
            txb_passwrod.BorderColor = Color.Black;
            txb_passwrod.CustomizableEdges = customizableEdges3;
            txb_passwrod.DefaultText = "";
            txb_passwrod.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txb_passwrod.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txb_passwrod.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txb_passwrod.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txb_passwrod.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txb_passwrod.Font = new Font("Segoe UI", 9F);
            txb_passwrod.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txb_passwrod.Location = new Point(112, 179);
            txb_passwrod.Margin = new Padding(3, 4, 3, 4);
            txb_passwrod.Name = "txb_passwrod";
            txb_passwrod.PasswordChar = '●';
            txb_passwrod.PlaceholderForeColor = Color.FromArgb(213, 218, 223);
            txb_passwrod.PlaceholderText = "Enter Password";
            txb_passwrod.SelectedText = "";
            txb_passwrod.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txb_passwrod.Size = new Size(286, 35);
            txb_passwrod.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txb_passwrod.TabIndex = 2;
            txb_passwrod.UseSystemPasswordChar = true;
            // 
            // btn_lock
            // 
            btn_lock.CustomizableEdges = customizableEdges5;
            btn_lock.DisabledState.BorderColor = Color.DarkGray;
            btn_lock.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_lock.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_lock.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_lock.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_lock.FillColor = Color.Transparent;
            btn_lock.FillColor2 = Color.Transparent;
            btn_lock.Font = new Font("Segoe UI", 9F);
            btn_lock.ForeColor = Color.White;
            btn_lock.Image = Properties.Resources._lock;
            btn_lock.ImageSize = new Size(25, 25);
            btn_lock.Location = new Point(70, 179);
            btn_lock.Name = "btn_lock";
            btn_lock.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_lock.Size = new Size(36, 34);
            btn_lock.TabIndex = 4;
            // 
            // btn_imageUser
            // 
            btn_imageUser.CustomizableEdges = customizableEdges7;
            btn_imageUser.DisabledState.BorderColor = Color.DarkGray;
            btn_imageUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_imageUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_imageUser.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_imageUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_imageUser.FillColor = Color.Transparent;
            btn_imageUser.FillColor2 = Color.Transparent;
            btn_imageUser.Font = new Font("Segoe UI", 9F);
            btn_imageUser.ForeColor = Color.White;
            btn_imageUser.Image = Properties.Resources.user;
            btn_imageUser.ImageSize = new Size(25, 25);
            btn_imageUser.Location = new Point(70, 127);
            btn_imageUser.Name = "btn_imageUser";
            btn_imageUser.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_imageUser.Size = new Size(36, 34);
            btn_imageUser.TabIndex = 5;
            // 
            // btn_login
            // 
            btn_login.BorderRadius = 10;
            btn_login.CustomizableEdges = customizableEdges9;
            btn_login.DisabledState.BorderColor = Color.DarkGray;
            btn_login.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_login.FillColor = Color.Teal;
            btn_login.FillColor2 = Color.Teal;
            btn_login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(122, 221);
            btn_login.Name = "btn_login";
            btn_login.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btn_login.Size = new Size(261, 35);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.Click += btn_login_Click;
            // 
            // Flogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(606, 375);
            Controls.Add(btn_login);
            Controls.Add(btn_imageUser);
            Controls.Add(btn_lock);
            Controls.Add(txb_passwrod);
            Controls.Add(txb_User);
            Controls.Add(lb_login);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Flogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flogin";
            Load += Flogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_login;
        private Guna.UI2.WinForms.Guna2TextBox txb_User;
        private Guna.UI2.WinForms.Guna2TextBox txb_passwrod;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_lock;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_imageUser;
        private Guna.UI2.WinForms.Guna2GradientButton btn_login;
    }
}