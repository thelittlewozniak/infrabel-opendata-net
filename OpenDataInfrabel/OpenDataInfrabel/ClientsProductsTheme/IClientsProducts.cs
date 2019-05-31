using Model.ClientsProductsTheme.EvolutionEffectiveNumberTrainPaths;
using Model.ClientsProductsTheme.EvolutionNetTonnageYear;
using Model.ClientsProductsTheme.EvolutionTonsKilometers;
using Model.ClientsProductsTheme.EvolutionTrainsKilometers;
using System;
using System.Threading.Tasks;

namespace OpenDataInfrabel.ClientsProductsTheme
{
    interface IClientsProducts:IDisposable
    {
        Task<EvolutionTonsKilometers> GetEvolutionTonsKilometers(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<EvolutionTrainsKilometers> GetEvolutionTrainsKilometers(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<EvolutionEffectiveNumberTrainPaths> GetEvolutionEffectiveNumberTrainPaths(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<EvolutionNetTonnageYear> GetEvolutionNetTonnageYear(string q = null, string lang = "fr", int rows = 10, int start = 0);
    }
}
