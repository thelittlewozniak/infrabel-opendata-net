using System.Collections.Generic;

namespace Model.InfrastructureTheme.GeographicalPositionMainRoutes
{
    public class GeoShape
    {
        public string Type { get; set; }
        public List<List<List<double>>> Coordinates { get; set; }
    }
}
