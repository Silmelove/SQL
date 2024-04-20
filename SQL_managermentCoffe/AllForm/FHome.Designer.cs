namespace SQL_managermentCoffe.AllForm
{
    partial class FHome
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
            btn_login = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BorderRadius = 10;
            btn_login.CustomizableEdges = customizableEdges1;
            btn_login.DisabledState.BorderColor = Color.DarkGray;
            btn_login.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_login.FillColor = Color.Teal;
            btn_login.FillColor2 = Color.Teal;
            btn_login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(141, 48);
            btn_login.Name = "btn_login";
            btn_login.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_login.Size = new Size(225, 56);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.Click += btn_login_Click;
            // 
            // guna2GradientButton2
            // 
            guna2GradientButton2.BorderRadius = 10;
            guna2GradientButton2.CustomizableEdges = customizableEdges3;
            guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton2.FillColor = Color.Teal;
            guna2GradientButton2.FillColor2 = Color.Teal;
            guna2GradientButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2GradientButton2.ForeColor = Color.White;
            guna2GradientButton2.Location = new Point(467, 48);
            guna2GradientButton2.Name = "guna2GradientButton2";
            guna2GradientButton2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientButton2.Size = new Size(225, 56);
            guna2GradientButton2.TabIndex = 1;
            guna2GradientButton2.Text = "Change account";
            guna2GradientButton2.Click += guna2GradientButton2_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.Black;
            guna2Separator1.Location = new Point(12, 125);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1263, 12);
            guna2Separator1.TabIndex = 2;
            // 
            // FHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(898, 552);
            Controls.Add(guna2Separator1);
            Controls.Add(guna2GradientButton2);
            Controls.Add(btn_login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FHome";
            Text = "FHome";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_login;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}