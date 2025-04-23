// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using PollingInterviewChallenge.Model;

IServiceCollection _serviceCollection = new ServiceCollection();
ConfigureService();
Console.WriteLine("Hello, World!");
var poll = new Poll();
poll.Id = Guid.NewGuid();



static void ConfigureService()
{
    _serviceCollection.AddKeyedScoped();
}