using Model.Security.Accidents;
using Model.Security.ViolationSignal;
using Model.Security.ViolationSignalRailwayPrimary;
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
