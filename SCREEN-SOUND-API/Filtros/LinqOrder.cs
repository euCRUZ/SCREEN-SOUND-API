using SCREEN_SOUND_API.Modelos;
namespace SCREEN_SOUND_API.Filtros;

internal class LinqOrder
{
   public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
         var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList(); 
        Console.WriteLine("Lista de Artistas (A-Z):");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }

}
