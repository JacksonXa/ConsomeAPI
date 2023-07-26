
using Newtonsoft.Json;


{
    //Criação de uma instância do HttpClient com o endereço base "https://jsonplaceholder.typicode.com". Para enviar e receber dados.
    HttpClient client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };

    //Faz uma solicitação HTTP assíncrona do tipo GET para o endpoint "users". o await serve para aguardar a resposta
    var response = await client.GetAsync("users");
    //Lê o conteúdo da resposta como uma string JSON. o await serve para aguardar a resposta
    var content = await response.Content.ReadAsStringAsync();

    //Converte o JSON em uma lista de objetos de usuário (Users[]).
    var Listusers = JsonConvert.DeserializeObject<Users[]>(content);

    //Exibe os nomes e emails dos usuários obtidos.
    foreach (var user in Listusers)
    {
        Console.WriteLine(user.Name);
        Console.WriteLine(user.Email);
    }
}
