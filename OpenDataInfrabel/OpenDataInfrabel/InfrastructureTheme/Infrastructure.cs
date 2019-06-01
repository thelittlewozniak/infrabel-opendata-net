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
    public class Infrastructure : OpenDataCall, IInfrastructure
    {
        /// <summary>
        /// Instantiation of the httpClient
        /// </summary>
        public Infrastructure() : base() { }
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
            var res = await MakeCall("association-des-bornes-kilometriques-et-des-voies", q, lang, rows, start, new string[]{
                "track_id",
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<AssociationKilometersMarkersTracks>(res);
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
            var res = await MakeCall("bornes-kilometriques-sur-le-reseau", q, lang, rows, start, new string[] { });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<KilometersMarkersNetwork>(res);
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
            var res = await MakeCall("consommation-en-energie-des-installations-fixes", q, lang, rows, start, new string[] {
            "empty"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<EnergyConsuptionFixedInstallations>(res);
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
            var res = await MakeCall("consommation-mensuelle-de-lenergie-de-traction-avec-repartitions-kopie", q, lang, rows, start, new string[] {
            "column_1"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<MonthlyConsumptionTractionEnergyWDistrib>(res);
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
            var res = await MakeCall("consommation-totale-de-lenergie-de-traction-par-mois", q, lang, rows, start, new string[] {
            "empty"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<MonthlyConsumptionTractionEnergy>(res);
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
            var res = await MakeCall("consommation-totale-de-lenergie-de-traction-par-mois", q, lang, rows, start, new string[] {
            "jaar",
            "openbaar_prive_fr",
            "type_lijn_fr"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<EvolutionNumberLevelCrossings>(res);
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
            var res = await MakeCall("geopn", q, lang, rows, start, new string[] {
            "fld_actief_passief",
            "fld_postcode_en_gemeente"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<GeographicalPositionLevelCrossings>(res);
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
            var res = await MakeCall("geovoies", q, lang, rows, start, new string[] {
            "status",
            "modifdate",
            "trackname",
            "trackcode",
            "trackcode"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<GeographicalPositionMainRoutes>(res);
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
            var res = await MakeCall("points-operationnels-du-reseau", q, lang, rows, start, new string[] {
            "classification",
            "shortnamefrench",
            "commerciallongnamedutch",
            "commercialmiddlenamefrench",
            "longnamefrench",
            "commercialmiddlenamedutch",
            "commercialshortnamefrench",
            "commerciallongnamefrench",
            "shortnamedutch",
            "commercialshortnamedutch",
            "longnamedutch"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<NetworkOperationalPoints>(res);
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
            var res = await MakeCall("segmentatie-volgens-de-eigenschappen-van-de-infrastructuur-en-de-exploitatiemoge", q, lang, rows, start, new string[] {
            "gauge_nat",
            "label",
            "linecat_f",
            "linecat_p",
            "ecs_voltfreq",
            "gauge"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<LineSections>(res);
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
            var res = await MakeCall("suppressions-de-passages-a-niveau", q, lang, rows, start, new string[] {
            "jaar",
            "openbaar_prive_fr"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<LevelCrossingDeletions>(res);
            return result;
        }
    }
}
