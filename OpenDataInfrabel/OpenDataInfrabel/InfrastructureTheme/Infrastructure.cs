using Model.InfrastructureTheme.AssociationKilometersMarkersTracks;
using Model.InfrastructureTheme.KilometersMarkersNetwork;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataInfrabel.InfrastructureTheme
{
    class Infrastructure
    {
        private readonly HttpClient httpClient;
        private bool disposed = false;
        private static readonly string url = "https://opendata.infrabel.be/api/records/1.0/search/?";
        /// <summary>
        /// Instantiation of the httpClient
        /// </summary>
        public Infrastructure() => httpClient = new HttpClient();
        /// <summary>
        /// This dataset associates the identifiers of the milestones with the line number of the main tracks.
        /// link = "https://opendata.infrabel.be/explore/dataset/association-des-bornes-kilometriques-et-des-voies/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> AssociationKilometersMarkersTracks class type</returns>
        public async Task<AssociationKilometersMarkersTracks> GetAssociationKilometersMarkersTracks(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=association-des-bornes-kilometriques-et-des-voies&facet=track_id"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AssociationKilometersMarkersTracks>(requestString);
            return result;
        }
        /// <summary>
        /// Geographical position of the kilometer markers along the tracks,
        /// taking the identifier and the name of the marker as they can be read on the ground.
        /// link = "https://opendata.infrabel.be/explore/dataset/bornes-kilometriques-sur-le-reseau/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>KilometersMarkersNetwork class type</returns>
        public async Task<KilometersMarkersNetwork> GetKilometersMarkersNetwork(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=bornes-kilometriques-sur-le-reseau"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<KilometersMarkersNetwork>(requestString);
            return result;
        }
    }
}
