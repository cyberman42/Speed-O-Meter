
namespace Speedometer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SpeedOverGrond = new System.Windows.Forms.Label();
            this.SpeedValule = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.HeadingValue = new System.Windows.Forms.Label();
            this.AltitudeVale = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.OverLayMuenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpeedOverGrond
            // 
            this.SpeedOverGrond.AutoSize = true;
            this.SpeedOverGrond.Location = new System.Drawing.Point(12, 41);
            this.SpeedOverGrond.Name = "SpeedOverGrond";
            this.SpeedOverGrond.Size = new System.Drawing.Size(110, 15);
            this.SpeedOverGrond.TabIndex = 0;
            this.SpeedOverGrond.Text = "Speed Over Ground";
            // 
            // SpeedValule
            // 
            this.SpeedValule.AutoSize = true;
            this.SpeedValule.CausesValidation = false;
            this.SpeedValule.Location = new System.Drawing.Point(124, 41);
            this.SpeedValule.Name = "SpeedValule";
            this.SpeedValule.Size = new System.Drawing.Size(22, 15);
            this.SpeedValule.TabIndex = 1;
            this.SpeedValule.Text = "0.0";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Location = new System.Drawing.Point(12, 71);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(55, 15);
            this.Heading.TabIndex = 2;
            this.Heading.Text = "Heading ";
            // 
            // HeadingValue
            // 
            this.HeadingValue.AutoSize = true;
            this.HeadingValue.Location = new System.Drawing.Point(124, 71);
            this.HeadingValue.Name = "HeadingValue";
            this.HeadingValue.Size = new System.Drawing.Size(22, 15);
            this.HeadingValue.TabIndex = 3;
            this.HeadingValue.Text = "0.0";
            // 
            // AltitudeVale
            // 
            this.AltitudeVale.AutoSize = true;
            this.AltitudeVale.Location = new System.Drawing.Point(124, 99);
            this.AltitudeVale.Name = "AltitudeVale";
            this.AltitudeVale.Size = new System.Drawing.Size(22, 15);
            this.AltitudeVale.TabIndex = 5;
            this.AltitudeVale.Text = "0.0";
            // 
            // Altitude
            // 
            this.Altitude.AutoSize = true;
            this.Altitude.Location = new System.Drawing.Point(12, 99);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(49, 15);
            this.Altitude.TabIndex = 4;
            this.Altitude.Text = "Altitude";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Gray;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.SettingMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(183, 24);
            this.Menu.TabIndex = 8;
            this.Menu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SettingMenuItem
            // 
            this.SettingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubSettings,
            this.OverLayMuenu});
            this.SettingMenuItem.Name = "SettingMenuItem";
            this.SettingMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SettingMenuItem.Text = "Settings";
            // 
            // SubSettings
            // 
            this.SubSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubSettings.Name = "SubSettings";
            this.SubSettings.Size = new System.Drawing.Size(117, 22);
            this.SubSettings.Text = "Settings";
            this.SubSettings.Click += new System.EventHandler(this.SubSettings_Click);
            // 
            // OverLayMuenu
            // 
            this.OverLayMuenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OverLayMuenu.CheckOnClick = true;
            this.OverLayMuenu.Name = "OverLayMuenu";
            this.OverLayMuenu.Size = new System.Drawing.Size(117, 22);
            this.OverLayMuenu.Text = "OverLay";
            this.OverLayMuenu.CheckedChanged += new System.EventHandler(this.OverLayMuenu_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(183, 156);
            this.Controls.Add(this.AltitudeVale);
            this.Controls.Add(this.Altitude);
            this.Controls.Add(this.HeadingValue);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.SpeedValule);
            this.Controls.Add(this.SpeedOverGrond);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Speed over Grond ";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpeedOverGrond;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label HeadingValue;
        private System.Windows.Forms.Label AltitudeVale;
        private System.Windows.Forms.Label Altitude;
        private System.Windows.Forms.MenuStrip Menu;
      
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubSettings;
        private System.Windows.Forms.ToolStripMenuItem OverLayMuenu;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        public System.Windows.Forms.Label SpeedValule;
    }
}

