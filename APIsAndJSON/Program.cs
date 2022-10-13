using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            //RonVSKanyeAPI.RonQuote();

            //Pause.Slow();

            //RonVSKanyeAPI.KanyeQuote();

            //Pause.Slow();

            //RonVSKanyeAPI.RonQuote();

            //Pause.Slow();

            //RonVSKanyeAPI.KanyeQuote();

            //Pause.Slow();

            //RonVSKanyeAPI.RonQuote();

            //Pause.Slow();

            //RonVSKanyeAPI.KanyeQuote();

            //Pause.Slow();

            //RonVSKanyeAPI.RonQuote();

            //Pause.Slow();

            //RonVSKanyeAPI.KanyeQuote();

            //Pause.Slow();

            //RonVSKanyeAPI.RonQuote();

            //Pause.Slow();

            //RonVSKanyeAPI.KanyeQuote();

            #endregion

            #region Exercise 2

            string key = File.ReadAllText("appsettings.json");

            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.Write("Please enter your zipcode: ");

            string zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {OpenWeatherMapAPI.GetTemp(apiCall)}° F in your location... have a good day :)");

            #endregion

        }
    }
}