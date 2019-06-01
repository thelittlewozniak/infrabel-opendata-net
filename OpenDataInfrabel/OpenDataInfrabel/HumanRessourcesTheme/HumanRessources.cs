using Model.HumanRessourcesTheme.DistanceBetweenWorkResidence;
using Model.HumanRessourcesTheme.DistributionStaffAge;
using Model.HumanRessourcesTheme.DistributionStaffGender;
using Model.HumanRessourcesTheme.DistributionStaffStudy;
using Model.HumanRessourcesTheme.DistributionStaffWorkType;
using Model.HumanRessourcesTheme.NumberFormationDays;
using Model.HumanRessourcesTheme.StaffTurnover;
using Model.HumanRessourcesTheme.TeleWorkDays;
using Model.HumanRessourcesTheme.TeleworkersPercentages;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace OpenDataInfrabel.HumanRessourcesTheme
{
    /// <summary>
    /// This class handle all call possible for Human Ressources theme on the open data of Infrabel
    /// </summary>
    public class HumanRessources : OpenDataCall, IHumanRessources
    {
        /// <summary>
        /// Instantiation of the httpClient
        /// </summary>
        public HumanRessources() : base() { }
        /// <summary>
        /// Distance between place of residence and place of work 
        /// link = "https://opendata.infrabel.be/explore/dataset/distance-entre-le-lieu-de-residence-et-le-lieu-de-travail/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> EvolutionNetTonnageYear class type</returns>
        public async Task<DistanceBetweenWorkResidence> GetDistanceBetweenWorkResidence(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("distance-entre-le-lieu-de-residence-et-le-lieu-de-travail", q, lang, rows, start, new string[]{
                "year",
                "q",
                "category"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<DistanceBetweenWorkResidence>(res);
            return result;
        }
        /// <summary>
        /// Telework days 
        /// link = "https://opendata.infrabel.be/explore/dataset/jours-de-teletravail/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> TeleWorkDays class type</returns>
        public async Task<TeleWorkDays> GetTeleWorkDays(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("jours-de-teletravail", q, lang, rows, start, new string[]{
                "year",
                "q",
                "category"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<TeleWorkDays>(res);
            return result;
        }
        /// <summary>
        /// Number of Formation days 
        /// link = "https://opendata.infrabel.be/explore/dataset/nombre-de-jours-de-formation/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> NumberFormationDays class type</returns>
        public async Task<NumberFormationDays> GetNumberFomrationDays(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("nombre-de-jours-de-formation", q, lang, rows, start, new string[]{
                "year",
                "q",
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<NumberFormationDays>(res);
            return result;
        }
        /// <summary>
        /// Percentages of teleworkers 
        /// link = "https://opendata.infrabel.be/explore/dataset/pourcentages-de-teletravailleurs/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> TeleworkersPercentages class type</returns>
        public async Task<TeleworkersPercentages> GetTeleworkersPercentages(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("pourcentages-de-teletravailleurs", q, lang, rows, start, new string[]{
                "year",
                "q",
                "category"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<TeleworkersPercentages>(res);
            return result;
        }
        /// <summary>
        /// distribution of staff according to the type of job 
        /// link = "https://opendata.infrabel.be/explore/dataset/repartition-du-personnel-en-fonction-du-type-de-metier/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> DistributionStaffWorkType class type</returns>
        public async Task<DistributionStaffWorkType> GetDistributionStaffByWorkType(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("repartition-du-personnel-en-fonction-du-type-de-metier", q, lang, rows, start, new string[]{
                "year",
                "q",
                "category"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<DistributionStaffWorkType>(res);
            return result;
        }
        /// <summary>
        /// staff distribution by gender
        /// link = "https://opendata.infrabel.be/explore/dataset/repartition-du-personnel-par-genre/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> DistributionStaffGender class type</returns>
        public async Task<DistributionStaffGender> GetDistributionStaffByGender(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("repartition-du-personnel-par-genre", q, lang, rows, start, new string[]{
                "year",
                "q",
                "category"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<DistributionStaffGender>(res);
            return result;
        }
        /// <summary>
        /// Breakdown of staff by level of study of the function
        /// link = "https://opendata.infrabel.be/explore/dataset/repartition-du-personnel-par-niveau-detude-de-la-fonction/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> DistributionStaffStudy class type</returns>
        public async Task<DistributionStaffStudy> GetDistributionStaffByLevelStudyFunction(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("repartition-du-personnel-par-niveau-detude-de-la-fonction", q, lang, rows, start, new string[]{
                "year",
                "q",
                "category"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<DistributionStaffStudy>(res);
            return result;
        }
        /// <summary>
        /// Staff distribution by age group
        /// link = "https://opendata.infrabel.be/explore/dataset/repartition-du-personnel-par-tranche-dage/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> DistributionStaffAge class type</returns>
        public async Task<DistributionStaffAge> GetDistributionStaffByAge(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("repartition-du-personnel-par-tranche-dage", q, lang, rows, start, new string[]{
                "year",
                "q",
                "category"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<DistributionStaffAge>(res);
            return result;
        }
        /// <summary>
        /// Staff turnover
        /// link = "https://opendata.infrabel.be/explore/dataset/roulement-du-personnel/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> StaffTurnover class type</returns>
        public async Task<StaffTurnover> GetStaffTurnover(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("roulement-du-personnel", q, lang, rows, start, new string[]{
                "year",
                "q",
                "category"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<StaffTurnover>(res);
            return result;
        }
    }
}
