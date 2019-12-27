using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Services.Extension
{
    public static class XYCoordinateExt
    {
        public static Point ToPoint(this XYCoordinate source)
        {
            return source == null ? null : new Point(source.X, source.Y);
        }
    }
}
