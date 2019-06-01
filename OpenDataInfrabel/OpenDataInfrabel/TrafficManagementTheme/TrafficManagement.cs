using Model.TrafficManagementTheme.MobipulseData;
using Model.TrafficManagementTheme.MonthlyDataOnCorrespondence;
using Model.TrafficManagementTheme.NationalPunctualityMomentMonth;
using Model.TrafficManagementTheme.NationalPunctualityMonth;
using Model.TrafficManagementTheme.NationalPunctualityWithTrainsRemoved;
using Model.TrafficManagementTheme.NationalWeightedPunctualityMonth;
using Model.TrafficManagementTheme.PunctualityArrivalBrussels;
using Model.TrafficManagementTheme.PunctualityArrivalBrusselsMoment;
using Model.TrafficManagementTheme.PunctualityArrivalBrusselsMomentMainLine;
using Model.TrafficManagementTheme.PunctualityEurostar;
using Model.TrafficManagementTheme.PunctualityFreightTrains;
using Model.TrafficManagementTheme.PunctualityICE;
using Model.TrafficManagementTheme.PunctualityICRelations;
using Model.TrafficManagementTheme.PunctualityICRelationsMoment;
using Model.TrafficManagementTheme.PunctualityMajorStationsMonth;
using Model.TrafficManagementTheme.PunctualityTGV;
using Model.TrafficManagementTheme.PunctualityThalys;
using Model.TrafficManagementTheme.PunctualityTypeTrain;
using Model.TrafficManagementTheme.PunctualityTypeTrainMoment;
using Model.TrafficManagementTheme.RawPunctualityData;
using Model.TrafficManagementTheme.ResponsibilityDelaysMonth;
using Model.TrafficManagementTheme.ResponsibilityTrainDeletions;
using Model.TrafficManagementTheme.SignalingStations;
using Model.TrafficManagementTheme.TrainsDeletedMonth;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace OpenDataInfrabel.TrafficManagementTheme
{
    /// <summary>
    /// This class handle all call possible for Traffic Management theme on the open data of Infrabel
    /// </summary>
    public class TrafficManagement : OpenDataCall, ITrafficManagement
    {
        /// <summary>
        /// Instantiation of the httpClient
        /// </summary>
        public TrafficManagement() : base() { }
        /// <summary>
        /// Raw data of arrival and departure of passenger trains (national and international) at their stops, on a day, by number of trains.
        /// link = "https://opendata.infrabel.be/explore/dataset/data_raw_punctuality_xlsx/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> RawPunctualityData class type</returns>
        public async Task<RawPunctualityData> GetRawPunctualityData(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("data_raw_punctuality_xlsx", q, lang, rows, start, new string[]{
                "train_no",
                "relation",
                "train_serv",
                "line_no_dep",
                "relation_direction",
                "ptcar_lg_nm_nl",
                "line_no_arr"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<RawPunctualityData>(res);
            return result;
        }
        /// <summary>
        /// Monthly data on connections to the 10 largest stations
        /// link = "https://opendata.infrabel.be/explore/dataset/donnees-mensuelles-sur-les-correspondances/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> MonthlyDataOnCorrespondence class type</returns>
        public async Task<MonthlyDataOnCorrespondence> GetMonthlyDataOnCorrespondence(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("donnees-mensuelles-sur-les-correspondances", q, lang, rows, start, new string[]{
                "maand",
                "naam"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<MonthlyDataOnCorrespondence>(res);
            return result;
        }
        /// <summary>
        /// Mobipulse gives the average journey time to Brussels-Centrale from the 10 most important stations of Belgium
        /// during the morning rush hour and the reverse journey during the evening rush hour
        /// link = "https://opendata.infrabel.be/explore/dataset/donnees-mobipulse/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> MobipulseData class type</returns>
        public async Task<MobipulseData> GetMobipulseData(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("donnees-mobipulse", q, lang, rows, start, new string[]{
                "dat_dep",
                "van",
                "naar",
                "regperiode_arr"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<MobipulseData>(res);
            return result;
        }
        /// <summary>
        /// Monthly arrival of the trains on arrival in the first station of the North-Midi junction in Brussels
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-a-larrivee-a-bruxelles/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityArrivalBrussels class type</returns>
        public async Task<PunctualityArrivalBrussels> GetPunctualityArrivalBrussels(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-a-larrivee-a-bruxelles", q, lang, rows, start, new string[]{
                "maand",
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityArrivalBrussels>(res);
            return result;
        }
        /// <summary>
        /// Monthly arrival of the trains arriving at the first station of the Nord-Midi junction in Brussels by moment
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-a-larrivee-a-bruxelles-par-moment/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityArrivalBrusselsMoment class type</returns>
        public async Task<PunctualityArrivalBrusselsMoment> GetPunctualityArrivalBrusselsMoment(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-a-larrivee-a-bruxelles-par-moment", q, lang, rows, start, new string[]{
                "maand",
                "regperiode"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityArrivalBrusselsMoment>(res);
            return result;
        }
        /// <summary>
        /// Monthly punctuality of the trains arriving at the first station of the North-Midi junction in Brussels by moment and by main line.
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-a-larrivee-a-bruxelles-par-moment-et-grande-ligne/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityArrivalBrusselsMomentMainLine class type</returns>
        public async Task<PunctualityArrivalBrusselsMomentMainLine> GetPunctualityArrivalBrusselsMomentMainLine(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-a-larrivee-a-bruxelles-par-moment-et-grande-ligne", q, lang, rows, start, new string[]{
                "maand",
                "lijn",
                "regperiode"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityArrivalBrusselsMomentMainLine>(res);
            return result;
        }
        /// <summary>
        /// Monthly punctuality of the trains arriving at the first station of the North-Midi junction in Brussels by moment and by main line.
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-a-larrivee-a-bruxelles-par-moment-et-grande-ligne/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityMajorStationsMonth class type</returns>
        public async Task<PunctualityMajorStationsMonth> GetPunctualityMajorStationsMonth(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-dans-les-grandes-gares-par-mois", q, lang, rows, start, new string[]{
                "maand",
                "station",
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityMajorStationsMonth>(res);
            return result;
        }
        /// <summary>
        /// Monthly Punctuality of the IC relations on arrival at their final destination and on arrival at the first Brussels station at the junction.
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-des-relations-ic/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityICRelations class type</returns>
        public async Task<PunctualityICRelations> GetPunctualityICRelations(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-des-relations-ic", q, lang, rows, start, new string[]{
                "maand",
                "relatie",
                "op_stat"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityICRelations>(res);
            return result;
        }
        /// <summary>
        /// Monthly Punctuality of the IC relations on arrival at their final destination and on arrival at the first Brussels station at the junction by moment.
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-des-relations-ic-par-moment/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityICRelationsMoment class type</returns>
        public async Task<PunctualityICRelationsMoment> GetPunctualityICRelationsMoment(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-des-relations-ic-par-moment", q, lang, rows, start, new string[]{
                "maand",
                "relatie",
                "op_stat"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityICRelationsMoment>(res);
            return result;
        }
        /// <summary>
        /// Monthly performance of TGV trains on the Infrabel network.
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-des-tgv/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityTGV class type</returns>
        public async Task<PunctualityTGV> GetPunctualityTGV(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-des-tgv", q, lang, rows, start, new string[]{
                "maand1"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityTGV>(res);
            return result;
        }
        /// <summary>
        /// Monthly punctuality of freight trains on the Infrabel network
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-des-trains-de-marchandises/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityFreightTrains class type</returns>
        public async Task<PunctualityFreightTrains> GetPunctualityFreightTrains(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-des-trains-de-marchandises", q, lang, rows, start, new string[]{
                "maand2"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityFreightTrains>(res);
            return result;
        }
        /// <summary>
        /// Monthly punctuality of Eurostar trains as they pass through the Infrabel network
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-des-trains-eurostar/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityEurostar class type</returns>
        public async Task<PunctualityEurostar> GetPunctualityEurostar(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-des-trains-eurostar", q, lang, rows, start, new string[]{
                "maand1"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityEurostar>(res);
            return result;
        }
        /// <summary>
        /// Monthly performance of ICE trains
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-des-trains-ice/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityICE class type</returns>
        public async Task<PunctualityICE> GetPunctualityICE(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-des-trains-ice", q, lang, rows, start, new string[]{
                "maand1"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityICE>(res);
            return result;
        }
        /// <summary>
        /// Monthly performance of Thalys trains
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-des-trains-thalys/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityThalys class type</returns>
        public async Task<PunctualityThalys> GetPunctualityThalys(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-des-trains-thalys", q, lang, rows, start, new string[]{
                "maand1"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityThalys>(res);
            return result;
        }
        /// <summary>
        /// National Punctuality by month
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-nationale-par-mois/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> NationalPunctualityMonth class type</returns>
        public async Task<NationalPunctualityMonth> GetNationalPunctualityMonth(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-nationale-par-mois", q, lang, rows, start, new string[]{
                "maand"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<NationalPunctualityMonth>(res);
            return result;
        }
        /// <summary>
        /// National Punctuality by moment by month
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-nationale-par-mois/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> NationalPunctualityMomentMonth class type</returns>
        public async Task<NationalPunctualityMomentMonth> GetNationalPunctualityMomentMonth(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-nationale-par-moment-par-mois", q, lang, rows, start, new string[]{
                "maand",
                "regperiode"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<NationalPunctualityMomentMonth>(res);
            return result;
        }
        /// <summary>
        /// National Weighted Punctuality by Month
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-nationale-ponderee-par-mois/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> NationalWeightedPunctualityMonth class type</returns>
        public async Task<NationalWeightedPunctualityMonth> GetNationalWeightedPunctualityMonth(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-nationale-ponderee-par-mois", q, lang, rows, start, new string[]{
                "maand2"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<NationalWeightedPunctualityMonth>(res);
            return result;
        }
        /// <summary>
        /// National punctuality taking into account the trains removed
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-nationale-tenant-compte-des-trains-supprimes/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> NationalWeightedPunctualityMonth class type</returns>
        public async Task<NationalPunctualityWithTrainsRemoved> GetNationalPunctualityWithTrainsRemoved(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-nationale-tenant-compte-des-trains-supprimes", q, lang, rows, start, new string[]{
                "maand2"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<NationalPunctualityWithTrainsRemoved>(res);
            return result;
        }
        /// <summary>
        /// Punctuality by type of train
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-par-type-de-train/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityTypeTrain class type</returns>
        public async Task<PunctualityTypeTrain> GetPunctualityTypeTrain(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-par-type-de-train", q, lang, rows, start, new string[]{
                "maand",
                "rel"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityTypeTrain>(res);
            return result;
        }
        /// <summary>
        /// Punctuality by type of train and by moment
        /// link = "https://opendata.infrabel.be/explore/dataset/ponctualite-par-type-de-train-et-par-moment/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> PunctualityTypeTrainMoment class type</returns>
        public async Task<PunctualityTypeTrainMoment> GetPunctualityTypeTrainMoment(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("ponctualite-par-type-de-train-et-par-moment", q, lang, rows, start, new string[]{
                "maand",
                "rel",
                "regperiode"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PunctualityTypeTrainMoment>(res);
            return result;
        }
        /// <summary>
        /// Signaling stations
        /// link = "https://opendata.infrabel.be/explore/dataset/postes-de-signalisation0/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> SignalingStations class type</returns>
        public async Task<SignalingStations> GetSignalingStations(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("postes-de-signalisation0", q, lang, rows, start, new string[]{
                "jaar",
                "area_fr"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<SignalingStations>(res);
            return result;
        }
        /// <summary>
        /// Responsibility for delays per month
        /// link = "https://opendata.infrabel.be/explore/dataset/responsabilite-des-retards-par-mois0/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> ResponsibilityDelaysMonth class type</returns>
        public async Task<ResponsibilityDelaysMonth> GetResponsibilityDelaysMonth(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("responsabilite-des-retards-par-mois0", q, lang, rows, start, new string[]{
                "jaar",
                "operator",
                "maand2"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<ResponsibilityDelaysMonth>(res);
            return result;
        }
        /// <summary>
        /// Responsibility for train deletions
        /// link = "https://opendata.infrabel.be/explore/dataset/responsabilite-des-suppressions-de-trains/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> ResponsibilityTrainDeletions class type</returns>
        public async Task<ResponsibilityTrainDeletions> GetResponsibilityTrainDeletions(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("responsabilite-des-suppressions-de-trains", q, lang, rows, start, new string[]{
                "jaar",
                "maanddossierniveau",
                "dashboardname1"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<ResponsibilityTrainDeletions>(res);
            return result;
        }
        /// <summary>
        /// Trains deleted per month
        /// link = "https://opendata.infrabel.be/explore/dataset/trains-supprimes-par-mois/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> TrainsDeletedMonth class type</returns>
        public async Task<TrainsDeletedMonth> GetTrainsDeletedMonth(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("trains-supprimes-par-mois", q, lang, rows, start, new string[]{
                "maand"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<TrainsDeletedMonth>(res);
            return result;
        }
    }
}
