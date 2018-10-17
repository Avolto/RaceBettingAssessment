using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceBettingAssessment.Business.AllPunters
{
    class Zoe : Punter, IBettingDetails
    {
        public Zoe()
        {
            PunterName = "Zoe";
            F1 = "";
            Cash = 20;
            MyColor = Color.LightSeaGreen;
        }


        public int Won { get; set; }
        public int Lost { get; set; }

        public int TotalBets()
        {
            return Won + Lost;
        }
    }
}
