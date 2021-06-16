
namespace e.Components
{
    partial class UserProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FullName = new System.Windows.Forms.Label();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.PhoneShow = new System.Windows.Forms.Label();
            this.EmailShow = new System.Windows.Forms.Label();
            this.CINShow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReturnBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.F_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.L_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.CIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Pages.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 457);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.FullName);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 55);
            this.panel2.TabIndex = 46;
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(13, 17);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(186, 19);
            this.FullName.TabIndex = 11;
            this.FullName.Text = "Mohammed Hamham";
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.BorderRadius = 2;
            this.EditBtn.CheckedState.Parent = this.EditBtn;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.CustomImages.Parent = this.EditBtn;
            this.EditBtn.FillColor = System.Drawing.Color.Plum;
            this.EditBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.HoverState.Parent = this.EditBtn;
            this.EditBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.EditBtn.Location = new System.Drawing.Point(617, 13);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ShadowDecoration.Parent = this.EditBtn;
            this.EditBtn.Size = new System.Drawing.Size(86, 30);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Modifier";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "Information personelle";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.81752F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.9635F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CINShow, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmailShow, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PhoneShow, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 147);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 167);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(4, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(334, 54);
            this.label15.TabIndex = 0;
            this.label15.Text = "CIN";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PhoneShow
            // 
            this.PhoneShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneShow.AutoSize = true;
            this.PhoneShow.BackColor = System.Drawing.Color.White;
            this.PhoneShow.Location = new System.Drawing.Point(345, 111);
            this.PhoneShow.Name = "PhoneShow";
            this.PhoneShow.Size = new System.Drawing.Size(337, 55);
            this.PhoneShow.TabIndex = 0;
            this.PhoneShow.Text = "06 45 87 34 72";
            this.PhoneShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmailShow
            // 
            this.EmailShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailShow.AutoSize = true;
            this.EmailShow.BackColor = System.Drawing.Color.White;
            this.EmailShow.Location = new System.Drawing.Point(345, 56);
            this.EmailShow.Name = "EmailShow";
            this.EmailShow.Size = new System.Drawing.Size(337, 54);
            this.EmailShow.TabIndex = 0;
            this.EmailShow.Text = "exemple@mail.com";
            this.EmailShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CINShow
            // 
            this.CINShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CINShow.AutoSize = true;
            this.CINShow.BackColor = System.Drawing.Color.White;
            this.CINShow.Location = new System.Drawing.Point(345, 1);
            this.CINShow.Name = "CINShow";
            this.CINShow.Size = new System.Drawing.Size(337, 54);
            this.CINShow.TabIndex = 0;
            this.CINShow.Text = "XA86367";
            this.CINShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(4, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 54);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(4, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 55);
            this.label7.TabIndex = 0;
            this.label7.Text = "Téléphone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pages
            // 
            this.Pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Pages.AllowTransitions = true;
            this.Pages.Controls.Add(this.tabPage1);
            this.Pages.Controls.Add(this.tabPage2);
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.Location = new System.Drawing.Point(0, 0);
            this.Pages.Margin = new System.Windows.Forms.Padding(0);
            this.Pages.Multiline = true;
            this.Pages.Name = "Pages";
            this.Pages.Page = this.tabPage2;
            this.Pages.PageIndex = 1;
            this.Pages.PageName = "tabPage2";
            this.Pages.PageTitle = "tabPage2";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(734, 483);
            this.Pages.TabIndex = 2;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Pages.Transition = animation1;
            this.Pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.F_Name);
            this.tabPage2.Controls.Add(this.Password);
            this.tabPage2.Controls.Add(this.L_Name);
            this.tabPage2.Controls.Add(this.CIN);
            this.tabPage2.Controls.Add(this.Email);
            this.tabPage2.Controls.Add(this.Phone);
            this.tabPage2.Controls.Add(this.Label2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 457);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.ReturnBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 55);
            this.panel1.TabIndex = 46;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBtn.BorderRadius = 2;
            this.ReturnBtn.CheckedState.Parent = this.ReturnBtn;
            this.ReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnBtn.CustomImages.Parent = this.ReturnBtn;
            this.ReturnBtn.FillColor = System.Drawing.Color.SkyBlue;
            this.ReturnBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.ForeColor = System.Drawing.Color.White;
            this.ReturnBtn.HoverState.Parent = this.ReturnBtn;
            this.ReturnBtn.Image = global::e.Properties.Resources.back_arrow;
            this.ReturnBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.ReturnBtn.Location = new System.Drawing.Point(556, 13);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.ShadowDecoration.Parent = this.ReturnBtn;
            this.ReturnBtn.Size = new System.Drawing.Size(40, 30);
            this.ReturnBtn.TabIndex = 1;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modifier vos données personnelles";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BorderRadius = 2;
            this.SaveBtn.CheckedState.Parent = this.SaveBtn;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.CustomImages.Parent = this.SaveBtn;
            this.SaveBtn.FillColor = System.Drawing.Color.Plum;
            this.SaveBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.HoverState.Parent = this.SaveBtn;
            this.SaveBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.SaveBtn.Location = new System.Drawing.Point(602, 13);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(101, 30);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Sauvegarder";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // F_Name
            // 
            this.F_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.F_Name.DefaultText = "";
            this.F_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.F_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.F_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.F_Name.DisabledState.Parent = this.F_Name;
            this.F_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.F_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.F_Name.FocusedState.Parent = this.F_Name;
            this.F_Name.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.F_Name.HoverState.Parent = this.F_Name;
            this.F_Name.Location = new System.Drawing.Point(496, 172);
            this.F_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.F_Name.Name = "F_Name";
            this.F_Name.PasswordChar = '\0';
            this.F_Name.PlaceholderText = "PRENOM";
            this.F_Name.SelectedText = "";
            this.F_Name.ShadowDecoration.Parent = this.F_Name;
            this.F_Name.Size = new System.Drawing.Size(212, 36);
            this.F_Name.TabIndex = 50;
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.Parent = this.Password;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.FocusedState.Parent = this.Password;
            this.Password.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.HoverState.Parent = this.Password;
            this.Password.Location = new System.Drawing.Point(496, 253);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderText = "MOT DE PASSE";
            this.Password.SelectedText = "";
            this.Password.ShadowDecoration.Parent = this.Password;
            this.Password.Size = new System.Drawing.Size(212, 36);
            this.Password.TabIndex = 52;
            // 
            // L_Name
            // 
            this.L_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.L_Name.DefaultText = "";
            this.L_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.L_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.L_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.L_Name.DisabledState.Parent = this.L_Name;
            this.L_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.L_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.L_Name.FocusedState.Parent = this.L_Name;
            this.L_Name.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.L_Name.HoverState.Parent = this.L_Name;
            this.L_Name.Location = new System.Drawing.Point(259, 172);
            this.L_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.L_Name.Name = "L_Name";
            this.L_Name.PasswordChar = '\0';
            this.L_Name.PlaceholderText = "NOM";
            this.L_Name.SelectedText = "";
            this.L_Name.ShadowDecoration.Parent = this.L_Name;
            this.L_Name.Size = new System.Drawing.Size(212, 36);
            this.L_Name.TabIndex = 48;
            // 
            // CIN
            // 
            this.CIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CIN.DefaultText = "";
            this.CIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CIN.DisabledState.Parent = this.CIN;
            this.CIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CIN.FocusedState.Parent = this.CIN;
            this.CIN.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CIN.HoverState.Parent = this.CIN;
            this.CIN.Location = new System.Drawing.Point(22, 172);
            this.CIN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CIN.Name = "CIN";
            this.CIN.PasswordChar = '\0';
            this.CIN.PlaceholderText = "CIN";
            this.CIN.SelectedText = "";
            this.CIN.ShadowDecoration.Parent = this.CIN;
            this.CIN.Size = new System.Drawing.Size(212, 36);
            this.CIN.TabIndex = 47;
            // 
            // Email
            // 
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.Parent = this.Email;
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.FocusedState.Parent = this.Email;
            this.Email.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.HoverState.Parent = this.Email;
            this.Email.Location = new System.Drawing.Point(259, 253);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.PlaceholderText = "EMAIL";
            this.Email.SelectedText = "";
            this.Email.ShadowDecoration.Parent = this.Email;
            this.Email.Size = new System.Drawing.Size(212, 36);
            this.Email.TabIndex = 51;
            // 
            // Phone
            // 
            this.Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Phone.DefaultText = "";
            this.Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Phone.DisabledState.Parent = this.Phone;
            this.Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Phone.FocusedState.Parent = this.Phone;
            this.Phone.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Phone.HoverState.Parent = this.Phone;
            this.Phone.Location = new System.Drawing.Point(22, 253);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Phone.Name = "Phone";
            this.Phone.PasswordChar = '\0';
            this.Phone.PlaceholderText = "TELEPHONE";
            this.Phone.SelectedText = "";
            this.Phone.ShadowDecoration.Parent = this.Phone;
            this.Phone.Size = new System.Drawing.Size(212, 36);
            this.Phone.TabIndex = 49;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(18, 112);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(176, 19);
            this.Label2.TabIndex = 53;
            this.Label2.Text = "Information personelle";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pages);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(734, 483);
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Pages.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CINShow;
        private System.Windows.Forms.Label EmailShow;
        private System.Windows.Forms.Label PhoneShow;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private System.Windows.Forms.Label FullName;
        private Bunifu.UI.WinForms.BunifuPages Pages;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button ReturnBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2TextBox F_Name;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox L_Name;
        private Guna.UI2.WinForms.Guna2TextBox CIN;
        private Guna.UI2.WinForms.Guna2TextBox Email;
        private Guna.UI2.WinForms.Guna2TextBox Phone;
        private System.Windows.Forms.Label Label2;
    }
}
