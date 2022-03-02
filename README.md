# CitySelection.WebApi
A small ASP.NET Core WebApi project to help you choose between different European cities

A small WebApi with only one GET method, accessible via [url]/api/city<br />
<br />
The input JSON contains preference and importance codes for different aspects of life in a given EU city. Importance codes are as following: Irrelevant = 0, NiceToHave = 1, Important = 2, Mandatory = 3. Preference codes are as following: N/A = 0, Low = 1, Medium = 2, High = 3. Other codes will result in throwing an exception. <br />
Remarks: If the importance code is set to irrelevant, the preference code will be ignored. For the sake of clarity, it is recommended to use N/A (zero). If the importance code is set to mandatory, only cities that exactly match this preference will be considered. Aspects of life to include in the input are: GdpPerCapita, InequalityIndex (Gini), RainyDays in a year, MonthlySunshineHours, Temperature24hAvgHigh (how hot is the average day of the hottest month is this city), Temperature24hAvgLow (how cold is the average day of the coldest month is this city), AnnualPM2_5Concentration (PM 2.5 air pollution), CostOfLivingIndex (Numbeo).<br />
<br />
Example input:<br />
{<br />
  "GdpPerCapitaImportance" : 2,<br />
  "GdpPerCapitaPreference" : 2,<br />
  "InequalityIndexImportance" : 1,<br />
  "InequalityIndexPreference" : 1,<br />
  "RainyDaysImportance" : 0,<br />
  "RainyDaysPreference" : 0,<br />
  "MonthlySunshineHoursImportance" : 1,<br />
  "MonthlySunshineHoursPreference" : 3,<br />
  "Temperature24hAvgHighImportance" : 1,<br />
  "Temperature24hAvgHighPreference" : 1,<br />
  "Temperature24hAvgLowImportance" : 2,<br />
  "Temperature24hAvgLowPreference" : 1,<br />
  "AnnualPM2_5ConcentrationImportance" : 3,<br />
  "AnnualPM2_5ConcentrationPreference" : 1,<br />
  "CostOfLivingIndexImportance" : 2,<br />
  "CostOfLivingIndexPreference" : 1<br />
}<br />
<br />
The output JSON contains data about the most compatible EU city found (if any). Currently, the api contains only 8 example cities (Warsaw, Munich, Amsterdam, Dublin, Copenhagen, Lyon, Milan, Bucharest) for demonstrative purposes.<br />
<br />
Example output:<br />
{<br />
  "data": {<br />
    "name": "München",<br />
    "englishName": "Munich",<br />
    "country": "Germany",<br />
    "population": 2606,<br />
    "wikipediaUrl": "https://en.wikipedia.org/wiki/Munich"<br />
    },<br />
    "errors": [],<br />
    "isSuccess": true<br />
}<br />

