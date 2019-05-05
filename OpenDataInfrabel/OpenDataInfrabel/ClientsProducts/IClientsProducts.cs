using Model.ClientsProducts.EvolutionEffectiveNumberTrainPaths;
using Model.ClientsProducts.EvolutionNetTonnageYear;
using Model.ClientsProducts.EvolutionTonsKilometers;
using Model.ClientsProducts.EvolutionTrainsKilometers;
using System.Threading.Tasks;

namespace OpenDataInfrabel.ClientsProducts
{
    interface IClientsProducts
    {
        Task<EvolutionTonsKilometers> GetEvolutionTonsKilometers(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<EvolutionTrainsKilometers> GetEvolutionTrainsKilometers(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<EvolutionEffectiveNumberTrainPaths> GetEvolutionEffectiveNumberTrainPaths(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<EvolutionNetTonnageYear> GetEvolutionNetTonnageYear(string q = null, string lang = "fr", int rows = 10, int start = 0);
    }
}
