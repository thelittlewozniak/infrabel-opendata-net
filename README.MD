
# How to use it?
You just need to put this inside you Nuget Package:
```
Install-Package OpenDataInfrabel -Version 0.3.0
```
# How to get data from API?
### For infrastructure theme
```
IInfrastructure infrastructure = new Infrastructure();
var result = await infrastructure.GetKilometersMarkersNetwork();
```
### For security theme
```
ISecurity security = new Security();
var result = await security.GetAccidentsCSI();
```
### For traffic Management theme
```
ITrafficManagement trafficManagement = new TrafficManagement();
var result = await trafficManagement.GetMobipulseData();
```
### For human ressources theme
```
IHumanRessources humanRessources = new HumanRessources();
var result = await humanRessources.GetDistributionStaffByGender();
```
### For Client products theme
```
IClientsProducts clientsProducts = new ClientsProducts();
var result = await clientsProducts.GetEvolutionNetTonnageYear();
```
