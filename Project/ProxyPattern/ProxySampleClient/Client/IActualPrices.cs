using System;
using System.Collections.Generic;
using System.Text;

namespace Client
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
