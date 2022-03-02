# CitySelection.WebApi
A small ASP.NET Core WebApi project to help you choose between different European cities

The Api contains only one GET method, accessible via [url]/api/city<br />
<br />
The input JSON contains preference and importance codes for different aspects of life in a given EU city. Importance codes are as following: Irrelevant = 0, NiceToHave = 1, Important = 2, Mandatory = 3. Preference codes are as following: N/A = 0, Low = 1, Medium = 2, High = 3. Other codes will result in throwing an exception. <br />
Remarks: If the importance code is set to irrelevant, the preference code will be ignored. For the sake of clarity, it is recommended to use N/A (zero). If the importance code is set to mandatory, only cities that exactly match this preference will be considered. Aspects of life to include in the input are: GdpPerCapita, InequalityIndex (Gini), RainyDays in a year, MonthlySunshineHours, Temperature24hAvgHigh (how hot is the average day of the hottest month in this city), Temperature24hAvgLow (how cold is the average day of the coldest month in this city), AnnualPM2_5Concentration (PM 2.5 air pollution), CostOfLivingIndex (Numbeo).<br />
<br />
Example input:<br />
{<br />
&nbsp;&nbsp;"GdpPerCapitaImportance" : 2,<br />
&nbsp;&nbsp;"GdpPerCapitaPreference" : 2,<br />
&nbsp;&nbsp;"InequalityIndexImportance" : 1,<br />
&nbsp;&nbsp;"InequalityIndexPreference" : 1,<br />
&nbsp;&nbsp;"RainyDaysImportance" : 0,<br />
&nbsp;&nbsp;"RainyDaysPreference" : 0,<br />
&nbsp;&nbsp;"MonthlySunshineHoursImportance" : 1,<br />
&nbsp;&nbsp;"MonthlySunshineHoursPreference" : 3,<br />
&nbsp;&nbsp;"Temperature24hAvgHighImportance" : 1,<br />
&nbsp;&nbsp;"Temperature24hAvgHighPreference" : 1,<br />
&nbsp;&nbsp;"Temperature24hAvgLowImportance" : 2,<br />
&nbsp;&nbsp;"Temperature24hAvgLowPreference" : 1,<br />
&nbsp;&nbsp;"AnnualPM2_5ConcentrationImportance" : 3,<br />
&nbsp;&nbsp;"AnnualPM2_5ConcentrationPreference" : 1,<br />
&nbsp;&nbsp;"CostOfLivingIndexImportance" : 2,<br />
&nbsp;&nbsp;"CostOfLivingIndexPreference" : 1<br />
}<br />
<br />
The output JSON contains data about the most compatible EU city found (if any). Currently, the api contains only 8 example cities (Warsaw, Munich, Amsterdam, Dublin, Copenhagen, Lyon, Milan, Bucharest) for demonstrative purposes.<br />
<br />
Example output:<br />
{<br />
&nbsp;&nbsp;"data": {<br />
&nbsp;&nbsp;&nbsp;&nbsp;"name": "München",<br />
&nbsp;&nbsp;&nbsp;&nbsp;"englishName": "Munich",<br />
&nbsp;&nbsp;&nbsp;&nbsp;"country": "Germany",<br />
&nbsp;&nbsp;&nbsp;&nbsp;"population": 2606,<br />
&nbsp;&nbsp;&nbsp;&nbsp;"wikipediaUrl": "https://en.wikipedia.org/wiki/Munich"<br />
&nbsp;&nbsp;},<br />
&nbsp;&nbsp;"errors": [],<br />
&nbsp;&nbsp;"isSuccess": true<br />
}<br />

