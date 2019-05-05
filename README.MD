## OpenDataInfrabel ##

# T:OpenDataInfrabel.ClientsProductsTheme.ClientsProducts

 This class handle all call possible for Clients and products theme on the open data of Infrabel



---
##### M:OpenDataInfrabel.ClientsProductsTheme.ClientsProducts.#ctor

 Instantiation of the httpClient



---
##### M:OpenDataInfrabel.ClientsProductsTheme.ClientsProducts.GetEvolutionNetTonnageYear(System.String,System.String,System.Int32,System.Int32)

 Evolution of net tonnage per year link = "https://opendata.infrabel.be/explore/dataset/evolution-du-tonnage-net-par-an/information/"

|Name | Description |
|-----|------|
|q: | the query in integral text|
|Name | Description |
|-----|------|
|lang: | the language wanted (language code in 2 letters)|
|Name | Description |
|-----|------|
|rows: | number of results wanted|
|Name | Description |
|-----|------|
|start: |index of the first result wanted|
Returns:  EvolutionNetTonnageYear class type



---
# T:OpenDataInfrabel.SecurityTheme.Security

 This class handle all call possible for the security them on the open data of Infrabel



---
##### M:OpenDataInfrabel.SecurityTheme.Security.#ctor

 Instantiation of the httpClient



---
##### M:OpenDataInfrabel.SecurityTheme.Security.GetAccidentsCSI(System.String,System.String,System.Int32,System.Int32)

 Get accidents CSI link = "https://opendata.infrabel.be/explore/dataset/accidents-csi/information/"

|Name | Description |
|-----|------|
|q: | the query in integral text|
|Name | Description |
|-----|------|
|lang: | the language wanted (language code in 2 letters)|
|Name | Description |
|-----|------|
|rows: | number of results wanted|
|Name | Description |
|-----|------|
|start: |index of the first result wanted|
Returns:  Accident class type



---
##### M:OpenDataInfrabel.SecurityTheme.Security.GetAccidentsISI(System.String,System.String,System.Int32,System.Int32)

 Get Accidents ISI link = "https://opendata.infrabel.be/explore/dataset/accidents-isi/information/"

|Name | Description |
|-----|------|
|q: | the query in integral text|
|Name | Description |
|-----|------|
|lang: | the language wanted (language code in 2 letters)|
|Name | Description |
|-----|------|
|rows: | number of results wanted|
|Name | Description |
|-----|------|
|start: |index of the first result wanted|
Returns:  Accident class type



---
##### M:OpenDataInfrabel.SecurityTheme.Security.GetViolationSignalRailwaySecondary(System.String,System.String,System.Int32,System.Int32)

 Get Violation of Signals on secondary Railway link = "https://opendata.infrabel.be/explore/dataset/depassements-de-signaux-en-voie-accessoires/information/"

|Name | Description |
|-----|------|
|q: | the query in integral text|
|Name | Description |
|-----|------|
|lang: | the language wanted (language code in 2 letters)|
|Name | Description |
|-----|------|
|rows: | number of results wanted|
|Name | Description |
|-----|------|
|start: |index of the first result wanted|
Returns: ViolationSignalRailwaySecondary class type



---
##### M:OpenDataInfrabel.SecurityTheme.Security.GetViolationSignalRailwayPrimary(System.String,System.String,System.Int32,System.Int32)

 Get Violation of Signals on primary Railway link = "https://opendata.infrabel.be/explore/dataset/depassements-de-signaux-en-voies-principales/information/"

|Name | Description |
|-----|------|
|q: | the query in integral text|
|Name | Description |
|-----|------|
|lang: | the language wanted (language code in 2 letters)|
|Name | Description |
|-----|------|
|rows: | number of results wanted|
|Name | Description |
|-----|------|
|start: |index of the first result wanted|
Returns: ViolationSignalRailwayPrimary class type



---
##### M:OpenDataInfrabel.SecurityTheme.Security.GetViolationSignalRailwayPrimaryPerTrain(System.String,System.String,System.Int32,System.Int32)

 Get Violation of Signals on primary Railway per type of Train link = "https://opendata.infrabel.be/explore/dataset/depassements-de-signaux-par-type-de-train-sur-les-voies-principales/information/"

|Name | Description |
|-----|------|
|q: | the query in integral text|
|Name | Description |
|-----|------|
|lang: | the language wanted (language code in 2 letters)|
|Name | Description |
|-----|------|
|rows: | number of results wanted|
|Name | Description |
|-----|------|
|start: |index of the first result wanted|
Returns: ViolationSignalRailwayPrimaryPerTrain class type



---
##### M:OpenDataInfrabel.SecurityTheme.Security.GetViolationRailway(System.String,System.String,System.Int32,System.Int32)

 Get Violation on Railway link = "https://opendata.infrabel.be/explore/dataset/intrusions-sur-les-voies/information/"

|Name | Description |
|-----|------|
|q: | the query in integral text|
|Name | Description |
|-----|------|
|lang: | the language wanted (language code in 2 letters)|
|Name | Description |
|-----|------|
|rows: | number of results wanted|
|Name | Description |
|-----|------|
|start: |index of the first result wanted|
Returns: ViolationRailway class type



---
##### M:OpenDataInfrabel.SecurityTheme.Security.GetPrecursorsSecurity(System.String,System.String,System.Int32,System.Int32)

 Get Precursors security link = "https://opendata.infrabel.be/explore/dataset/precurseurs-securite/information/"

|Name | Description |
|-----|------|
|q: | the query in integral text|
|Name | Description |
|-----|------|
|lang: | the language wanted (language code in 2 letters)|
|Name | Description |
|-----|------|
|rows: | number of results wanted|
|Name | Description |
|-----|------|
|start: |index of the first result wanted|
Returns: PrecursorsSecurity class type



---
##### M:OpenDataInfrabel.SecurityTheme.Security.GetAutomaticProtectionSystem(System.String,System.String,System.Int32,System.Int32)

 Get Automatic Protection System link = "https://opendata.infrabel.be/explore/dataset/systemes-de-protection-automatique/information/"

|Name | Description |
|-----|------|
|q: | the query in integral text|
|Name | Description |
|-----|------|
|lang: | the language wanted (language code in 2 letters)|
|Name | Description |
|-----|------|
|rows: | number of results wanted|
|Name | Description |
|-----|------|
|start: |index of the first result wanted|
Returns: AutomaticProtectionSystem class type



---
