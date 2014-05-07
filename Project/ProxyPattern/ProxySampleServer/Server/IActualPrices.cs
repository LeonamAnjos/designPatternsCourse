using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    interface IActualPrices
    {
        string GoldPrice
        {
            get;
        }

        string SilverPrice
        {
            get;
        }

        string DollarToRupee
        {
            get;
        }
    }
}
