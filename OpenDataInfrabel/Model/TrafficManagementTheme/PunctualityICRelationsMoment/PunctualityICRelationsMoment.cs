using System.Collections.Generic;

namespace Model.TrafficManagementTheme.PunctualityICRelationsMoment
{

    public class PunctualityICRelationsMoment
    {
        public int Nhits { get; set; }
        public Parameters Parameters { get; set; }
        public List<Record> Records { get; set; }
        public List<FacetGroup> Facet_groups { get; set; }
    }
}
