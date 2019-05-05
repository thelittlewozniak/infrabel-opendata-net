using Model.Security.Accidents;
using Model.Security.AutomaticProtectionSystem;
using Model.Security.PrecursorsSecurity;
using Model.Security.ViolationRailway;
using Model.Security.ViolationSignal;
using Model.Security.ViolationSignalRailwayPrimary;
using Model.Security.ViolationSignalRailwayPrimaryPerTrain;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenDataInfrabel.Security
{
    public class Security:IDisposable
    {
        private readonly HttpClient httpClient;
        private bool disposed = false;
        private static readonly string url = "https://opendata.infrabel.be/api/records/1.0/search/?";
        public Security()
        {
            httpClient = new HttpClient();
        }
        /// <summary>
        /// Get accidents CSI link = "https://opendata.infrabel.be/explore/dataset/accidents-csi/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> Accident class type</returns>
        public async Task<Accident> GetAccidentsCSI(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=accidents-csi&facet=column_1"
                +( q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Accident>(requestString);
            return result;
        }
        /// <summary>
        /// Get Accidents ISI link = "https://opendata.infrabel.be/explore/dataset/accidents-isi/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> Accident class type</returns>
        public async Task<Accident> GetAccidentsISI(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=accidents-isi&facet=column_1"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Accident>(requestString);
            return result;
        }
        /// <summary>
        ///  Get Violation of Signals on secondary Railway link = "https://opendata.infrabel.be/explore/dataset/depassements-de-signaux-en-voie-accessoires/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>ViolationSignalRailwaySecondary class type</returns>
        public async Task<ViolationSignalRailwaySecondary> GetViolationSignalRailwaySecondary(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=depassements-de-signaux-en-voie-accessoires&facet=annee_jaar"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ViolationSignalRailwaySecondary>(requestString);
            return result;
        }
        /// <summary>
        /// Get Violation of Signals on primary Railway link = "https://opendata.infrabel.be/explore/dataset/depassements-de-signaux-en-voies-principales/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>ViolationSignalRailwayPrimary class type</returns>
        public async Task<ViolationSignalRailwayPrimary> GetViolationSignalRailwayPrimary(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=depassements-de-signaux-en-voies-principales&facet=column_1"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ViolationSignalRailwayPrimary>(requestString);
            return result;
        }
        /// <summary>
        /// Get Violation of Signals on primary Railway per type of Train link = "https://opendata.infrabel.be/explore/dataset/depassements-de-signaux-par-type-de-train-sur-les-voies-principales/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>ViolationSignalRailwayPrimaryPerTrain class type</returns>
        public async Task<ViolationSignalRailwayPrimaryPerTrain> GetViolationSignalRailwayPrimaryPerTrain(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=depassements-de-signaux-par-type-de-train-sur-les-voies-principales&facet=annee_jaar&facet=type_de_train_trein_type_voie_principale"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ViolationSignalRailwayPrimaryPerTrain>(requestString);
            return result;
        }
        /// <summary>
        /// Get Violation on Railway link = "https://opendata.infrabel.be/explore/dataset/intrusions-sur-les-voies/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>ViolationRailway class type</returns>
        public async Task<ViolationRailway> GetViolationRailway(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=intrusions-sur-les-voies&facet=column_1"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ViolationRailway>(requestString);
            return result;
        }
        /// <summary>
        /// Get Precursors security link = "https://opendata.infrabel.be/explore/dataset/precurseurs-securite/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>PrecursorsSecurity class type</returns>
        public async Task<PrecursorsSecurity> GetPrecursorsSecurity(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=precurseurs-securite&facet=column_1"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<PrecursorsSecurity>(requestString);
            return result;
        }
        /// <summary>
        /// Get Automatic Protection System link = "https://opendata.infrabel.be/explore/dataset/systemes-de-protection-automatique/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>AutomaticProtectionSystem class type</returns>
        public async Task<AutomaticProtectionSystem> GetAutomaticProtectionSystem(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=systemes-de-protection-automatique&facet=column_1"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AutomaticProtectionSystem>(requestString);
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
