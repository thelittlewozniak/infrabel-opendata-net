﻿using Model.TrafficManagementTheme.MobipulseData;
using Model.TrafficManagementTheme.MonthlyDataOnCorrespondence;
using Model.TrafficManagementTheme.PunctualityArrivalBrussels;
using Model.TrafficManagementTheme.PunctualityArrivalBrusselsMoment;
using Model.TrafficManagementTheme.PunctualityArrivalBrusselsMomentMainLine;
using Model.TrafficManagementTheme.PunctualityEurostar;
using Model.TrafficManagementTheme.PunctualityFreightTrains;
using Model.TrafficManagementTheme.PunctualityICE;
using Model.TrafficManagementTheme.PunctualityICRelations;
using Model.TrafficManagementTheme.PunctualityICRelationsMoment;
using Model.TrafficManagementTheme.PunctualityMajorStationsMonth;
using Model.TrafficManagementTheme.PunctualityTGV;
using Model.TrafficManagementTheme.PunctualityThalys;
using Model.TrafficManagementTheme.RawPunctualityData;
using System;
using System.Threading.Tasks;

namespace OpenDataInfrabel.TrafficManagementTheme
{
    public interface ITrafficManagement:IDisposable
    {
        Task<RawPunctualityData> GetRawPunctualityData(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<MonthlyDataOnCorrespondence> GetMonthlyDataOnCorrespondence(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<MobipulseData> GetMobipulseData(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityArrivalBrussels> GetPunctualityArrivalBrussels(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityArrivalBrusselsMoment> GetPunctualityArrivalBrusselsMoment(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityArrivalBrusselsMomentMainLine> GetPunctualityArrivalBrusselsMomentMainLine(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityMajorStationsMonth> GetPunctualityMajorStationsMonth(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityICRelations> GetPunctualityICRelations(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityICRelationsMoment> GetPunctualityICRelationsMoment(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityTGV> GetPunctualityTGV(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityFreightTrains> GetPunctualityFreightTrains(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityEurostar> GetPunctualityEurostar(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityICE> GetPunctualityICE(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityThalys> GetPunctualityThalys(string q = null, string lang = "fr", int rows = 10, int start = 0);
    }
}
