using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceBettingAssessment.Business.AllPunters
{
  public  class Factory
    {
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0: return new Matt();
                case 1: return new Clark();
                case 2: return new Zoe();

                default: return null;
            }
        }
    }
}
