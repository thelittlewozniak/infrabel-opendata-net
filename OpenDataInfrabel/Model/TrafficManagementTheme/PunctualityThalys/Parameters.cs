using System.Collections.Generic;

namespace Model.TrafficManagementTheme.PunctualityThalys
{
    public class Parameters
    {
        public List<string> Dataset { get; set; }
        public string Timezone { get; set; }
        public int Rows { get; set; }
        public string Format { get; set; }
        public List<string> Facet { get; set; }
    }
}
