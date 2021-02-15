
namespace Speedometer
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.OverlayColorbox = new System.Windows.Forms.GroupBox();
            this.color_button = new System.Windows.Forms.Button();
            this.overLaycheck = new System.Windows.Forms.CheckBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.overLay_color_box = new System.Windows.Forms.ColorDialog();
            this.OverlayColorbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OverlayColorbox
            // 
            this.OverlayColorbox.Controls.Add(this.color_button);
            this.OverlayColorbox.Controls.Add(this.overLaycheck);
            this.OverlayColorbox.Location = new System.Drawing.Point(12, 12);
            this.OverlayColorbox.Name = "OverlayColorbox";
            this.OverlayColorbox.Size = new System.Drawing.Size(267, 91);
            this.OverlayColorbox.TabIndex = 0;
            this.OverlayColorbox.TabStop = false;
            this.OverlayColorbox.Text = "Overlay";
            // 
            // color_button
            // 
            this.color_button.Location = new System.Drawing.Point(7, 22);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(75, 23);
            this.color_button.TabIndex = 8;
            this.color_button.Text = "Color";
            this.color_button.UseVisualStyleBackColor = true;
            this.color_button.Click += new System.EventHandler(this.color_button_Click);
            // 
            // overLaycheck
            // 
            this.overLaycheck.AutoSize = true;
            this.overLaycheck.Location = new System.Drawing.Point(7, 51);
            this.overLaycheck.Name = "overLaycheck";
            this.overLaycheck.Size = new System.Drawing.Size(108, 19);
            this.overLaycheck.TabIndex = 7;
            this.overLaycheck.Text = "Ovelay position";
            this.overLaycheck.UseVisualStyleBackColor = true;
            this.overLaycheck.CheckedChanged += new System.EventHandler(this.OverLaycheck_CheckedChanged);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(171, 109);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // overLay_color_box
            // 
            this.overLay_color_box.FullOpen = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(291, 152);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.OverlayColorbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.OverlayColorbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OverlayColorbox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.CheckBox overLaycheck;
        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.ColorDialog overLay_color_box;
    }
}