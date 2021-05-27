
namespace e.Components
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Next = new Guna.UI2.WinForms.Guna2Button();
            this.Previous = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.View = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ACTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATED_AT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.Next);
            this.panel4.Controls.Add(this.Previous);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(734, 55);
            this.panel4.TabIndex = 40;
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.BorderRadius = 2;
            this.Next.CheckedState.Parent = this.Next;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.CustomImages.Parent = this.Next;
            this.Next.FillColor = System.Drawing.Color.SkyBlue;
            this.Next.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.HoverState.Parent = this.Next;
            this.Next.Location = new System.Drawing.Point(673, 13);
            this.Next.Name = "Next";
            this.Next.ShadowDecoration.Parent = this.Next;
            this.Next.Size = new System.Drawing.Size(40, 30);
            this.Next.TabIndex = 1;
            this.Next.Text = ">";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Previous.BorderRadius = 2;
            this.Previous.CheckedState.Parent = this.Previous;
            this.Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous.CustomImages.Parent = this.Previous;
            this.Previous.FillColor = System.Drawing.Color.SkyBlue;
            this.Previous.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.ForeColor = System.Drawing.Color.White;
            this.Previous.HoverState.Parent = this.Previous;
            this.Previous.Location = new System.Drawing.Point(627, 13);
            this.Previous.Name = "Previous";
            this.Previous.ShadowDecoration.Parent = this.Previous;
            this.Previous.Size = new System.Drawing.Size(40, 30);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "<";
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Historique";
            // 
            // View
            // 
            this.View.AllowUserToAddRows = false;
            this.View.AllowUserToResizeColumns = false;
            this.View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.View.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.View.ColumnHeadersHeight = 21;
            this.View.ColumnHeadersVisible = false;
            this.View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACTION,
            this.CREATED_AT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.View.DefaultCellStyle = dataGridViewCellStyle3;
            this.View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View.EnableHeadersVisualStyles = false;
            this.View.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.View.Location = new System.Drawing.Point(0, 55);
            this.View.MultiSelect = false;
            this.View.Name = "View";
            this.View.RowHeadersVisible = false;
            this.View.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.View.RowTemplate.Height = 38;
            this.View.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.View.Size = new System.Drawing.Size(734, 428);
            this.View.TabIndex = 41;
            this.View.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.View.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.View.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.View.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.View.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.View.ThemeStyle.HeaderStyle.Height = 21;
            this.View.ThemeStyle.ReadOnly = false;
            this.View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.View.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.View.ThemeStyle.RowsStyle.Height = 38;
            this.View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ACTION
            // 
            this.ACTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ACTION.DataPropertyName = "ACTION";
            this.ACTION.Frozen = true;
            this.ACTION.HeaderText = "ACTION";
            this.ACTION.Name = "ACTION";
            this.ACTION.Width = 584;
            // 
            // CREATED_AT
            // 
            this.CREATED_AT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CREATED_AT.DataPropertyName = "CREATED_AT";
            this.CREATED_AT.HeaderText = "CREATED ATT";
            this.CREATED_AT.Name = "CREATED_AT";
            this.CREATED_AT.Width = 150;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.View);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.Size = new System.Drawing.Size(734, 483);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button Next;
        private Guna.UI2.WinForms.Guna2Button Previous;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView View;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATED_AT;
    }
}
