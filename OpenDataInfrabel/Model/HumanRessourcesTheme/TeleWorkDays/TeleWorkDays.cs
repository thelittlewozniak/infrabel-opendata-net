using System.Collections.Generic;

namespace Model.HumanRessourcesTheme.TeleWorkDays
{
    public class TeleWorkDays
    {
        public int nhits { get; set; }
        public Parameters parameters { get; set; }
        public List<Record> records { get; set; }
        public List<FacetGroup> facet_groups { get; set; }
    }
}
