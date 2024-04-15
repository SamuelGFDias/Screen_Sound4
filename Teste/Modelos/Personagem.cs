using System.Text.Json.Serialization;

namespace Screen_Sound04.Modelos;

internal class Personagem
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("gender")]
    public string? Genero { get; set; }
    [JsonPropertyName("aliases")]
    public List<string>? Apelidos { get; set; }
    [JsonPropertyName("titles")]
    public List<string>? Titulos { get; set; }
    [JsonPropertyName("books")]
    public List<string>? Livros { get; set; }
    public void DescricaoResumida()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Genero: {Genero}");
        if (Apelidos != null && Apelidos.Count > 0)
        {
            foreach ( var apelido in Apelidos)
            {
                Console.WriteLine($"Apelido: {apelido}");
            }
        }
        if (Titulos != null && Titulos.Count > 0)
        {
            foreach (var titulo in Titulos)
            {
                Console.WriteLine($"Titulo: {titulo}");
            }
        }
        if (Livros != null && Livros.Count > 0)
        {
            foreach (var livro in Livros)
            {
                string[] segments = livro.Split("/");
                string numeroDoLivro = segments[segments.Length - 1];
                Console.WriteLine($"Livro: {numeroDoLivro}");   
            }
        }
    }
}
