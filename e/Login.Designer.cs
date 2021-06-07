
namespace e
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.HEADER_PANEL = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LOGIN_PANEL = new System.Windows.Forms.Panel();
            this.LOGIN_RECOVER = new Guna.UI2.WinForms.Guna2Button();
            this.LOGIN_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.LOGIN_PASSWORD = new Guna.UI2.WinForms.Guna2TextBox();
            this.LOGIN_EMAIL = new Guna.UI2.WinForms.Guna2TextBox();
            this.LABEL_PASSWORD = new System.Windows.Forms.Label();
            this.LABEL_EMAIL = new System.Windows.Forms.Label();
            this.LOGIN_FORM = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.CLOSE_BTN = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BOX_ICONE = new System.Windows.Forms.PictureBox();
            this.HEADER_PANEL.SuspendLayout();
            this.LOGIN_PANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BOX_ICONE)).BeginInit();
            this.SuspendLayout();
            // 
            // HEADER_PANEL
            // 
            this.HEADER_PANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.HEADER_PANEL.Controls.Add(this.label3);
            this.HEADER_PANEL.Controls.Add(this.CLOSE_BTN);
            this.HEADER_PANEL.Controls.Add(this.BOX_ICONE);
            this.HEADER_PANEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.HEADER_PANEL.Location = new System.Drawing.Point(0, 0);
            this.HEADER_PANEL.Name = "HEADER_PANEL";
            this.HEADER_PANEL.Size = new System.Drawing.Size(500, 60);
            this.HEADER_PANEL.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ESPEGIC";
            // 
            // LOGIN_PANEL
            // 
            this.LOGIN_PANEL.BackColor = System.Drawing.Color.White;
            this.LOGIN_PANEL.Controls.Add(this.LOGIN_RECOVER);
            this.LOGIN_PANEL.Controls.Add(this.LOGIN_BTN);
            this.LOGIN_PANEL.Controls.Add(this.LOGIN_PASSWORD);
            this.LOGIN_PANEL.Controls.Add(this.LOGIN_EMAIL);
            this.LOGIN_PANEL.Controls.Add(this.LABEL_PASSWORD);
            this.LOGIN_PANEL.Controls.Add(this.LABEL_EMAIL);
            this.LOGIN_PANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LOGIN_PANEL.Location = new System.Drawing.Point(0, 60);
            this.LOGIN_PANEL.Name = "LOGIN_PANEL";
            this.LOGIN_PANEL.Size = new System.Drawing.Size(500, 274);
            this.LOGIN_PANEL.TabIndex = 1;
            // 
            // LOGIN_RECOVER
            // 
            this.LOGIN_RECOVER.BorderRadius = 2;
            this.LOGIN_RECOVER.CheckedState.Parent = this.LOGIN_RECOVER;
            this.LOGIN_RECOVER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOGIN_RECOVER.CustomImages.Parent = this.LOGIN_RECOVER;
            this.LOGIN_RECOVER.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LOGIN_RECOVER.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_RECOVER.ForeColor = System.Drawing.Color.White;
            this.LOGIN_RECOVER.HoverState.Parent = this.LOGIN_RECOVER;
            this.LOGIN_RECOVER.Location = new System.Drawing.Point(287, 183);
            this.LOGIN_RECOVER.Name = "LOGIN_RECOVER";
            this.LOGIN_RECOVER.ShadowDecoration.Parent = this.LOGIN_RECOVER;
            this.LOGIN_RECOVER.Size = new System.Drawing.Size(165, 45);
            this.LOGIN_RECOVER.TabIndex = 2;
            this.LOGIN_RECOVER.Text = "MOT DE PASSE OUBLIE";
            this.LOGIN_RECOVER.Click += new System.EventHandler(this.LOGIN_RECOVER_Click);
            // 
            // LOGIN_BTN
            // 
            this.LOGIN_BTN.BorderRadius = 2;
            this.LOGIN_BTN.CheckedState.Parent = this.LOGIN_BTN;
            this.LOGIN_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOGIN_BTN.CustomImages.Parent = this.LOGIN_BTN;
            this.LOGIN_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_BTN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LOGIN_BTN.HoverState.Parent = this.LOGIN_BTN;
            this.LOGIN_BTN.Location = new System.Drawing.Point(162, 183);
            this.LOGIN_BTN.Name = "LOGIN_BTN";
            this.LOGIN_BTN.ShadowDecoration.Parent = this.LOGIN_BTN;
            this.LOGIN_BTN.Size = new System.Drawing.Size(119, 45);
            this.LOGIN_BTN.TabIndex = 2;
            this.LOGIN_BTN.Text = "SE CONNECTER";
            this.LOGIN_BTN.Click += new System.EventHandler(this.LOGIN_BTN_Click);
            // 
            // LOGIN_PASSWORD
            // 
            this.LOGIN_PASSWORD.BorderRadius = 2;
            this.LOGIN_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LOGIN_PASSWORD.DefaultText = "";
            this.LOGIN_PASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LOGIN_PASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LOGIN_PASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LOGIN_PASSWORD.DisabledState.Parent = this.LOGIN_PASSWORD;
            this.LOGIN_PASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LOGIN_PASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LOGIN_PASSWORD.FocusedState.Parent = this.LOGIN_PASSWORD;
            this.LOGIN_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_PASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LOGIN_PASSWORD.HoverState.Parent = this.LOGIN_PASSWORD;
            this.LOGIN_PASSWORD.Location = new System.Drawing.Point(162, 109);
            this.LOGIN_PASSWORD.Name = "LOGIN_PASSWORD";
            this.LOGIN_PASSWORD.PasswordChar = '\0';
            this.LOGIN_PASSWORD.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.LOGIN_PASSWORD.PlaceholderText = "MOT DE PASSE";
            this.LOGIN_PASSWORD.SelectedText = "";
            this.LOGIN_PASSWORD.ShadowDecoration.Parent = this.LOGIN_PASSWORD;
            this.LOGIN_PASSWORD.Size = new System.Drawing.Size(290, 40);
            this.LOGIN_PASSWORD.TabIndex = 1;
            this.LOGIN_PASSWORD.UseSystemPasswordChar = true;
            this.LOGIN_PASSWORD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LOGIN_PASSWORD_KeyPress);
            // 
            // LOGIN_EMAIL
            // 
            this.LOGIN_EMAIL.BorderRadius = 2;
            this.LOGIN_EMAIL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LOGIN_EMAIL.DefaultText = "";
            this.LOGIN_EMAIL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LOGIN_EMAIL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LOGIN_EMAIL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LOGIN_EMAIL.DisabledState.Parent = this.LOGIN_EMAIL;
            this.LOGIN_EMAIL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LOGIN_EMAIL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LOGIN_EMAIL.FocusedState.Parent = this.LOGIN_EMAIL;
            this.LOGIN_EMAIL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_EMAIL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LOGIN_EMAIL.HoverState.Parent = this.LOGIN_EMAIL;
            this.LOGIN_EMAIL.Location = new System.Drawing.Point(162, 44);
            this.LOGIN_EMAIL.Name = "LOGIN_EMAIL";
            this.LOGIN_EMAIL.PasswordChar = '\0';
            this.LOGIN_EMAIL.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.LOGIN_EMAIL.PlaceholderText = "EMAIL";
            this.LOGIN_EMAIL.SelectedText = "";
            this.LOGIN_EMAIL.ShadowDecoration.Parent = this.LOGIN_EMAIL;
            this.LOGIN_EMAIL.Size = new System.Drawing.Size(290, 40);
            this.LOGIN_EMAIL.TabIndex = 1;
            // 
            // LABEL_PASSWORD
            // 
            this.LABEL_PASSWORD.AutoSize = true;
            this.LABEL_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_PASSWORD.Location = new System.Drawing.Point(38, 119);
            this.LABEL_PASSWORD.Name = "LABEL_PASSWORD";
            this.LABEL_PASSWORD.Size = new System.Drawing.Size(99, 17);
            this.LABEL_PASSWORD.TabIndex = 0;
            this.LABEL_PASSWORD.Text = "MOT DE PASSE";
            // 
            // LABEL_EMAIL
            // 
            this.LABEL_EMAIL.AutoSize = true;
            this.LABEL_EMAIL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_EMAIL.Location = new System.Drawing.Point(38, 54);
            this.LABEL_EMAIL.Name = "LABEL_EMAIL";
            this.LABEL_EMAIL.Size = new System.Drawing.Size(47, 17);
            this.LABEL_EMAIL.TabIndex = 0;
            this.LABEL_EMAIL.Text = "EMAIL";
            // 
            // LOGIN_FORM
            // 
            this.LOGIN_FORM.TargetControl = this.HEADER_PANEL;
            // 
            // CLOSE_BTN
            // 
            this.CLOSE_BTN.CheckedState.Parent = this.CLOSE_BTN;
            this.CLOSE_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CLOSE_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CLOSE_BTN.HoverState.Parent = this.CLOSE_BTN;
            this.CLOSE_BTN.Image = global::e.Properties.Resources.close;
            this.CLOSE_BTN.ImageSize = new System.Drawing.Size(15, 15);
            this.CLOSE_BTN.Location = new System.Drawing.Point(440, 0);
            this.CLOSE_BTN.Name = "CLOSE_BTN";
            this.CLOSE_BTN.PressedState.Parent = this.CLOSE_BTN;
            this.CLOSE_BTN.Size = new System.Drawing.Size(60, 60);
            this.CLOSE_BTN.TabIndex = 2;
            this.CLOSE_BTN.Click += new System.EventHandler(this.CLOSE_BTN_Click);
            // 
            // BOX_ICONE
            // 
            this.BOX_ICONE.Image = global::e.Properties.Resources.Internet_Explorer_23486;
            this.BOX_ICONE.Location = new System.Drawing.Point(11, 12);
            this.BOX_ICONE.Name = "BOX_ICONE";
            this.BOX_ICONE.Size = new System.Drawing.Size(46, 33);
            this.BOX_ICONE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BOX_ICONE.TabIndex = 0;
            this.BOX_ICONE.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(211)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(500, 334);
            this.Controls.Add(this.LOGIN_PANEL);
            this.Controls.Add(this.HEADER_PANEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.HEADER_PANEL.ResumeLayout(false);
            this.HEADER_PANEL.PerformLayout();
            this.LOGIN_PANEL.ResumeLayout(false);
            this.LOGIN_PANEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BOX_ICONE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HEADER_PANEL;
        private System.Windows.Forms.Panel LOGIN_PANEL;
        private Guna.UI2.WinForms.Guna2Button LOGIN_RECOVER;
        private Guna.UI2.WinForms.Guna2Button LOGIN_BTN;
        private Guna.UI2.WinForms.Guna2TextBox LOGIN_PASSWORD;
        private Guna.UI2.WinForms.Guna2TextBox LOGIN_EMAIL;
        private System.Windows.Forms.Label LABEL_PASSWORD;
        private System.Windows.Forms.Label LABEL_EMAIL;
        private System.Windows.Forms.PictureBox BOX_ICONE;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton CLOSE_BTN;
        private Guna.UI2.WinForms.Guna2DragControl LOGIN_FORM;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
    }
}

