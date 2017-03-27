using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace listviewJson
{
    class ListJson {
        private const string ApiBaseAddress = "http://172.31.0.84/indent/api/indent?loccode=ppla";

    private HttpClient CreateClient()
    {
        var httpClient = new HttpClient
        {

        };

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClient;
    }

    public async Task<List<StudentModel>> GetConferences()
    {
        MainJsonClass jsonclass = new MainJsonClass();

        using (var httpClient = CreateClient())
        {
            var json = await httpClient.GetStringAsync(ApiBaseAddress).ConfigureAwait(false);
            // var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!string.IsNullOrWhiteSpace(json))
            {
                jsonclass = await Task.Run(() =>
                   JsonConvert.DeserializeObject<MainJsonClass>(json)
                ).ConfigureAwait(false);
            }
        }
        return jsonclass.responselist;
        //return conferenceDtos.ToList();
    }
}
}
