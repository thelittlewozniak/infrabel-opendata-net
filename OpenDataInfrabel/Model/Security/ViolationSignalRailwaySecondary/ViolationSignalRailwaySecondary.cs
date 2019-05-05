﻿using System.Collections.Generic;

namespace Model.Security.ViolationSignal
{
    public class ViolationSignalRailwaySecondary
    {
        public int Nhits { get; set; }
        public Parameters Parameters { get; set; }
        public List<Record> Records { get; set; }
        public List<FacetGroup> Facet_groups { get; set; }
    }
}