using System.Text.Json;
using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;
 
using (HttpClient client = new HttpClient())
{
    try
    {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    // musicas[0].ExibirDetalhesDaMusica();
    // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
    // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
    // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

    var minhasMusicasPreferidas = new MusicasPreferidas("Fábio");
    minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
    minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[10]);
    minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[5]);
    minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[50]);
    minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
    minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[30]);

    minhasMusicasPreferidas.ExibirMusicasFavoritas();
    minhasMusicasPreferidas.GerarArquivoJson();

    } catch (Exception e)
    {
        Console.WriteLine($"Temos um problema: {e.Message}");
    }

}