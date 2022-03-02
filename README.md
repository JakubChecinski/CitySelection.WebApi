# CitySelection.WebApi
A small ASP.NET Core WebApi project to help you choose between different European cities

A small WebApi with only one GET method, accessible via [url]/api/city

The input JSON contains preference and importance codes for different aspects of life in a given EU city. Importance codes are as following: Irrelevant = 0, NiceToHave = 1, Important = 2, Mandatory = 3. Preference codes are as following: N/A = 0, Low = 1, Medium = 2, High = 3. Other codes will result in throwing an exception. 
Remarks: If the importance code is set to irrelevant, the preference code will be ignored. For the sake of clarity, it is recommended to use N/A (zero). If the importance code is set to mandatory, only cities that exactly match this preference will be considered. Aspects of life to include in the input are: GdpPerCapita, InequalityIndex (Gini), RainyDays in a year, MonthlySunshineHours, Temperature24hAvgHigh (how hot is the average day of the hottest month is this city), Temperature24hAvgLow (how cold is the average day of the coldest month is this city), AnnualPM2_5Concentration (PM 2.5 air pollution), CostOfLivingIndex (Numbeo).

Example input:
{
  "GdpPerCapitaImportance" : 2,
  "GdpPerCapitaPreference" : 2,
  "InequalityIndexImportance" : 1,
  "InequalityIndexPreference" : 1,
  "RainyDaysImportance" : 0,
  "RainyDaysPreference" : 0,
  "MonthlySunshineHoursImportance" : 1,
  "MonthlySunshineHoursPreference" : 3,
  "Temperature24hAvgHighImportance" : 1,
  "Temperature24hAvgHighPreference" : 1,
  "Temperature24hAvgLowImportance" : 2,
  "Temperature24hAvgLowPreference" : 1,
  "AnnualPM2_5ConcentrationImportance" : 3,
  "AnnualPM2_5ConcentrationPreference" : 1,
  "CostOfLivingIndexImportance" : 2,
  "CostOfLivingIndexPreference" : 1
}

The output JSON contains data about the most compatible EU city found (if any). Currently, the api contains only 8 example cities (Warsaw, Munich, Amsterdam, Dublin, Copenhagen, Lyon, Milan, Bucharest) for demonstrative purposes.

Example output:
{
  "data": {
    "name": "München",
    "englishName": "Munich",
    "country": "Germany",
    "population": 2606,
    "wikipediaUrl": "https://en.wikipedia.org/wiki/Munich"
    },
    "errors": [],
    "isSuccess": true
}
