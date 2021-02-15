using EliteStatus;
using Geo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Speedometer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private static List<List<double>> Points = new List<List<double>>();
        private static List<DateTime> Time = new List<DateTime>();
        OverLay over = new OverLay();
        Elite_Status elite = new Elite_Status();




        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            settings.Activate();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        public void MainWindow_Load(object sender, EventArgs e)
        {

            elite.JsonStatus += Elite_JsonStatus;
            elite.Start();
           
        }

        public void Elite_JsonStatus(object sender, Status e)
        {
           


                if (e.HasLatLong == true)
                {
               
               
                    HeadingValue.Text = e.Heading.ToString("F1");
                    AltitudeVale.Text = e.Altitude.ToString("F1");
                    over.HeadingValule.Text = e.Heading.ToString("F1");
                    over.AltitudeValule.Text = e.Altitude.ToString("F1");

                    Points.Add(LaTLongPoints(e.Latiude, e.Longitude));
                    Time.Add(e.Timestamp);
                    if (Points.Count < 1)
                    {
                        Points.Add(LaTLongPoints(e.Latiude, e.Longitude));
                        Time.Add(e.Timestamp);
                    }
                    if (Points.Count == 2)
                    {

                        double Dist = Geodesy.Distance(Points[0], Points[1], e.PlanetRadius);

                        double speed = Dist / Ponttimes(Time).TotalSeconds;

                        SpeedValule.Text = Math.Abs(speed).ToString("F1");
                        over.SpeedValue.Text = Math.Abs(speed).ToString("F1");
                        Time.Clear();
                        Points.Clear();
                        Time.Add(e.Timestamp);
                        Points.Add(LaTLongPoints(e.Latiude, e.Longitude));
                    }


                }
                if (e.HasLatLong == false)
                {
                    HeadingValue.Text="In space";
                    AltitudeVale.Text = "In space";
                    SpeedValule.Text = "In space";
                    over.SpeedValue.Text = "In space";
                    over.HeadingValule.Text = "In space";
                    over.AltitudeValule.Text = "In space";
                    Points.Clear();
                }

            
        }
        private static List<double> LaTLongPoints(double Latiude, double Longitude)
        {
            List<double> points = Geodesy.Vectores(Latiude, Longitude);

            return points;

        }

        private static TimeSpan Ponttimes(List<DateTime> TimeStamps)
        {
            return TimeStamps[0] - TimeStamps[1];

        }
        private void OverLayMuenu_CheckedChanged(object sender, EventArgs e)
        {
            Point z = new Point(GobleSettings.Default.OverlayX, GobleSettings.Default.OverlayY);

            over.Location = z;
            if (OverLayMuenu.Checked == true)
            {
                if (over.IsDisposed)
                {
                    over = new OverLay();
                    over.Location = z;

                }
                over.Show();


            }
            if (OverLayMuenu.Checked == false)
            {
                over.Dispose();


            }
        }

        

    }
}
