using System.Collections.Generic;

namespace Model.InfrastructureTheme.GeographicalPositionMainRoutes
{
    public class Fields
    {
        public string Status { get; set; }
        public string Trackcode { get; set; }
        public string Modifdate { get; set; }
        public string Trackname { get; set; }
        public int Linecnum { get; set; }
        public List<double> Geo_point_2d { get; set; }
        public string Linecalfa { get; set; }
        public GeoShape Geo_shape { get; set; }
        public int Id { get; set; }
    }
}
