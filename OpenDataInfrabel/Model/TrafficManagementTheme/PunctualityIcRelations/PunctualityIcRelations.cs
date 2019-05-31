using System.Collections.Generic;
using System.Text;

namespace Model.TrafficManagementTheme.PunctualityICRelations
{
    public class PunctualityICRelations
    {
        public int Nhits { get; set; }
        public Parameters Parameters { get; set; }
        public List<Record> Records { get; set; }
        public List<FacetGroup> Facet_groups { get; set; }
    }
}
