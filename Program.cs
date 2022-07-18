// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RestSharp;
using TestMock.Models;

Console.WriteLine("Hello, World!");
RestClient client = new RestClient("https://localhost:7190");
RestRequest request = new RestRequest("User");
List<User> response = await client.GetAsync<List<User>>(request);
foreach (var user in response)
{
    Console.WriteLine(JsonConvert.SerializeObject(user));
}
Console.ReadLine();