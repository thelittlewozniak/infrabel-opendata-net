using Model.ClientsProductsTheme.EvolutionEffectiveNumberTrainPaths;
using Model.ClientsProductsTheme.EvolutionNetTonnageYear;
using Model.ClientsProductsTheme.EvolutionTonsKilometers;
using Model.ClientsProductsTheme.EvolutionTrainsKilometers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataInfrabel.ClientsProductsTheme
{
    /// <summary>
    /// This class handle all call possible for Clients and products theme on the open data of Infrabel
    /// </summary>
    public class ClientsProducts : IDisposable, IClientsProducts
    {
        private readonly HttpClient httpClient;
        private bool disposed = false;
        private static readonly string url = "https://opendata.infrabel.be/api/records/1.0/search/?";
        /// <summary>
        /// Instantiation of the httpClient
        /// </summary>
        public ClientsProducts() => httpClient = new HttpClient();

        /// <summary>
        /// Get evolution of tons kilometers link = "https://opendata.infrabel.be/explore/dataset/evolution-des-tonnes-kilometres/information/?disjunctive.trimester&disjunctive.sector_fr"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> EvolutionTonsKilometers class type</returns>
        public async Task<EvolutionTonsKilometers> GetEvolutionTonsKilometers(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=evolution-des-tonnes-kilometres&facet=jaar&facet=trimester&facet=sector_fr"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<EvolutionTonsKilometers>(requestString);
            return result;
        }
        /// <summary>
        /// Get evolution of trains kilometers link = "https://opendata.infrabel.be/explore/dataset/evolution-des-trains-kilometres/information/?disjunctive.trimester&disjunctive.sector_fr"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> EvolutionTrainsKilometers class type</returns>
        public async Task<EvolutionTrainsKilometers> GetEvolutionTrainsKilometers(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=evolution-des-trains-kilometres&facet=jaar&facet=trimester&facet=sector_fr"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<EvolutionTrainsKilometers>(requestString);
            return result;
        }
        /// <summary>
        /// Evolution of the number of effective train paths link = "https://opendata.infrabel.be/explore/dataset/evolution-du-nombre-de-sillons-effectifs/information/?disjunctive.trimester&disjunctive.categorie_fr"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> EvolutionEffectiveNumberTrainPaths class type</returns>
        public async Task<EvolutionEffectiveNumberTrainPaths> GetEvolutionEffectiveNumberTrainPaths(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=evolution-du-nombre-de-sillons-effectifs&facet=jaar&facet=trimester&facet=categorie_fr"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<EvolutionEffectiveNumberTrainPaths>(requestString);
            return result;
        }
        /// <summary>
        /// Evolution of net tonnage per year link = "https://opendata.infrabel.be/explore/dataset/evolution-du-tonnage-net-par-an/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> EvolutionNetTonnageYear class type</returns>
        public async Task<EvolutionNetTonnageYear> GetEvolutionNetTonnageYear(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=evolution-du-tonnage-net-par-an&facet=jaar"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<EvolutionNetTonnageYear>(requestString);
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
