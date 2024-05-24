using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;
using Npgsql;
using System.Globalization;

namespace Back
{
    class Program
    {        
        static async Task Main(string[] args)
        {
            DesafioLib desafioLib = new DesafioLib();
            string url = "https://randomuser.me/api/";
            string url_api = "http://localhost:5214/api/Users";

            for (int i=0; i<10; i++){
                JObject responseJson = desafioLib.UserGenerator(url).Result;
                JToken user = responseJson["results"][0];

                string responseUser = desafioLib.RegisterUser(url_api, user).Result;
                Console.WriteLine(responseUser);
                Console.WriteLine("####################################################################");

                Thread.Sleep(TimeSpan.FromSeconds(5));
            }
        }
    }
}
