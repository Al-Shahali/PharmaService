

namespace PharmaDataBase
{
    using System.Net.Http;
    using System.Text.Json;


    public class DrugService
    {
        private readonly HttpClient _httpClient = new();

        public async Task FetchAndSaveAsync(int page)
        {
            using var db = new DrugDbContext();
            

            var response = await _httpClient.GetAsync($"https://www.sfda.gov.sa/GetDrugs.php?page={page}");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            options.Converters.Add(new NullableIntConverter());

            var drugResponse = JsonSerializer.Deserialize<DrugResponse>(json, options);

            db.Add(drugResponse);
            if (drugResponse?.Results != null)
            {
                db.AddRange(drugResponse.Results);
                await db.SaveChangesAsync();
                Console.WriteLine($"Saved {drugResponse.Results.Count} drugs to database.");
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }
    }


}
