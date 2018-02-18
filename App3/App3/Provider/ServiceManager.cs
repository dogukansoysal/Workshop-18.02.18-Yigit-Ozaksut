using App3.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App3.Provider
{
    public class ServiceManager
    {
        private string baseUrl = "https://yasaruniversitesi.azurewebsites.net/api/HttpTriggerCSharp1?code=I2YH60roe3pK9vaXMAPOJ32VRjTBGkGtL7p7qD2mPWaXdkq4pTOkcQ==";
        public async Task<string> SendMessage(IEEEContactModel model)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var request = await client.PostAsync(baseUrl,
                    new StringContent(JsonConvert.SerializeObject(model),
                    Encoding.UTF8, "application/json"));

                if (request.StatusCode == HttpStatusCode.OK)
                {
                    var response = await request.Content.ReadAsStringAsync();
                    return response;
                }
                else
                {
                    return "Bir hata oluştu. Lütfen daha sonra tekrar deneyiniz.";
                }
            }
        }
    }
}