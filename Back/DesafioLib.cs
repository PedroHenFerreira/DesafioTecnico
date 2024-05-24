using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Npgsql;
using RestSharp;

namespace Back
{
    class DesafioLib {
        public JObject responseJson { get; set; }

        public async Task<JObject> UserGenerator(string url){
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            try
            {
                RestResponse response = (RestResponse) await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    responseJson = JObject.Parse(response.Content);
                    return responseJson;
                }
                else
                {
                    responseJson = JObject.Parse(response.ErrorMessage);
                    return responseJson;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"[ERRO] Mensagem: {e.Message}");
            }

            return responseJson;
        }

        public async Task<string> RegisterUser(string url, JToken user){
            string email = (string) user["email"];
            string gender = (string) user["gender"];
            string title = (string) user["name"]["title"];
            string firstName = (string) user["name"]["first"];
            string lastName = (string) user["name"]["last"];
            int streetNumber = (int) user["location"]["street"]["number"];
            string streetName = (string) user["location"]["street"]["name"];
            string city = (string) user["location"]["city"];
            string stateLocation = (string) user["location"]["state"];
            string country = (string) user["location"]["country"];
            string postCode = (string) user["location"]["postcode"];
            string latitude = (string) user["location"]["coordinates"]["latitude"];
            string longitude = (string) user["location"]["coordinates"]["longitude"];
            string timezoneOffset = (string) user["location"]["timezone"]["offset"];
            string timezoneDescription = (string) user["location"]["timezone"]["description"];
            string uuidLogin = (string) user["login"]["uuid"];
            string usernameLogin = (string) user["login"]["username"];
            string passwordLogin = (string) user["login"]["password"];
            string salt = (string) user["login"]["salt"];
            string md5 = (string) user["login"]["md5"];
            string sha1 = (string) user["login"]["sha1"];
            string sha256 = (string) user["login"]["sha256"];
            string dateOfBirth = (string) user["dob"]["date"];
            int age = (int) user["dob"]["age"];
            string dateRegistered = (string) user["registered"]["date"];
            int ageRegistered = (int) user["registered"]["age"];
            string phone = (string) user["phone"];
            string cell = (string) user["cell"];
            string nameId = (string) user["id"]["name"];
            string valueId = (string) user["id"]["value"];
            string pictureLarge = (string) user["picture"]["large"];
            string pictureMedium = (string) user["picture"]["medium"];
            string thumbnail = (string) user["picture"]["thumbnail"];
            string nat = (string) user["nat"];            

            string response = "";

            JObject jsonObject = new JObject();

            jsonObject.Add("email", email);
            jsonObject.Add("gender", gender);
            jsonObject.Add("title", title);
            jsonObject.Add("firstname", firstName);
            jsonObject.Add("lastname", lastName);
            jsonObject.Add("streetnumber", streetNumber);
            jsonObject.Add("streetname", streetName);
            jsonObject.Add("city", city);
            jsonObject.Add("statelocation", stateLocation);
            jsonObject.Add("country", country);
            jsonObject.Add("postcode", postCode);
            jsonObject.Add("latitude", latitude);
            jsonObject.Add("longitude", longitude);
            jsonObject.Add("timezoneoffset", timezoneOffset);
            jsonObject.Add("timezonedescription", timezoneDescription);
            jsonObject.Add("uuidlogin", uuidLogin);
            jsonObject.Add("username", usernameLogin);
            jsonObject.Add("passwordlogin", passwordLogin);
            jsonObject.Add("salt", salt);
            jsonObject.Add("md5", md5);
            jsonObject.Add("sha1", sha1);
            jsonObject.Add("sha256", sha256);
            jsonObject.Add("dateofbirth", dateOfBirth);
            jsonObject.Add("age", age);
            jsonObject.Add("dateregistered", dateRegistered);
            jsonObject.Add("ageregistered", ageRegistered);
            jsonObject.Add("phone", phone);
            jsonObject.Add("cell", cell);
            jsonObject.Add("nameid", nameId);
            jsonObject.Add("valueid", valueId);
            jsonObject.Add("picturelarge", pictureLarge);
            jsonObject.Add("picturemedium", pictureMedium);
            jsonObject.Add("thumbnail", thumbnail);
            jsonObject.Add("nat", nat);

            string jsonBody = jsonObject.ToString();

            var client = new RestClient(url);
            var request = new RestRequest(Method.POST)
                .AddHeader("Content-Type", "application/json")
                .AddJsonBody(jsonBody);

            RestResponse res = (RestResponse) await client.ExecuteAsync(request);

            response = "Usuário registrado com sucesso.";

            return response;
        }

    }
}