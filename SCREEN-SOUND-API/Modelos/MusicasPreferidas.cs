using System.Text.Json;

namespace SCREEN_SOUND_API.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
    
    public void AdicionarMusicaFavortia(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Musicas favoritas de {Nome}:\n");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($" {musica.Nome} - {musica.Artista}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDArquivo, json);
        Console.WriteLine($"Arquivo '{nomeDArquivo}' criado com sucesso! {Path.GetFullPath(nomeDArquivo)}");
    }
}
