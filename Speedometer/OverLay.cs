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
    public partial class OverLay : Form
    {
        public OverLay()
        {
            InitializeComponent();
        }

        private void OverLay_Load(object sender, EventArgs e)
        {
            SetColor();
        }
        private void SetColor()
        {
            Color Custom = GobleSettings.Default.Color;
            SpeedOverGround.ForeColor = Custom;
            SpeedValue.ForeColor = Custom;
            AltitudeText.ForeColor = Custom;
            AltitudeValule.ForeColor = Custom;
            HeadingText.ForeColor = Custom;
            HeadingValule.ForeColor = Custom;

        }

        private void OverLay_FormClosing(object sender, FormClosingEventArgs e)
        {
            GobleSettings.Default.OverlayY = this.Location.Y;
            GobleSettings.Default.OverlayX = this.Location.X;
            GobleSettings.Default.Save();
            GobleSettings.Default.Upgrade();
        }
    }
    
}
