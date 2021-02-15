using System;
using System.Collections.Generic;

namespace Geo
{
    class Geodesy
    {
        public static double DegToRad(double angle)
        {
            double deg = angle * Math.PI / 180;
            return deg;

        }
        public static double RadtoDeg(double angle)
        {
            double deg = angle * 180 / Math.PI;
            return deg;

        }
        public static double MetersToKilometers(double Meters)
        {
            double M = Meters / 1000;
            return M;
        }

        public static List<double> Vectores(double Latiude, double Longitude)
        {


            double x = Math.Cos(DegToRad(Latiude)) * Math.Cos(DegToRad(Longitude));
            double Y = Math.Cos(DegToRad(Latiude)) * Math.Sin(DegToRad(Longitude));
            double z = Math.Sin(DegToRad(Latiude));

            List<double> XYZ = new List<double>
            {
                x,
                Y,
                z
            };
            return XYZ;
        }
        public static double Distance(List<double> pont1, List<double> point2)
        {
            double D;
            double x = pont1[0] * point2[0];
            double y = pont1[1] * point2[1];
            double z = pont1[2] * point2[2];
            D = x + y + z;
            double ang = Math.Acos(D);
            double deg = RadtoDeg(ang);
            double destion = deg / 360 * 24881;



            return destion;
        }

        public static double Distance(List<double> pont1, List<double> point2, double radous)
        {
            double D;
            double R = radous;
            double x = pont1[0] * point2[0];
            double y = pont1[1] * point2[1];
            double z = pont1[2] * point2[2];
            D = x + y + z;
            double ang = Math.Acos(D);
            double deg = RadtoDeg(ang);
            double destion = deg / 360 * R * 2 * Math.PI;



            return destion;
        }
        public static double Distance(double Latiude, double longitude, double Latiude2, double longitude2, double radous)
        {
            List<double> pont1 = Vectores(Latiude, longitude);
            List<double> point2 = Vectores(Latiude2, longitude2);
            double D;


            double x = pont1[0] * point2[0];
            double y = pont1[1] * point2[1];
            double z = pont1[2] * point2[2];
            D = x + y + z;
            double ang = Math.Acos(D);
            double deg = Geodesy.RadtoDeg(ang);
            double destion = deg / 360 * radous * 2 * Math.PI;



            return destion;
        }

    }
}
