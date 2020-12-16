using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SelecteerBestuurder
{
    class AutonomeBestuurder
    {
        Route Route = new Route();
        UDP AutoUDP = new UDP();

        private double Afstand;
        private double Graden;
        private double tijdAfstand;
        private double tijdGraden;
        private int snelheidRijden;
        private int snelheidDraaien;
        private int SafetyDelay;

        public AutonomeBestuurder()
        {
            SafetyDelay = 1000; 

            //snelheidRijden = Wat vincent zegt in meter per seconden;

            //snelheidDraaien = Wat vinece beweert in graden per seconde;
        }


        // afstand / snelheid = tijd

        public void RouteRijden()
        {
            GetInfo();
            while (!Route.RoeteKlaar)
            {
                tijdAfstand = Afstand / snelheidRijden;
                tijdGraden = Graden / snelheidDraaien;
                AutoUDP.SendUDP("D" + tijdGraden);
                Thread.Sleep(Convert.ToInt32(tijdGraden) * 1000 + SafetyDelay); //ff van sec milisec maaken
                AutoUDP.SendUDP("W" + tijdAfstand);
                Thread.Sleep(Convert.ToInt32(tijdAfstand) * 1000 + SafetyDelay);
                GetInfo();
            }
        }

        private void GetInfo()
        {
            Route.CalcRoute(/*welke route gecalculater moet worden*/);
            this.Afstand = Route.Afstand;
            // W(naar voore) afstande(in meter)
            this.Graden = Route.TotalDegree;
            // D(draaien met klok mee) Granden(in graden)
        }
    }
}
