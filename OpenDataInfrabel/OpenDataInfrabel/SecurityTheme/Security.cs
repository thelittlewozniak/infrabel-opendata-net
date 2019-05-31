using Model.SecurityTheme.Accidents;
using Model.SecurityTheme.AutomaticProtectionSystem;
using Model.SecurityTheme.PrecursorsSecurity;
using Model.SecurityTheme.ViolationRailway;
using Model.SecurityTheme.ViolationSignal;
using Model.SecurityTheme.ViolationSignalRailwayPrimary;
using Model.SecurityTheme.ViolationSignalRailwayPrimaryPerTrain;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenDataInfrabel.SecurityTheme
{
    /// <summary>
    /// This class handle all call possible for the security them on the open data of Infrabel
    /// </summary>
    public class Security : OpenDataCall, ISecurity
    {
        /// <summary>
        /// Instantiation of the httpClient
        /// </summary>
        public Security():base() { }
        /// <summary>
        /// Get accidents CSI 
        /// link = "https://opendata.infrabel.be/explore/dataset/accidents-csi/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> Accident class type</returns>
        public async Task<Accident> GetAccidentsCSI(string q = null, string lang = "fr", int rows = 10, int start = 0)
        {
            var res = await MakeCall("accidents-csi", q, lang, rows, start, new string[]{
                "column_1",
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<Accident>(res);
            return result;
        }
        /// <summary>
        /// Get Accidents ISI 
        /// link = "https://opendata.infrabel.be/explore/dataset/accidents-isi/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns> Accident class type</returns>
        public async Task<Accident> GetAccidentsISI(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var res = await MakeCall("accidents-isi", q, lang, rows, start, new string[]{
                "column_1",
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<Accident>(res);
            return result;
        }
        /// <summary>
        ///  Get Violation of Signals on secondary Railway 
        ///  link = "https://opendata.infrabel.be/explore/dataset/depassements-de-signaux-en-voie-accessoires/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>ViolationSignalRailwaySecondary class type</returns>
        public async Task<ViolationSignalRailwaySecondary> GetViolationSignalRailwaySecondary(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var res = await MakeCall("depassements-de-signaux-en-voie-accessoires", q, lang, rows, start, new string[]{
                "annee_jaar",
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<ViolationSignalRailwaySecondary>(res);
            return result;
        }
        /// <summary>
        /// Get Violation of Signals on primary Railway 
        /// link = "https://opendata.infrabel.be/explore/dataset/depassements-de-signaux-en-voies-principales/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>ViolationSignalRailwayPrimary class type</returns>
        public async Task<ViolationSignalRailwayPrimary> GetViolationSignalRailwayPrimary(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var res = await MakeCall("depassements-de-signaux-en-voies-principales", q, lang, rows, start, new string[]{
                "column_1",
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<ViolationSignalRailwayPrimary>(res);
            return result;
        }
        /// <summary>
        /// Get Violation of Signals on primary Railway per type of Train 
        /// link = "https://opendata.infrabel.be/explore/dataset/depassements-de-signaux-par-type-de-train-sur-les-voies-principales/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>ViolationSignalRailwayPrimaryPerTrain class type</returns>
        public async Task<ViolationSignalRailwayPrimaryPerTrain> GetViolationSignalRailwayPrimaryPerTrain(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var res = await MakeCall("depassements-de-signaux-par-type-de-train-sur-les-voies-principales", q, lang, rows, start, new string[]{
                "annee_jaar",
                "type_de_train_trein_type_voie_principale"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<ViolationSignalRailwayPrimaryPerTrain>(res);
            return result;
        }
        /// <summary>
        /// Get Violation on Railway 
        /// link = "https://opendata.infrabel.be/explore/dataset/intrusions-sur-les-voies/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>ViolationRailway class type</returns>
        public async Task<ViolationRailway> GetViolationRailway(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var res = await MakeCall("intrusions-sur-les-voies", q, lang, rows, start, new string[]{
                "column_1"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<ViolationRailway>(res);
            return result;
        }
        /// <summary>
        /// Get Precursors security 
        /// link = "https://opendata.infrabel.be/explore/dataset/precurseurs-securite/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>PrecursorsSecurity class type</returns>
        public async Task<PrecursorsSecurity> GetPrecursorsSecurity(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var res = await MakeCall("precurseurs-securite", q, lang, rows, start, new string[]{
                "column_1"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<PrecursorsSecurity>(res);
            return result;
        }
        /// <summary>
        /// Get Automatic Protection System 
        /// link = "https://opendata.infrabel.be/explore/dataset/systemes-de-protection-automatique/information/"
        /// </summary>
        /// <param name="q"> the query in integral text</param>
        /// <param name="lang"> the language wanted (language code in 2 letters)</param>
        /// <param name="rows"> number of results wanted</param>
        /// <param name="start">index of the first result wanted</param>
        /// <returns>AutomaticProtectionSystem class type</returns>
        public async Task<AutomaticProtectionSystem> GetAutomaticProtectionSystem(string q = null, string lang = "FR", int rows = 10, int start = 0)
        {
            var res = await MakeCall("systemes-de-protection-automatique", q, lang, rows, start, new string[]{
                "column_1"
            });
            if (res == null) return null;
            var result = JsonConvert.DeserializeObject<AutomaticProtectionSystem>(res);
            return result;
        }
    }
}
