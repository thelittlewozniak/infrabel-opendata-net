using Model.ClientsProductsTheme.EvolutionEffectiveNumberTrainPaths;
using Model.ClientsProductsTheme.EvolutionNetTonnageYear;
using Model.ClientsProductsTheme.EvolutionTonsKilometers;
using Model.ClientsProductsTheme.EvolutionTrainsKilometers;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenDataInfrabel.ClientsProductsTheme
{
    /// <summary>
    /// This class handle all call possible for Clients and products theme on the open data of Infrabel
    /// </summary>
    public class ClientsProducts : OpenDataCall, IClientsProducts
    {
        /// <summary>
        /// Instantiation of the httpClient
        /// </summary>
        public ClientsProducts() : base() { }

        /// <summary>
        /// Get evolution of tons kilometers 
        /// link = "https://opendata.infrabel.be/explore/dataset/evolution-des-tonnes-kilometres/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> EvolutionTonsKilometers class type</returns>
        public async Task<EvolutionTonsKilometers> GetEvolutionTonsKilometers(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("evolution-des-tonnes-kilometres", q, lang, rows, start, new string[]{
                "jaar",
                "trimester",
                "sector_fr"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<EvolutionTonsKilometers>(res);
            return result;
        }
        /// <summary>
        /// Get evolution of trains kilometers 
        /// link = "https://opendata.infrabel.be/explore/dataset/evolution-des-trains-kilometres/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> EvolutionTrainsKilometers class type</returns>
        public async Task<EvolutionTrainsKilometers> GetEvolutionTrainsKilometers(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("evolution-des-trains-kilometres", q, lang, rows, start, new string[]{
                "jaar",
                "trimester",
                "sector_fr",
                "effectief_niet_effectief_fr"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<EvolutionTrainsKilometers>(res);
            return result;
        }
        /// <summary>
        /// Evolution of the number of effective train paths 
        /// link = "https://opendata.infrabel.be/explore/dataset/evolution-du-nombre-de-sillons-effectifs/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> EvolutionEffectiveNumberTrainPaths class type</returns>
        public async Task<EvolutionEffectiveNumberTrainPaths> GetEvolutionEffectiveNumberTrainPaths(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("evolution-du-nombre-de-sillons-effectifs", q, lang, rows, start, new string[]{
                "jaar",
                "trimester",
                "categorie_fr"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<EvolutionEffectiveNumberTrainPaths>(res);
            return result;
        }
        /// <summary>
        /// Evolution of net tonnage per year 
        /// link = "https://opendata.infrabel.be/explore/dataset/evolution-du-tonnage-net-par-an/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> EvolutionNetTonnageYear class type</returns>
        public async Task<EvolutionNetTonnageYear> GetEvolutionNetTonnageYear(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("evolution-du-tonnage-net-par-an", q, lang, rows, start, new string[]{
                "jaar",
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<EvolutionNetTonnageYear>(res);
            return result;
        }
    }
}
