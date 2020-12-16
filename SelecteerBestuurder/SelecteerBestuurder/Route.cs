using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelecteerBestuurder
{
    class Route
    {
        private double Xpoint;
        private double Ypoint;
        private double Xcurrent;
        private double Ycurrent;
        public bool RoeteKlaar { get; private set; }
        public double TotalDegree { get; private set; }
        public double Afstand { get; private set; }
        private int i;

        TCords cords = new TCords(); //Waarschijnlijk moeten we ernaar ander refrencen

        public Route()
        {
            //Xcurrent = aurocoordinaatX van nu; moet nog die communicatie uitvinden.
            //Ycurrent = aurocoordinaatY van nu; moet nog die communicatie uitvinden.
            i = 0;
            Xpoint = cords.XpointGo[i];
            Ypoint = cords.YpointGo[i];

            RoeteKlaar = false;

            //tijdelijk
            Xcurrent = 1;
            Ycurrent = 1;
            //tijdelijk
        }

        public void CalcRoute()
        {
            if (Xpoint != Xcurrent && Ypoint != Ycurrent)
            {
                double AngleDegree = Math.Atan((Ypoint - Ycurrent) / (Xpoint - Xcurrent)) * 180 / Math.PI;
                if (Xcurrent < Xpoint && Ycurrent < Ypoint)
                {
                    //point is rechtboven
                    TotalDegree = 90 - AngleDegree;
                }
                else if (Xcurrent < Xpoint && Ycurrent > Ypoint)
                {
                    //point is rechtbeneden
                    TotalDegree = 90 + AngleDegree;
                }
                else if (Xcurrent > Xpoint && Ycurrent > Ypoint)
                {
                    //point is linksbeneden
                    TotalDegree = 270 - AngleDegree;
                }
                else if (Xcurrent > Xpoint && Ycurrent < Ypoint)
                {
                    //point is linksboven
                    TotalDegree = 270 + AngleDegree;
                }
                Afstand = AfstandBerekenen(Xpoint, Xcurrent, Ypoint, Ycurrent);

                //Xcurrent = aurocoordinaatX van nu; moet nog die communicatie uitvinden.
                //Ycurrent = aurocoordinaatY van nu; moet nog die communicatie uitvinden.


                if (/*Xpoint == Xcurrent && Ypoint == Ycurrent*/ true /*!!!!!!!! We gan van uit dat auto perfect rijd!!!!!!!!!!*/)
                {
                    if (i == cords.XpointGo.Length)
                    {
                        RoeteKlaar = true;
                        return;
                    }

                    i++;
                    Xcurrent = Xpoint; //!!!!!!!! We gan van uit dat auto perfect rijd!!!!!!!!!!
                    Ycurrent = Ypoint; //!!!!!!!! We gan van uit dat auto perfect rijd!!!!!!!!!!
                    Xpoint = cords.XpointGo[i];
                    Ypoint = cords.YpointGo[i];
                }
            }
        }

        private double AfstandBerekenen(double Xpoint, double Xcurrent, double Ypoint, double Ycurrent)
        {
            double distance = Math.Sqrt(Math.Pow((Xpoint - Xcurrent), 2) + Math.Pow((Ypoint - Ycurrent), 2));
            return distance;
        }
    }
}
