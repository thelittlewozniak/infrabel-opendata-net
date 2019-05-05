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
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataInfrabel.HumanRessourcesTheme
{
    /// <summary>
    /// This class handle all call possible for Human Ressources theme on the open data of Infrabel
    /// </summary>
    public class HumanRessources : IHumanRessources
    {
        private readonly HttpClient httpClient;
        private bool disposed = false;
        private static readonly string url = "https://opendata.infrabel.be/api/records/1.0/search/?";
        /// <summary>
        /// Instantiation of the httpClient
        /// </summary>
        public HumanRessources() => httpClient = new HttpClient();
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
            var finalUrl = url + "dataset=distance-entre-le-lieu-de-residence-et-le-lieu-de-travail&facet=year&facet=q&facet=category"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<DistanceBetweenWorkResidence>(requestString);
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
            var finalUrl = url + "dataset=jours-de-teletravail&facet=year&facet=q&facet=category"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TeleWorkDays>(requestString);
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
            var finalUrl = url + "dataset=jours-de-teletravail&facet=year&facet=q"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<NumberFormationDays>(requestString);
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
            var finalUrl = url + "dataset=pourcentages-de-teletravailleurs&facet=year&facet=q&facet=category"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TeleworkersPercentages>(requestString);
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
            var finalUrl = url + "dataset=repartition-du-personnel-en-fonction-du-type-de-metier&facet=year&facet=q&facet=category"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<DistributionStaffWorkType>(requestString);
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
            var finalUrl = url + "dataset=repartition-du-personnel-par-genre&facet=year&facet=q&facet=category"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<DistributionStaffGender>(requestString);
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
            var finalUrl = url + "dataset=repartition-du-personnel-par-niveau-detude-de-la-fonction&facet=year&facet=q&facet=category"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<DistributionStaffStudy>(requestString);
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
            var finalUrl = url + "dataset=repartition-du-personnel-par-tranche-dage&facet=year&facet=q&facet=category"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<DistributionStaffAge>(requestString);
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
            var finalUrl = url + "dataset=roulement-du-personnel&facet=year&facet=q&facet=category"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<StaffTurnover>(requestString);
            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    httpClient.Dispose();
                }
                disposed = true;
            }
        }

    }
}
