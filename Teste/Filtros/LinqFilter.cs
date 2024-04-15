using System.Linq;
using Teste.Modelos;

namespace Teste.Filtros;

internal class LinqFilter
{
    public static void FiltrarAnosDeLancamento(List<Filme> filmes)
    {
        var todosOsAnosDeLancamento = filmes
            .Select(a => a.Ano)
            .OrderBy(a => a)
            .Distinct();

        foreach (var ano in todosOsAnosDeLancamento)
        {
            Console.WriteLine($"- {ano}");
        }
    }
    public static void FiltrarFilmesPorArtista(List<Filme> filmes, string artista)
    {
        var filmesFiltradosPorArtista = filmes
            .Where(a => a.Elenco.Contains(artista))
            .OrderBy(a => a.Titulo)
            .Distinct();

        Console.WriteLine(artista);
        foreach (Filme filme in filmesFiltradosPorArtista)
        {
            Console.WriteLine($"- {filme.Titulo}");
        }
    }
    public static void FiltrarFilmesPorAno(List<Filme> filmes, int ano)
    {
        var filmesPorAnoDeLancamento = filmes
            .Where(a => a.Ano.Equals(ano))
            .OrderBy(a => a.Titulo)
            .Distinct();
        
        Console.WriteLine(ano);
        foreach (Filme filme in filmesPorAnoDeLancamento)
        {
            Console.WriteLine($"- {filme.Titulo}");
        }
    }
}
