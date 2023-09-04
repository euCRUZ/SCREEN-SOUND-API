using SCREEN_SOUND_API.Modelos;
using System.Text.Json;
using SCREEN_SOUND_API.Filtros;
using System.ComponentModel;

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        /*musicas[0].ExbirDetalhesDaMusica();*/
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop"); // nome do genero
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "2 Chainz"); // nome do Artista

        //LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //var musicasPreferidas = new MusicasPreferidas("Gi");
        //musicasPreferidas.AdicionarMusicaFavortia(musicas[1000]);
        //musicasPreferidas.AdicionarMusicaFavortia(musicas[964]);
        //musicasPreferidas.AdicionarMusicaFavortia(musicas[1930]);
        //musicasPreferidas.AdicionarMusicaFavortia(musicas[1252]);
        //musicasPreferidas.AdicionarMusicaFavortia(musicas[311]);
        //musicasPreferidas.ExibirMusicasFavoritas();

        //var musicasPreferidas2 = new MusicasPreferidas("Jaime");
        //musicasPreferidas2.AdicionarMusicaFavortia(musicas[1565]);
        //musicasPreferidas2.AdicionarMusicaFavortia(musicas[786]);
        //musicasPreferidas2.AdicionarMusicaFavortia(musicas[329]);
        //musicasPreferidas2.AdicionarMusicaFavortia(musicas[14]);
        //musicasPreferidas2.AdicionarMusicaFavortia(musicas[1744]);
        //musicasPreferidas2.ExibirMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJson();
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}