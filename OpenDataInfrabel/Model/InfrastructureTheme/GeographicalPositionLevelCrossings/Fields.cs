using System.Collections.Generic;

namespace Model.InfrastructureTheme.GeographicalPositionLevelCrossings
{
    public class Fields
    {
        public string Fld_naam_ramses { get; set; }
        public string Fld_postcode_en_gemeente { get; set; }
        public List<double> Position_du_passage_a_niveau { get; set; }
        public string Fld_actief_passief { get; set; }
        public string Fld_geo_x { get; set; }
        public string Fld_geo_y { get; set; }
        public string Fld_o_of_p { get; set; }
    }
}
