using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Speedometer
{
    public partial class Settings : Form
    {
        OverLay overLay = new OverLay();
        public Settings()
        {
            InitializeComponent();
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            
            GobleSettings.Default.Save();
            this.Close();
        }

        

        private void OverLaycheck_CheckedChanged(object sender, EventArgs e)
        {
           
            if (overLaycheck.Checked == true)
            {
                overLay.TransparencyKey = Color.Empty;
                overLay.FormBorderStyle = FormBorderStyle.FixedDialog;
                Point z = new Point(GobleSettings.Default.OverlayX, GobleSettings.Default.OverlayY);
                overLay.Location = z;
                overLay.Text = "Overlay place";
                if (overLay.IsDisposed)
                {
                    overLay = new OverLay();
                    overLay.Location = z;
                    overLay.Text = "Overlay place";
                    overLay.TransparencyKey = Color.Empty;
                    overLay.FormBorderStyle = FormBorderStyle.FixedDialog;
                }
                overLay.ShowDialog();
                overLaycheck.Checked = false;
                
            }
            else
            {
                overLay.FormBorderStyle = FormBorderStyle.None;
                overLay.TransparencyKey = Color.Black;
                overLay.Dispose();
            }
           
           
            
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            GobleSettings.Default.Save();
            overLay.Dispose();
            
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            overLay_color_box.Color = GobleSettings.Default.Color;
            overLay_color_box.ShowDialog();
            if (overLay_color_box.Color == Color.Black)
            {
                overLay_color_box.Color = Color.DarkGray;
            }
            GobleSettings.Default.Color = overLay_color_box.Color;
            
        }
    }
}
