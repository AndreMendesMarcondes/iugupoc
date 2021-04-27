using IUGU.Web.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IUGU.Web.Service
{
    public class IUGUService
    {
        private readonly HttpClient _client;
        private const string IUGU_URI = " https://api.iugu.com";
        private string IUGU_WORKSPACE = Environment.GetEnvironmentVariable("UserId");
        public IUGUService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(IUGU_URI);
            AddHeader();
        }
        public async Task<IUGUResponse> GetPix(int valor)
        {
            var request = new IUGURequest(valor);
            var content = new StringContent(request.ToString(), Encoding.UTF8, "application/json");
            using var response = await _client.PostAsync("/v1/invoices", content);

            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<IUGUResponse>(result);
            }
            else
            {
                throw new Exception("Erro: " + result);
            }
        }

        private void AddHeader()
        {
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{IUGU_WORKSPACE}:")));
        }
    }
}
