using AstroPix.Shared.Models;
using AstroPix.Shared.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AstroPix.Shared
{
    public class AstrobinService : IAstrobinService
    {
        HttpClient _client;
        public ImageResults items;

        public AstrobinService()
        {
            _client = new HttpClient();
        }

        public async Task<ImageResults> RefreshDataAsync()
        {
            items = new ImageResults();
            var url = Constants.Url;

            var uri = new Uri(string.Format(url, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<ImageResults>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return items;
        }
    }
}
