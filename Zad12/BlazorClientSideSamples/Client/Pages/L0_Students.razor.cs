using BlazorClientSideSamples.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorClientSideSamples.Client.Pages
{
    public partial class L0_Students
    {
        public List<Student2> Students2 { get; set; }

        protected override async Task OnInitializedAsync()
        {
            base.OnInitialized();

            await Task.Delay(3000);

            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://localhost:44377/api/students");
            var data = await result.Content.ReadAsStringAsync();
            Students2 = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student2>>(data);

        }
    }
}
