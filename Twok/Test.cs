using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twok
{

    struct data
    {
        int currentTour;
        float tourTime;
        float pistonFallTime;
        int pistonMovementCount;
    }
    class Test
    {
        string productId;
        int testUnitNumber;
        List<data> dataCollection;

        public Test()
        {
            dataCollection = new List<data>();
            //değişti
        }
    }
}
