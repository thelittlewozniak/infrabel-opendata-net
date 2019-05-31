using Model.TrafficManagementTheme.MobipulseData;
using Model.TrafficManagementTheme.MonthlyDataOnCorrespondence;
using Model.TrafficManagementTheme.PunctualityArrivalBrussels;
using Model.TrafficManagementTheme.PunctualityArrivalBrusselsMoment;
using Model.TrafficManagementTheme.PunctualityArrivalBrusselsMomentMainLine;
using Model.TrafficManagementTheme.PunctualityMajorStationsMonth;
using Model.TrafficManagementTheme.RawPunctualityData;
using System.Threading.Tasks;

namespace OpenDataInfrabel.TrafficManagementTheme
{
    public interface ITrafficManagement
    {
        Task<RawPunctualityData> GetRawPunctualityData(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<MonthlyDataOnCorrespondence> GetMonthlyDataOnCorrespondence(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<MobipulseData> GetMobipulseData(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityArrivalBrussels> GetPunctualityArrivalBrussels(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityArrivalBrusselsMoment> GetPunctualityArrivalBrusselsMoment(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityArrivalBrusselsMomentMainLine> GetPunctualityArrivalBrusselsMomentMainLine(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<PunctualityMajorStationsMonth> GetPunctualityMajorStationsMonth(string q = null, string lang = "fr", int rows = 10, int start = 0);
        void Dispose();
    }
}
