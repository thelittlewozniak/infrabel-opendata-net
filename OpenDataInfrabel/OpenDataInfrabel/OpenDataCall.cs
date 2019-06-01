using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenDataInfrabel
{
    public class OpenDataCall:IDisposable
    {
        private readonly HttpClient httpClient;
        private bool disposed = false;
        private static readonly string url = "https://opendata.infrabel.be/api/records/1.0/search/?";
        public OpenDataCall() => httpClient = new HttpClient();
        protected async Task<string> MakeCall(string dataset, string q, string lang, int rows, int start, string[] facet)
        {
            var finalUrl = url + "dataset=" + dataset;
            for (int i = 0; i < facet.Length; i++)
            {
                finalUrl += ("&facet=" + facet[i]);
            }
            finalUrl += (q == null ? "" : "&q=" + q) + "&lang=" + lang + "&rows=" + rows + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            return requestString;
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
