using System.Collections.Generic;

namespace Model.TrafficManagementTheme.PunctualityTypeTrain
{
    public class PunctualityTypeTrain
    {
        public int Nhits { get; set; }
        public Parameters Parameters { get; set; }
        public List<Record> Records { get; set; }
        public List<FacetGroup> Facet_groups { get; set; }
    }
}
