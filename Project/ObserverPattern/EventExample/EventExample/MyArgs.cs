using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventExample
{
    class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }

        public int Value
        {
            get;
            set;
        }
    }
}
