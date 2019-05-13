using System.Collections.Generic;

namespace Model.InfrastructureTheme.LineSections
{
    public class Parameters
    {
        public List<string> Dataset { get; set; }
        public string Timezone { get; set; }
        public int Rows { get; set; }
        public string format { get; set; }
        public List<string> Facet { get; set; }
    }
}
