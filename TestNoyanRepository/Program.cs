// See https://aka.ms/new-console-template for more information
using Noyan.Repository;
using Noyan.Repository.Models;

Console.WriteLine("Hello, World!");
var dbContext = new NoyanDbContext();
var repo = new TrackingRepository<Client>(dbContext);
repo.EnableTableTracking();
long currentVersion;
do
{
    currentVersion = repo.GetCurrentTrackingVersion();
    Console.WriteLine($"Current version={currentVersion}");
} while (Console.ReadKey().Key != ConsoleKey.Escape);

long initialVersion = 1;
while(currentVersion > initialVersion)
{
    var ct = repo.GetTrackingChanges(initialVersion);
    ct.ForEach(x => Console.WriteLine(x));
    initialVersion++;
}