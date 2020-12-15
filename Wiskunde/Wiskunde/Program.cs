using System;

namespace Wiskunde
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Route = new Class1();
            Route.CalcRoute();

            Console.WriteLine(Route.Afstand + "m " + Route.TotalDegree + "Degree");
            string werking = "werkt dit zo?";




           /* double[] Xpoint = { 12, 33, 5, 18, 100 }; //gaan we uit andere class haalen 
            double[] Ypoint = { 321, 22, 2, 16, 200}; //gaan we uit andere class haalen 
            double Xcurrent = 33; //gaan we uit andere class haalen 
            double Ycurrent = 12; //gaan we uit andere class haalen 
            double TotalDegree = 0;
            double Afstand = 0;

            for (int i = 0; i < Xpoint.Length;)
            {
                if (Xpoint[i] != Xcurrent && Ypoint[i] != Ycurrent)
                {
                    double AngleDegree = Math.Atan((Ypoint[i] - Ycurrent) / (Xpoint[i] - Xcurrent)) * 180 / Math.PI;
                    if (Xcurrent < Xpoint[i] && Ycurrent < Ypoint[i])
                    {
                        //point is rechtboven
                        TotalDegree = 90 - AngleDegree;
                        Afstand = AfstandBerekenen(Xpoint[i], Xcurrent, Ypoint[i], Ycurrent);
                    }
                    else if (Xcurrent < Xpoint[i] && Ycurrent > Ypoint[i])
                    {
                        //point is rechtbeneden
                        TotalDegree = 90 + AngleDegree;
                        Afstand = AfstandBerekenen(Xpoint[i], Xcurrent, Ypoint[i], Ycurrent);
                    }
                    else if (Xcurrent > Xpoint[i] && Ycurrent > Ypoint[i])
                    {
                        //point is linksbeneden
                        TotalDegree = 270 - AngleDegree;
                        Afstand = AfstandBerekenen(Xpoint[i], Xcurrent, Ypoint[i], Ycurrent);
                    }
                    else if (Xcurrent > Xpoint[i] && Ycurrent < Ypoint[i])
                    {
                        //point is linksboven
                        TotalDegree = 270 + AngleDegree;
                        Afstand = AfstandBerekenen(Xpoint[i], Xcurrent, Ypoint[i], Ycurrent);
                    }
                    Console.WriteLine("Next point is " + Afstand + "m and " + TotalDegree + "° from North");

                    //ONLY FOR TEST THE UPDATE WOULD COME FROM OTHER CLASS
                    Xcurrent = Xpoint[i];
                    Ycurrent = Ypoint[i];
                    //ONLY FOR TEST THE UPDATE WOULD COME FROM OTHER CLASS

                    if (Xpoint[i] == Xcurrent && Ypoint[i] == Ycurrent)
                    {
                        i++;
                    }
                }
            }*/
        }

        /*private static double AfstandBerekenen(double Xpoint, double Xcurrent, double Ypoint, double Ycurrent)
        {
            double dystance = Math.Sqrt((Xpoint - Xcurrent) * (Xpoint - Xcurrent) + (Ypoint - Ycurrent) * (Ypoint - Ycurrent));
            return dystance;
        }*/
    }
}
