using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenDataInfrabel
{
    public class OpenDataCall : IDisposable
    {
        private static readonly string url = "https://opendata.infrabel.be/api/records/1.0/search/?";
        private readonly HttpClient httpClient;
        private bool disposed = false;
        
        public OpenDataCall()
        {
            httpClient = new HttpClient();
        }
        
        protected async Task<string> MakeCall(string dataset, string q, string lang, int rows, int start, string[] facet)
        {
            StringBuilder finalUrl = new StringBuilder($"{url}dataset={dataset}");
            for (int i = 0; i < facet.Length; i++)
            {
                finalUrl.Append($"&facet={facet[i]}");
            }
            finalUrl.Append(q == null ? "" : $"&q={q}"));
            finalUrl.Append($"&lang={lang}&rows={rows}&start={start}");

            var request = await httpClient.GetAsync(finalUrl.ToString());
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
