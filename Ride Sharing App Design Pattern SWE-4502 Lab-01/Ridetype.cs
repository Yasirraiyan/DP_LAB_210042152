using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App_Design_Pattern_SWE_4502_Lab_01
{
    public class Ridetype
    {
        public int id;
        public Ridetype(int id)
        {
            this.id = id;
        }
        public int farecalculation(int id)
        {

            return id * 1500;

        }

    }
}
