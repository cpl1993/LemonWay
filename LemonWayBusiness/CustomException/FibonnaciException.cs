using System;
using System.Collections.Generic;
using System.Text;

namespace LemonWayBusiness.CustomException
{
    public class FibonnaciException : Exception
    {
        public FibonnaciException(int n)
            : base ($"Invalid number: {n}, it must be between 1 and 100")
        {

        }
    }
}
