using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;
using System.ComponentModel;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        //var musicasFavoritasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[0]);
        //musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[2]);
        //musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[3]);
        //musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasFavoritasDoDaniel.ExibirMusicasFavoritas();
        LinqFilter.FiltrarMusicasPelaTonalidade(musicas, "C#");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}