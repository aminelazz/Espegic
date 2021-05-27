
namespace e
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessorsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FormationsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.Plus = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.UserGuideBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TechnicalGuideBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.Content = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.guna2Panel1.Controls.Add(this.menuStrip1);
            this.guna2Panel1.Controls.Add(this.menuStrip2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(734, 78);
            this.guna2Panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeBtn,
            this.UsersBtn,
            this.ProfessorsBtn,
            this.StudentsBtn,
            this.FormationsBtn,
            this.Plus});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(277, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeBtn
            // 
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(51, 20);
            this.HomeBtn.Text = "Acceil";
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(98, 20);
            this.UsersBtn.Text = "Administrateur";
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // ProfessorsBtn
            // 
            this.ProfessorsBtn.Name = "ProfessorsBtn";
            this.ProfessorsBtn.Size = new System.Drawing.Size(84, 20);
            this.ProfessorsBtn.Text = "Professeurs";
            this.ProfessorsBtn.Click += new System.EventHandler(this.ProfessorsBtn_Click);
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(70, 20);
            this.StudentsBtn.Text = "Etudiants";
            this.StudentsBtn.Click += new System.EventHandler(this.StudentsBtn_Click);
            // 
            // FormationsBtn
            // 
            this.FormationsBtn.Name = "FormationsBtn";
            this.FormationsBtn.Size = new System.Drawing.Size(81, 20);
            this.FormationsBtn.Text = "Formations";
            this.FormationsBtn.Click += new System.EventHandler(this.FormationsBtn_Click);
            // 
            // Plus
            // 
            this.Plus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatisticsBtn,
            this.UserGuideBtn,
            this.TechnicalGuideBtn});
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(43, 20);
            this.Plus.Text = "Plus";
            // 
            // StatisticsBtn
            // 
            this.StatisticsBtn.Name = "StatisticsBtn";
            this.StatisticsBtn.Size = new System.Drawing.Size(172, 22);
            this.StatisticsBtn.Text = "Statistique";
            // 
            // UserGuideBtn
            // 
            this.UserGuideBtn.Name = "UserGuideBtn";
            this.UserGuideBtn.Size = new System.Drawing.Size(172, 22);
            this.UserGuideBtn.Text = "Guide d\'utilisation";
            // 
            // TechnicalGuideBtn
            // 
            this.TechnicalGuideBtn.Name = "TechnicalGuideBtn";
            this.TechnicalGuideBtn.Size = new System.Drawing.Size(172, 22);
            this.TechnicalGuideBtn.Text = "Guide technique";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Profile});
            this.menuStrip2.Location = new System.Drawing.Point(20, 27);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(56, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Profile
            // 
            this.Profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileBtn,
            this.DisconnectBtn});
            this.Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.Image = global::e.Properties.Resources.users;
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(48, 20);
            this.Profile.Text = "....";
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(171, 22);
            this.ProfileBtn.Text = "Profile";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(171, 22);
            this.DisconnectBtn.Text = "Se deconnecter";
            // 
            // Content
            // 
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Content.Location = new System.Drawing.Point(0, 78);
            this.Content.Name = "Content";
            this.Content.ShadowDecoration.Parent = this.Content;
            this.Content.Size = new System.Drawing.Size(734, 483);
            this.Content.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espegic";
            this.Load += new System.EventHandler(this.Main_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UsersBtn;
        private Guna.UI2.WinForms.Guna2Panel Content;
        private System.Windows.Forms.ToolStripMenuItem Plus;
        private System.Windows.Forms.ToolStripMenuItem UserGuideBtn;
        private System.Windows.Forms.ToolStripMenuItem TechnicalGuideBtn;
        private System.Windows.Forms.ToolStripMenuItem StatisticsBtn;
        public System.Windows.Forms.ToolStripMenuItem HomeBtn;
        private System.Windows.Forms.ToolStripMenuItem ProfessorsBtn;
        private System.Windows.Forms.ToolStripMenuItem StudentsBtn;
        private System.Windows.Forms.ToolStripMenuItem FormationsBtn;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Profile;
        private System.Windows.Forms.ToolStripMenuItem ProfileBtn;
        private System.Windows.Forms.ToolStripMenuItem DisconnectBtn;
    }
}

