
namespace Speedometer
{
    partial class OverLay
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
            this.SpeedOverGround = new System.Windows.Forms.Label();
            this.SpeedValue = new System.Windows.Forms.Label();
            this.HeadingText = new System.Windows.Forms.Label();
            this.HeadingValule = new System.Windows.Forms.Label();
            this.AltitudeText = new System.Windows.Forms.Label();
            this.AltitudeValule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SpeedOverGround
            // 
            this.SpeedOverGround.AutoSize = true;
            this.SpeedOverGround.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeedOverGround.ForeColor = System.Drawing.Color.Red;
            this.SpeedOverGround.Location = new System.Drawing.Point(12, 4);
            this.SpeedOverGround.Name = "SpeedOverGround";
            this.SpeedOverGround.Size = new System.Drawing.Size(162, 21);
            this.SpeedOverGround.TabIndex = 0;
            this.SpeedOverGround.Text = "Speed Over Ground";
            // 
            // SpeedValue
            // 
            this.SpeedValue.AutoSize = true;
            this.SpeedValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeedValue.ForeColor = System.Drawing.Color.White;
            this.SpeedValue.Location = new System.Drawing.Point(176, 4);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(33, 21);
            this.SpeedValue.TabIndex = 1;
            this.SpeedValue.Text = "0.0";
            // 
            // HeadingText
            // 
            this.HeadingText.AutoSize = true;
            this.HeadingText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeadingText.ForeColor = System.Drawing.Color.White;
            this.HeadingText.Location = new System.Drawing.Point(230, 4);
            this.HeadingText.Name = "HeadingText";
            this.HeadingText.Size = new System.Drawing.Size(71, 21);
            this.HeadingText.TabIndex = 2;
            this.HeadingText.Text = "Heading";
            // 
            // HeadingValule
            // 
            this.HeadingValule.AutoSize = true;
            this.HeadingValule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeadingValule.ForeColor = System.Drawing.Color.White;
            this.HeadingValule.Location = new System.Drawing.Point(307, 4);
            this.HeadingValule.Name = "HeadingValule";
            this.HeadingValule.Size = new System.Drawing.Size(33, 21);
            this.HeadingValule.TabIndex = 3;
            this.HeadingValule.Text = "0.0";
            // 
            // AltitudeText
            // 
            this.AltitudeText.AutoSize = true;
            this.AltitudeText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AltitudeText.ForeColor = System.Drawing.Color.White;
            this.AltitudeText.Location = new System.Drawing.Point(356, 4);
            this.AltitudeText.Name = "AltitudeText";
            this.AltitudeText.Size = new System.Drawing.Size(68, 21);
            this.AltitudeText.TabIndex = 4;
            this.AltitudeText.Text = "Altitude";
            // 
            // AltitudeValule
            // 
            this.AltitudeValule.AutoSize = true;
            this.AltitudeValule.BackColor = System.Drawing.Color.Transparent;
            this.AltitudeValule.CausesValidation = false;
            this.AltitudeValule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AltitudeValule.ForeColor = System.Drawing.Color.White;
            this.AltitudeValule.ImageKey = "(none)";
            this.AltitudeValule.Location = new System.Drawing.Point(430, 4);
            this.AltitudeValule.Name = "AltitudeValule";
            this.AltitudeValule.Size = new System.Drawing.Size(33, 21);
            this.AltitudeValule.TabIndex = 5;
            this.AltitudeValule.Text = "0.0";
            // 
            // OverLay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(505, 43);
            this.Controls.Add(this.AltitudeValule);
            this.Controls.Add(this.AltitudeText);
            this.Controls.Add(this.HeadingValule);
            this.Controls.Add(this.HeadingText);
            this.Controls.Add(this.SpeedValue);
            this.Controls.Add(this.SpeedOverGround);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OverLay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OverLay";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OverLay_FormClosing);
            this.Load += new System.EventHandler(this.OverLay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpeedOverGround;
        private System.Windows.Forms.Label HeadingText;
        private System.Windows.Forms.Label AltitudeText;
        public System.Windows.Forms.Label SpeedValue;
        public System.Windows.Forms.Label HeadingValule;
        public System.Windows.Forms.Label AltitudeValule;
    }
}