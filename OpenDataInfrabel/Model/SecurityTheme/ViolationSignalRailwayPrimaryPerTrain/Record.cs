﻿using System;
namespace Model.SecurityTheme.ViolationSignalRailwayPrimaryPerTrain
{
    public class Record
    {
        public string Datasetid { get; set; }
        public string Recordid { get; set; }
        public Fields Fields { get; set; }
        public DateTime Record_timestamp { get; set; }
    }
}
