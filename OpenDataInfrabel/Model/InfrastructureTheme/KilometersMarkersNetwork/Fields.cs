using System.Collections.Generic;

namespace Model.InfrastructureTheme.KilometersMarkersNetwork
{
    public class Fields
    {
        public string Name { get; set; }
        public List<double> Geo_point_2d { get; set; }
        public GeoShape Geo_shape { get; set; }
        public string Y { get; set; }
        public string X { get; set; }
        public string Id { get; set; }
    }
}
