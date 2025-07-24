// See https://aka.ms/new-console-template for more information

using PharmaDataBase;




Console.WriteLine("Fetching drug data from SFDA...");
for (int i = 1; i <= 869; i++) // Fetching first 10 pages as an example
{
    var service = new DrugService();
    await service.FetchAndSaveAsync(i);
    Console.WriteLine($"Done.{i}");
}
//var service = new DrugService();
//await service.FetchAndSaveAsync();

Console.WriteLine("Done.");