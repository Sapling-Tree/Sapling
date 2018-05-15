namespace WindowsFormsApp2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tileSchedule = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblHelp = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tileSchedule
            // 
            this.tileSchedule.ActiveControl = null;
            this.tileSchedule.Location = new System.Drawing.Point(23, 142);
            this.tileSchedule.Name = "tileSchedule";
            this.tileSchedule.Size = new System.Drawing.Size(400, 61);
            this.tileSchedule.Style = MetroFramework.MetroColorStyle.Green;
            this.tileSchedule.TabIndex = 0;
            this.tileSchedule.Text = "Scheduling";
            this.tileSchedule.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(23, 211);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(189, 63);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Nav";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.Tan;
            this.metroTile3.Location = new System.Drawing.Point(218, 209);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(205, 65);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Forums";
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(23, 73);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(189, 63);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Gradding";
            this.metroTile5.UseSelectable = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.BackColor = System.Drawing.Color.Tan;
            this.metroTile6.Location = new System.Drawing.Point(218, 73);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(205, 63);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTile6.TabIndex = 5;
            this.metroTile6.Text = "Annoucements";
            this.metroTile6.UseCustomBackColor = true;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.BackColor = System.Drawing.Color.Tan;
            this.metroTile7.Location = new System.Drawing.Point(429, 73);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(109, 201);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile7.TabIndex = 6;
            this.metroTile7.Text = "Events";
            this.metroTile7.UseCustomBackColor = true;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.metroLabel1.Location = new System.Drawing.Point(27, 300);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 23);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "⚙ Settings";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // lblHelp
            // 
            this.lblHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHelp.Location = new System.Drawing.Point(124, 300);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(79, 23);
            this.lblHelp.Style = MetroFramework.MetroColorStyle.Green;
            this.lblHelp.TabIndex = 8;
            this.lblHelp.Text = "🔍 Help";
            this.lblHelp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblHelp.UseStyleColors = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 337);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.tileSchedule);
            this.Name = "Home";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "🏠 Home";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileSchedule;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblHelp;
    }
}