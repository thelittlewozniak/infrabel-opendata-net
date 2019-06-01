using Model.TrafficManagementTheme.MobipulseData;
using Model.TrafficManagementTheme.MonthlyDataOnCorrespondence;
using Model.TrafficManagementTheme.NationalPunctualityMomentMonth;
using Model.TrafficManagementTheme.NationalPunctualityMonth;
using Model.TrafficManagementTheme.NationalPunctualityWithTrainsRemoved;
using Model.TrafficManagementTheme.NationalWeightedPunctualityMonth;
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
using Model.TrafficManagementTheme.PunctualityTypeTrain;
using Model.TrafficManagementTheme.PunctualityTypeTrainMoment;
using Model.TrafficManagementTheme.RawPunctualityData;
using Model.TrafficManagementTheme.ResponsibilityDelaysMonth;
using Model.TrafficManagementTheme.ResponsibilityTrainDeletions;
using Model.TrafficManagementTheme.SignalingStations;
using Model.TrafficManagementTheme.TrainsDeletedMonth;
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
        Task<NationalPunctualityMonth> GetNationalPunctualityMonth(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<NationalPunctualityMomentMonth> GetNationalPunctualityMomentMonth(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<NationalWeightedPunctualityMonth> GetNationalWeightedPunctualityMonth(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<NationalPunctualityWithTrainsRemoved> GetNationalPunctualityWithTrainsRemoved(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityTypeTrain> GetPunctualityTypeTrain(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityTypeTrainMoment> GetPunctualityTypeTrainMoment(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<SignalingStations> GetSignalingStations(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<ResponsibilityDelaysMonth> GetResponsibilityDelaysMonth(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<ResponsibilityTrainDeletions> GetResponsibilityTrainDeletions(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<TrainsDeletedMonth> GetTrainsDeletedMonth(string q = null, string lang = "fr", int rows = 10, int start = 0);
    }
}
