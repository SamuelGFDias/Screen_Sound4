using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Teste.Modelos;

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }
    [JsonPropertyName("rank")]
    public string? RankString { get; set; }
    public int Rank
    {
        get { return int.Parse(RankString!); }
    }
    [JsonPropertyName("year")]
    public string? AnoString { get; set; }
    public int Ano
    {
        get { return int.Parse(AnoString!); }
    }
    [JsonPropertyName("crew")]
    public string ElencoString
    {
        set
        {
            string[] nomes = value.Split(',');
            foreach (var s in nomes)
            {
                Elenco.Add(s.Trim());
            }
        }
    }
    public List<string> Elenco { get; } = new();
    public void DescricaoResumida()
    {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Ano de Lançamento: {Ano}");
        Console.WriteLine($"Rank: {Rank}");
            if (Elenco.Count > 0)
            {
                Console.WriteLine($"Elenco:");
                foreach (var nome in Elenco) 
                {
                    Console.WriteLine($"Astista: {nome}");
                }
            }
    }
    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            titulo = Titulo,
            elenco = Elenco
        });
        string nomeDoArquivo = $"Elenco-{Titulo}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Arquivo criado para o filme {Titulo}. {Path.GetFullPath(nomeDoArquivo)}");
    }
    public void GerarArquivoTxt()
    {
        string nomeDoArquivo = $"filme-{Titulo}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Músicas favoritas de {Titulo}:\n");
            foreach(var nome in Elenco)
            {
                arquivo.WriteLine($"- {nome}");
            }
            Console.WriteLine("txt gerado com sucesso!");
        }
    }
}

