using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App_Design_Pattern_SWE_4502_Lab_01
{
    public  class Payment
    {
        public int id;
        public Payment(int id)
        {
            this.id = id;
        }
        public int processpayment(int id)
        {
            return id * 1000;
        }
    }
}
