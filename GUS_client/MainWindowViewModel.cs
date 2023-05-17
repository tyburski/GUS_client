using GUS_client.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GUS_client
{    
    public class MainWindowViewModel
    {       
        public IEnumerable<Area> List { get; private set; }

        public MainWindowViewModel()
        {
            List = GetAreas().Result;           
        }
        public async Task<IEnumerable<Area>> GetAreas()
        {
            using (var client = new HttpClient())
            {
                var request = await client.GetAsync("https://api-dbw.stat.gov.pl/api/1.1.0/area/area-area").ConfigureAwait(false);

                if (request.IsSuccessStatusCode)
                {
                    string result = await request.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<IEnumerable<Area>>(result);
                }
                else
                {
                    return Enumerable.Empty<Area>();
                }
            }
        }
    }
}
