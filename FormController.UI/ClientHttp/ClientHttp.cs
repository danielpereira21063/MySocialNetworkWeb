using Newtonsoft.Json;
using System.Text;

namespace FormController.UI.ClientHttp;

public class ClientHttp
{
    private HttpClient _client;

    public string Url = @"https://localhost:7000";

    public ClientHttp()
    {
        _client = new HttpClient()
        {
            BaseAddress = new Uri(Url),
            Timeout = new TimeSpan(0, 0, 0, 10000)
        };

        _client.DefaultRequestHeaders.Clear();
    }

    public async Task<T> PostAsync<T>(string end, object data)
    {
        var objJson = JsonConvert.SerializeObject(data);

        var content = new StringContent(objJson, Encoding.UTF8, "application/json");

        var result = await _client.PostAsync(end, content);

        if (result.IsSuccessStatusCode)
        {
            var stringRes = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(stringRes);
        }
        else
        {
            throw new Exception($"Falha na comunicação com o servidor\n{result.RequestMessage}");
        }
    }

    public T Post<T>(string end, object dados)
    {

        var objJson = JsonConvert.SerializeObject(dados);

        var content = new StringContent(objJson, Encoding.UTF8, "application/json");

        var result = _client.PostAsync(end, content).Result;

        if (result.IsSuccessStatusCode)
        {
            var stringRes = result.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(stringRes);
        }
        else
        {
            throw new Exception(result.RequestMessage.ToString());
        }
    }


    public async Task<T> GetAsync<T>(string end)
    {
        var result = await _client.GetAsync(end);

        if (result.IsSuccessStatusCode)
        {
            var stringRes = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(stringRes);
        }
        else
        {
            throw new Exception(result.RequestMessage.ToString());
        }
    }

    public T Get<T>(string end)
    {
        var result = _client.GetAsync(end).Result;

        if (result.IsSuccessStatusCode)
        {
            var stringRes = result.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<T>(stringRes);
        }
        else
        {
            throw new Exception(result.RequestMessage.ToString());
        }
    }
}
