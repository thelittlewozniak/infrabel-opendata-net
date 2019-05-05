using System.Collections.Generic;

namespace Model.ClientsProducts.EvolutionTonsKilometers
{
    public class EvolutionTonsKilometers
    {
        public int Nhits { get; set; }
        public Parameters Parameters { get; set; }
        public List<Record> Records { get; set; }
        public List<FacetGroup> Facet_groups { get; set; }
    }
}
