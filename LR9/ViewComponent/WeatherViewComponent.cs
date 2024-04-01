using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


    public class WeatherViewComponent : ViewComponent
    {
        static async Task<dynamic> GetWeatherData(string latitude, string longitude, string apiKey)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}");
                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync();

                dynamic data = JsonConvert.DeserializeObject(jsonString);
                return data;
            }
        }

        public async Task<IViewComponentResult> InvokeAsync(string lat, string lng)
        {
            var api_key = "2d237a829f431d7197b6f6bb77f2ad91";

        dynamic weatherData = await GetWeatherData(lat, lng, api_key);

            double temperature = Math.Round((double)weatherData.main.temp);
            int humidity = (int)weatherData.main.humidity;
            double pressure = (double)weatherData.main.pressure;

            var model = new WeatherModel
            {
                Temperature = temperature,
                Humidity = humidity,
                Pressure = pressure,
            };

            return View("Weather", model);
        }
    }