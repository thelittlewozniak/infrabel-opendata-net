﻿using Model.TrafficManagementTheme.MobipulseData;
using Model.TrafficManagementTheme.MonthlyDataOnCorrespondence;
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
using Model.TrafficManagementTheme.RawPunctualityData;
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

    }
}
