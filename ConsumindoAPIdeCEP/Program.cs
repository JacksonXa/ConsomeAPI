
using Newtonsoft.Json;

namespace ConsumindoAPIdeCEP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://viacep.com.br/ws/") };

            Console.WriteLine("Informe seu CEP (apenas numeros): ");
            var cep = Console.ReadLine();

            var response = await client.GetAsync(cep+"/json");

            var content = await response.Content.ReadAsStringAsync();

            var dadosEndereco = JsonConvert.DeserializeObject<Endereco>(content);

            Console.WriteLine(dadosEndereco.Logradouro);
        }
    }
}