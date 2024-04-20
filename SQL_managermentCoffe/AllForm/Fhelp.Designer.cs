namespace SQL_managermentCoffe.AllForm
{
    partial class Fhelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fhelp));
            Separator_product = new Guna.UI2.WinForms.Guna2Separator();
            lb_Help = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Separator_product
            // 
            Separator_product.FillColor = Color.Black;
            Separator_product.Location = new Point(2, 82);
            Separator_product.Name = "Separator_product";
            Separator_product.Size = new Size(1535, 12);
            Separator_product.TabIndex = 68;
            // 
            // lb_Help
            // 
            lb_Help.AutoSize = true;
            lb_Help.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_Help.ForeColor = Color.Teal;
            lb_Help.Location = new Point(566, 32);
            lb_Help.Name = "lb_Help";
            lb_Help.Size = new Size(76, 38);
            lb_Help.TabIndex = 69;
            lb_Help.Text = "Help";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label1.Location = new Point(49, 142);
            label1.Name = "label1";
            label1.Size = new Size(284, 28);
            label1.TabIndex = 70;
            label1.Text = "System help is always with you.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label2.Location = new Point(49, 170);
            label2.Name = "label2";
            label2.Size = new Size(721, 140);
            label2.TabIndex = 71;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Fhelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 729);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_Help);
            Controls.Add(Separator_product);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fhelp";
            Text = "Fhelp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator Separator_product;
        private Label lb_Help;
        private Label label1;
        private Label label2;
    }
}