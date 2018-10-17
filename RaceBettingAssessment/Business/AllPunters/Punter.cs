using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceBettingAssessment.Business.AllPunters
{
    public abstract class Punter
    {
        public string PunterName { get; set; }
        public string F1 { get; set; }
        public Single Cash {get; set;}
        public Single Bet { get; set; }
        public Label LabelWinner { get; set; }
        public Color MyColor { get; set; }
        public NumericUpDown udBet { get; set; }

    }
}
