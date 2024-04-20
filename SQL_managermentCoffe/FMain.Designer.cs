namespace SQL_managermentCoffe
{
    partial class FMain
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
            panel2 = new Panel();
            btn_home = new Guna.UI2.WinForms.Guna2GradientButton();
            ControlsPanel = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btn_home);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 779);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btn_home
            // 
            btn_home.BorderRadius = 10;
            btn_home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn_home.CheckedState.FillColor = Color.Salmon;
            btn_home.CheckedState.FillColor2 = Color.IndianRed;
            btn_home.CustomizableEdges = customizableEdges1;
            btn_home.DisabledState.BorderColor = Color.DarkGray;
            btn_home.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_home.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_home.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btn_home.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_home.FillColor = Color.Transparent;
            btn_home.FillColor2 = Color.Transparent;
            btn_home.Font = new Font("Segoe UI", 9F);
            btn_home.ForeColor = Color.White;
            btn_home.Image = Properties.Resources.home__1_;
            btn_home.ImageAlign = HorizontalAlignment.Left;
            btn_home.ImageOffset = new Point(10, 0);
            btn_home.ImageSize = new Size(30, 30);
            btn_home.Location = new Point(31, 12);
            btn_home.Name = "btn_home";
            btn_home.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_home.Size = new Size(216, 52);
            btn_home.TabIndex = 0;
            btn_home.Text = "Home";
            btn_home.Click += btn_home_Click;
            // 
            // ControlsPanel
            // 
            ControlsPanel.BackColor = Color.Transparent;
            ControlsPanel.Dock = DockStyle.Fill;
            ControlsPanel.Location = new Point(253, 0);
            ControlsPanel.Name = "ControlsPanel";
            ControlsPanel.Size = new Size(1250, 779);
            ControlsPanel.TabIndex = 2;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 779);
            Controls.Add(ControlsPanel);
            Controls.Add(panel2);
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fhome";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel ControlsPanel;
        private Guna.UI2.WinForms.Guna2GradientButton btn_home;
    }
}