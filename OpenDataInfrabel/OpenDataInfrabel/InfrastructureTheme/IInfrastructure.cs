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
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataInfrabel.InfrastructureTheme
{
    public interface IInfrastructure
    {
        Task<AssociationKilometersMarkersTracks> GetAssociationKilometersMarkersTracks(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<KilometersMarkersNetwork> GetKilometersMarkersNetwork(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<EnergyConsuptionFixedInstallations> GetEnergyConsuptionFixedInstallations(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<MonthlyConsumptionTractionEnergyWDistrib> GetMonthlyConsumptionTractionEnergyWDistrib(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<MonthlyConsumptionTractionEnergy> GetMonthlyConsumptionTractionEnergy(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<EvolutionNumberLevelCrossings> GetEvolutionNumberLevelCrossings(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<GeographicalPositionLevelCrossings> GetGeographicalPositionLevelCrossings(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<GeographicalPositionMainRoutes> GetGeographicalPositionMainRoutes(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<NetworkOperationalPoints> GetNetworkOperationalPoints(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<LineSections> GetLineSections(string q = null, string lang = "fr", int rows = 10, int start = 0);
        Task<LevelCrossingDeletions> GetLevelCrossingDeletions(string q = null, string lang = "fr", int rows = 10, int start = 0);
    }
}
