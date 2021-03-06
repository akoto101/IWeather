C# Weather Implementation - Alexander Saga


WeatherCurrent class load the current weather for the day. It contains three different constructor that depends on 

the way of weather searching.

Constructor 1 - By City name

	WeatherCurrent weather = new WeatherCurrent(ApiKey,CityName);

contains two parameters , ApiKey as String and CityName as String;

constructor 2 - By City Zip Code

	WeatherCurrent weather = new WeatherCurrent(ApiKey,Zip);

contains two parameters , ApiKey as String and Zip as integer;

constructor 3 - By Latitude and Longhitude

	WeatherCurrent weather = new WeatherCurrent(ApiKey,Latitude,Longhitude);

contains two parameters , ApiKey as String, Latitude and Longhitude as double;

Get Current Weather Information

	City as String
	Country as String

	Current_Country as String * Get Current Country
	Current_City as String * Get current City
	current_CountryLat as float * Get Current Latitude
	current_CountryLong as float * Get Current Longhitude
	Current_Region as String * Get Current Region
	Current_TimeZone as String * Get Current TimeZon


	Temperature_Min as int * Minimum Temperature
	Temperature_Max as int * Maximum Temparature
	Temerature_Value as int * Current Temperature value


	Wind_Value as double * Current Wind Speed
	Wind_Direction_Name as String * Wind Name (e.g North,South,East,West)
	Wind_Direction_Code as String * Wind Direction Code (e.g N,S,E,W)
	Wind_Name as String * Wind Name (e.g Breeze)
	Wind_Direction_Value as String * Wind degree


	Humidity as int * Humidity Value


	Weather as String * Get Current Weather
	Weather_Icon as String * Get Weather icon


	Visibility as int * Get Area Visibility


	Cloud_Value as int * Cloud Percentage in the certain Area
	Cloud_Name as String * Get the Cloud Name (e.g Scattered Clouds)


	Pressure as int * Get Pressure Value
	Pressure_Unit as String * Get Pressure Unit


	Last_Update as String * Get Weather last Update


WeatherForecast class load the weather in specific Day Range. 

Implementation
   
    Constructors
	
	WeatherForecast forecast = new WeatherForecast(API_KEY,CITY_NAME,DAY_RETURN);
	

	WeatherForecast forecast = new WeatherForecast(API_KEY, String CITY_NAME,WeatherUnits,Day_Return)


Get Current Weather Forecast Information

// All of the Item is Self Explanatory

XmlUnits as String  - Get or Set XmlUnits (Metric = Celsius , Imperial = Fahrenheit, Default = Kelvin)

	Time_Current - Get Current Time;

	Time_Forecast_From = Get Forecast Starts Day 0,Returns String Array;
	Time_ForecastTo  = Get Forecast Starts Day 0,Returns String Array;

	Weather_Id = Get Weather Icon Id , Returns String Array
	Weather_Icon = Get Weather Icon Symbol , Returns String Array
	
	Wind_Speed =  Returns Double Array
	Wind_Name =  Returns String Array
	Wind_Code = Returns String Array

	Temperature_OnDay = Returns Double Array
	Temperature_OnNight = Returns Double Array
	Temperature_OnEve = Returns Double Array
	Temperature_OnMorning = Returns Double Array
	Temperature_Minimum = Returns Double Array
	Temperature_Maximum = Returns Double Array

	Pressure_Units = Return String Array
	Presure_vale = Returns Double Array

	Humidity_Value = Returns Int Array
	Humidity_Unit = Returns String Array

	Cloud = Returns String Array;
	Rain Chance = Get Percentage of Clouds, Returns String Array

	Sun_Rise = Returns String Array
	Sun_Set = Returns String Array

	City = Return String

	Weather_Name = Returns String Array


***Bonus

Utilites

Implementation

	Utils.ToUp(TEXT)
	Utils.Image_Returner(int CODE) put the Weather code here to get the Custom Icon
	Utils.Weather_ToIcon(String ICON) put the weather code here to get the default icon
		
 
