using System;
using System.Collections.Generic;
using System.Text;

namespace Model.HumanRessourcesTheme.TeleworkersPercentages
{
    public class Parameters
    {
        public List<string> Dataset { get; set; }
        public string Timezone { get; set; }
        public int Rows { get; set; }
        public string Format { get; set; }
        public List<string> facet { get; set; }
    }
}
