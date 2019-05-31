using Model.SecurityTheme.Accidents;
using Model.SecurityTheme.AutomaticProtectionSystem;
using Model.SecurityTheme.PrecursorsSecurity;
using Model.SecurityTheme.ViolationRailway;
using Model.SecurityTheme.ViolationSignal;
using Model.SecurityTheme.ViolationSignalRailwayPrimary;
using Model.SecurityTheme.ViolationSignalRailwayPrimaryPerTrain;
using System.Threading.Tasks;

namespace OpenDataInfrabel.SecurityTheme
{
    public interface ISecurity
    {
        Task<Accident> GetAccidentsCSI(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<Accident> GetAccidentsISI(string q = null, string lang = "FR", int rows = 10, int start = 0);
        Task<ViolationSignalRailwaySecondary> GetViolationSignalRailwaySecondary(string q = null, string lang = "FR", int rows = 10, int start = 0);
        Task<ViolationSignalRailwayPrimary> GetViolationSignalRailwayPrimary(string q = null, string lang = "FR", int rows = 10, int start = 0);
        Task<ViolationSignalRailwayPrimaryPerTrain> GetViolationSignalRailwayPrimaryPerTrain(string q = null, string lang = "FR", int rows = 10, int start = 0);
        Task<ViolationRailway> GetViolationRailway(string q = null, string lang = "FR", int rows = 10, int start = 0);
        Task<PrecursorsSecurity> GetPrecursorsSecurity(string q = null, string lang = "FR", int rows = 10, int start = 0);
        Task<AutomaticProtectionSystem> GetAutomaticProtectionSystem(string q = null, string lang = "FR", int rows = 10, int start = 0);
        void Dispose();
    }
}
