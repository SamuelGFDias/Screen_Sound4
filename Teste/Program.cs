using Teste.Modelos;
using System.Text.Json;
using Teste.Filtros;

//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
//        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
//        foreach(var filme in filmes)
//        {
//            filme.GerarArquivoTxt();
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Erro: {ex.Message}");
//    }
//}


//Pessoa pessoa1 = new("Samuel",10,"samuel.dias");
//Pessoa pessoa2 = new("Lucas",10,"lucas.carlos");
//Pessoa pessoa3 = new("a",20,"lucas.carlos");
//Pessoa pessoa4 = new("b",20,"lucas.carlos");
//Pessoa pessoa5 = new("c",20,"lucas.carlos");
//List<Pessoa> pessoas = new();
//pessoas.Add(pessoa1);
//pessoas.Add(pessoa2);
//pessoas.Add(pessoa3);
//pessoas.Add(pessoa4);
//pessoas.Add(pessoa5);

//string json = JsonSerializer.Serialize(pessoas);
//List<Pessoa> jsonDesserializado = JsonSerializer.Deserialize<List<Pessoa>>(json)!;

//Console.Write("Digite uma idade para filtrar: ");
//int idadeParaPesquisar = int.Parse(Console.ReadLine()!);
//foreach (Pessoa p in jsonDesserializado.Where(p => p.Idade.Equals(idadeParaPesquisar)))
//{
//    Console.WriteLine(p.Nome);
//}
