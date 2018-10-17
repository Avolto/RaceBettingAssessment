using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceBettingAssessment.Business.AllPunters
{
    class Matt : Punter, IBettingDetails
    {
        public Matt()
        {
            PunterName = "Matt";
            F1 = "";
            Cash = 20;
            MyColor = Color.DarkSlateBlue;
        }


        public int Won { get; set; }
        public int Lost { get; set; }

        public int TotalBets()
        {
            return Won + Lost;
        }
    }
}
