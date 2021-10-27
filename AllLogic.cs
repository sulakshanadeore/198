using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApp
{
    public class AllLogic
    {
        public bool Validatecustomer(int userid, string p)
        {
            bool ans = false;
            if (userid==123 && p=="abc@123")
            {
                ans = true;
            }
            return ans;

        }

    }
}