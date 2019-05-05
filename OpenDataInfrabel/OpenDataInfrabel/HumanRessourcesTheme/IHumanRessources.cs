using Model.HumanRessourcesTheme.DistanceBetweenWorkResidence;
using Model.HumanRessourcesTheme.DistributionStaffAge;
using Model.HumanRessourcesTheme.DistributionStaffGender;
using Model.HumanRessourcesTheme.DistributionStaffStudy;
using Model.HumanRessourcesTheme.DistributionStaffWorkType;
using Model.HumanRessourcesTheme.NumberFormationDays;
using Model.HumanRessourcesTheme.StaffTurnover;
using Model.HumanRessourcesTheme.TeleWorkDays;
using Model.HumanRessourcesTheme.TeleworkersPercentages;
using System.Threading.Tasks;

namespace OpenDataInfrabel.HumanRessourcesTheme
{
    public interface IHumanRessources
    {
        Task<DistanceBetweenWorkResidence> GetDistanceBetweenWorkResidence(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<TeleWorkDays> GetTeleWorkDays(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<NumberFormationDays> GetNumberFomrationDays(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<TeleworkersPercentages> GetTeleworkersPercentages(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<DistributionStaffWorkType> GetDistributionStaffByWorkType(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<DistributionStaffGender> GetDistributionStaffByGender(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<DistributionStaffStudy> GetDistributionStaffByLevelStudyFunction(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<DistributionStaffAge> GetDistributionStaffByAge(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<StaffTurnover> GetStaffTurnover(string q = null, string lang = "fr", int rows = 10, int start = 0);
    }
}
