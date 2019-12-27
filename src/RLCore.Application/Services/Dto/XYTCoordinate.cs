using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Services
{
    public class XYTCoordinate : XYCoordinate, IComparable<XYTCoordinate>
    {
        public int SecondSinceStart { get; set; }

        public int CompareTo(XYTCoordinate other)
        {
            if (other == null) return 1;
            return SecondSinceStart.CompareTo(other.SecondSinceStart);
        }
    }
}
