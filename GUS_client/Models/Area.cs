using Newtonsoft.Json;

namespace GUS_client.Models
{
    public class Area
    {
        public int Id { get; set; }

        public string Nazwa { get; set; }

        [JsonProperty(PropertyName="id-nadrzedny-element")]
        public int Id_nadrzedny_element { get; set; }

        [JsonProperty(PropertyName = "id-poziom")]
        public int Id_poziom { get; set; }

        [JsonProperty(PropertyName = "nazwa-poziom")]
        public string Nazwa_poziom { get; set;}

        [JsonProperty(PropertyName = "czy-zmienne")]
        public bool Czy_zmienne { get; set; }
    }
}
