using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;

namespace listviewJson
{
    public partial class Page1 : ContentPage
    {

        public class ItemClass
        {
            [JsonProperty(PropertyName = "Name")]
            public string Name { get; set; }
          //  public string description { get; set; }
        }

        public Page1()
        {
            InitializeComponent();
            loaddata();
        }

        public async void loaddata()
        {
            var content = "";
           HttpClient client = new HttpClient();
            var RestURL = "http://www.pizzaboy.de/app/pizzaboy.json";  
       client.BaseAddress = new Uri(RestURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
           HttpResponseMessage response = await client.GetAsync(RestURL);
            content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<ItemClass>>(content);

            loaddatalist.ItemsSource = Items;
        }
    }
}  
        