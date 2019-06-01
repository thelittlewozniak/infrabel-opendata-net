using System.Collections.Generic;

namespace Model.InfrastructureTheme.KilometersMarkersNetwork
{
    public class GeoShape
    {
        public string Type { get; set; }
        public List<List<double>> Coordinates { get; set; }
    }
}
