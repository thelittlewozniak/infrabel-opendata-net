using System.Collections.Generic;

namespace Model.InfrastructureTheme.LineSections
{
    public class GeoShape
    {
        public string Type { get; set; }
        public List<List<double>> Coordinates { get; set; }
    }
}
