using ConsumeApi.QuickType;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace ConsumeApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Acessando a API
            HttpClient client = new HttpClient {BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };
            //Metodo get async
            var response = await client.GetAsync("users");
            //Variavel que lê o Json
            var content = await response.Content.ReadAsStringAsync();
            //Baixei o JsonConvert e desfiz o objeto, converti o json em classe c#     
            var users = JsonConvert.DeserializeObject<User[]>(content);

            foreach(var item in users)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Email);
            }
        }
    }

    


}