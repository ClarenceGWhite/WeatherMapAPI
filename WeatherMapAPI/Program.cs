using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace WeatherMapAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString ();

            Console.WriteLine("Please enter your zip code: ");
            var zipCode = Console.ReadLine();
          
            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";
            //var apiCall = $"https://api.openweathermap.org/data/2.5/forecast?zip=66220&units=imperial&appid={APIKey}";
            
            Console.WriteLine();
            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees in the {zipCode} zip code.");
            


        }
    }
}
