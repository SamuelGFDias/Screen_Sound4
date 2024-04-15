using Teste.Modelos;
namespace Teste.Filtros;

internal class LinqOrder
{
    public static void FilmesOrdenadosPorTitulo(List<Filme> filmes)
    {
        var filmesOrdenadosPorTitulo = filmes
            .OrderBy(t => t.Titulo);
        foreach (var filme in filmesOrdenadosPorTitulo) 
        {
            filme.DescricaoResumida();
            Console.WriteLine();
        }
    }
    public static void FilmesOrdenadosPorRank(List<Filme> filmes)
    {
        var filmesOrdenadosPorRank = filmes
            .OrderBy(t => t.Rank);
        foreach (var filme in filmesOrdenadosPorRank)
        {
            filme.DescricaoResumida();
            Console.WriteLine();
        }
    }
}
