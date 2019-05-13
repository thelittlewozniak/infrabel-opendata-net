using Model.InfrastructureTheme.AssociationKilometersMarkersTracks;
using Model.InfrastructureTheme.EnergyConsumptionFixedInstallations;
using Model.InfrastructureTheme.EvolutionNumberLevelCrossings;
using Model.InfrastructureTheme.GeographicalPositionLevelCrossings;
using Model.InfrastructureTheme.GeographicalPositionMainRoutes;
using Model.InfrastructureTheme.KilometersMarkersNetwork;
using Model.InfrastructureTheme.LevelCrossingDeletions;
using Model.InfrastructureTheme.LineSections;
using Model.InfrastructureTheme.MonthlyConsumptionTractionEnergy;
using Model.InfrastructureTheme.MonthlyConsumptionTractionEnergyWDistrib;
using Model.InfrastructureTheme.NetworkOperationalPoints;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenDataInfrabel.InfrastructureTheme
{
    /// <summary>
    /// This class handle all call possible for Infrastucture theme on the open data of Infrabel
    /// </summary>
    public class Infrastructure : IDisposable, IInfrastructure
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
        /// <summary>
        /// Energy consumption of fixed installations
        /// link = "https://opendata.infrabel.be/explore/dataset/consommation-en-energie-des-installations-fixes/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>EnergyConsuptionFixedInstallations class type</returns>
        public async Task<EnergyConsuptionFixedInstallations> GetEnergyConsuptionFixedInstallations(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=consommation-en-energie-des-installations-fixes&facet=empty"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<EnergyConsuptionFixedInstallations>(requestString);
            return result;
        }
        /// <summary>
        /// Monthly consumption of traction energy (with distribution)
        /// link = "https://opendata.infrabel.be/explore/dataset/consommation-mensuelle-de-lenergie-de-traction-avec-repartitions-kopie/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>MonthlyConsumptionTractionEnergyWDistrib class type</returns>
        public async Task<MonthlyConsumptionTractionEnergyWDistrib> GetMonthlyConsumptionTractionEnergyWDistrib(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=consommation-mensuelle-de-lenergie-de-traction-avec-repartitions-kopie&facet=column_1"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<MonthlyConsumptionTractionEnergyWDistrib>(requestString);
            return result;
        }
        /// <summary>
        /// Monthly consumption of traction energy
        /// link = "https://opendata.infrabel.be/explore/dataset/consommation-totale-de-lenergie-de-traction-par-mois/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>MonthlyConsumptionTractionEnergy class type</returns>
        public async Task<MonthlyConsumptionTractionEnergy> GetMonthlyConsumptionTractionEnergy(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=consommation-totale-de-lenergie-de-traction-par-mois&facet=empty"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<MonthlyConsumptionTractionEnergy>(requestString);
            return result;
        }
        /// <summary>
        /// Evolution of the number of level crossings
        /// link = "https://opendata.infrabel.be/explore/dataset/evolution-du-nombre-de-passages-a-niveau/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>EvolutionNumberLevelCrossings class type</returns>
        public async Task<EvolutionNumberLevelCrossings> GetEvolutionNumberLevelCrossings(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=evolution-du-nombre-de-passages-a-niveau&facet=jaar&facet=openbaar_prive_fr&facet=type_lijn_fr"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<EvolutionNumberLevelCrossings>(requestString);
            return result;
        }
        /// <summary>
        /// List and geographical position of level crossings
        /// link = "https://opendata.infrabel.be/explore/dataset/geopn/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>GeographicalPositionLevelCrossings class type</returns>
        public async Task<GeographicalPositionLevelCrossings> GetGeographicalPositionLevelCrossings(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=geopn&facet=fld_actief_passief&facet=fld_postcode_en_gemeente"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<GeographicalPositionLevelCrossings>(requestString);
            return result;
        }
        /// <summary>
        /// List and geographical position of the main routes
        /// link = "https://opendata.infrabel.be/explore/dataset/geovoies/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>GeographicalPositionMainRoutes class type</returns>
        public async Task<GeographicalPositionMainRoutes> GetGeographicalPositionMainRoutes(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=geovoies&facet=status&facet=modifdate&facet=trackname&facet=trackcode&facet=trackcode"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<GeographicalPositionMainRoutes>(requestString);
            return result;
        }
        /// <summary>
        /// Network operational points
        /// link = "https://opendata.infrabel.be/explore/dataset/points-operationnels-du-reseau/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>NetworkOperationalPoints class type</returns>
        public async Task<NetworkOperationalPoints> GetNetworkOperationalPoints(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=points-operationnels-du-reseau&facet=classification&facet=shortnamefrench&facet=commerciallongnamedutch" +
                "&facet=commercialmiddlenamefrench&facet=longnamefrench&facet=commercialmiddlenamedutch&facet=commercialshortnamefrench&" +
                "facet=commerciallongnamefrench&facet=shortnamedutch&facet=commercialshortnamedutch&facet=longnamedutch"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<NetworkOperationalPoints>(requestString);
            return result;
        }
        /// <summary>
        /// Line Sections
        /// link = "https://opendata.infrabel.be/explore/dataset/segmentatie-volgens-de-eigenschappen-van-de-infrastructuur-en-de-exploitatiemoge/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>LineSections class type</returns>
        public async Task<LineSections> GetLineSections(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=segmentatie-volgens-de-eigenschappen-van-de-infrastructuur-en-de-exploitatiemoge&facet=gauge_nat&facet=label&facet=linecat_f" +
                "&facet=linecat_p&facet=ecs_voltfreq&facet=gauge"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<LineSections>(requestString);
            return result;
        }
        /// <summary>
        /// Level crossing deletions
        /// link = "https://opendata.infrabel.be/explore/dataset/suppressions-de-passages-a-niveau/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>LevelCrossingDeletions class type</returns>
        public async Task<LevelCrossingDeletions> GetLevelCrossingDeletions(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var finalUrl = url + "dataset=suppressions-de-passages-a-niveau&facet=jaar&facet=openbaar_prive_fr"
                + (q == null ? "" : "&q=" + q)
                + "&lang=" + lang
                + "&rows=" + rows
                + "&start=" + start;
            var request = await httpClient.GetAsync(finalUrl);
            if (request.StatusCode != System.Net.HttpStatusCode.OK)
                return null;
            var requestString = await request.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<LevelCrossingDeletions>(requestString);
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
