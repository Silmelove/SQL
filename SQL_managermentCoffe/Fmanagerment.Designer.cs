namespace SQL_managermentCoffe
{
    partial class Fmanagerment
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
            btn_Add = new Guna.UI2.WinForms.Guna2Button();
            btn_update = new Guna.UI2.WinForms.Guna2Button();
            btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Add
            // 
            btn_Add.BorderRadius = 6;
            btn_Add.CustomizableEdges = customizableEdges1;
            btn_Add.DisabledState.BorderColor = Color.DarkGray;
            btn_Add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Add.Font = new Font("Segoe UI", 9F);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(38, 78);
            btn_Add.Name = "btn_Add";
            btn_Add.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_Add.Size = new Size(225, 56);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Add";
            // 
            // btn_update
            // 
            btn_update.BorderRadius = 6;
            btn_update.CustomizableEdges = customizableEdges3;
            btn_update.DisabledState.BorderColor = Color.DarkGray;
            btn_update.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_update.Font = new Font("Segoe UI", 9F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(38, 150);
            btn_update.Name = "btn_update";
            btn_update.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_update.Size = new Size(225, 56);
            btn_update.TabIndex = 1;
            btn_update.Text = "Update";
            // 
            // btn_Delete
            // 
            btn_Delete.BorderRadius = 6;
            btn_Delete.CustomizableEdges = customizableEdges5;
            btn_Delete.DisabledState.BorderColor = Color.DarkGray;
            btn_Delete.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Delete.Font = new Font("Segoe UI", 9F);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(38, 221);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_Delete.Size = new Size(225, 56);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Delete";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(312, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(579, 327);
            dataGridView1.TabIndex = 3;
            // 
            // Fmanagerment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 475);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Delete);
            Controls.Add(btn_update);
            Controls.Add(btn_Add);
            Name = "Fmanagerment";
            Text = "Fmanagerment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private DataGridView dataGridView1;
    }
}