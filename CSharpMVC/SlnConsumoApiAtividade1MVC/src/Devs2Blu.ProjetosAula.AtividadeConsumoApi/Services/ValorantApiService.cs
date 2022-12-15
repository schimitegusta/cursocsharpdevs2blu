using Devs2Blu.ProjetosAula.AtividadeConsumoApi.Models;

namespace Devs2Blu.ProjetosAula.AtividadeConsumoApi.Services
{
    public class ValorantApiService
    {

        private readonly HttpClient _httpClient;
        private const string URL_API_AGENTS = "https://valorant-api.com/v1/agents";
        private const string URL_API_WEAPONS = "https://valorant-api.com/v1/weapons";

        public ValorantApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Weapons> GetWeapons()
        {
            return await Get<Weapons>(URL_API_WEAPONS);
        }

        public async Task<Agents> GetAgents()
        {
            return await Get<Agents>(URL_API_AGENTS);
        }

        public async Task<T> Get<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
            {
                return (T)(object)url;
            }

            return await listHttp.Content.ReadFromJsonAsync<T>();
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            var getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            return await _httpClient.SendAsync(getRequest);
        }
    }
}
