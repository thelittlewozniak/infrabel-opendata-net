
# How to use it?
You just need to reference it in your project using this command line :
```
Install-Package OpenDataInfrabel -Version 0.3.0
```
# How to get data from API?
### Infrastructure Theme
```
IInfrastructure infrastructure = new Infrastructure();
var result = await infrastructure.GetKilometersMarkersNetwork();
```
### Security Theme
```
ISecurity security = new Security();
var result = await security.GetAccidentsCSI();
```
### Traffic Management Theme
```
ITrafficManagement trafficManagement = new TrafficManagement();
var result = await trafficManagement.GetMobipulseData();
```
### Human Ressources Theme
```
IHumanRessources humanRessources = new HumanRessources();
var result = await humanRessources.GetDistributionStaffByGender();
```
### Client Products Theme
```
IClientsProducts clientsProducts = new ClientsProducts();
var result = await clientsProducts.GetEvolutionNetTonnageYear();
```
