using SCREEN_SOUND_API.Modelos;
using System.Globalization;

namespace SCREEN_SOUND_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList(); // Distinct() remove os itens duplicados, fazendo com que se tenha apenas um genero de cada tipo.
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }       
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Artistas do gênero {genero}:");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }   

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine( nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.Write($"\n- {musica.Nome}\n");
        }
    }

    public static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
    