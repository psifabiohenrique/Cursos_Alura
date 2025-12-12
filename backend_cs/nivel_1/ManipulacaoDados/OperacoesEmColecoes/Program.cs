using OperacoesEmColecoes;

var musica1 = new Musica { Titulo = "Que País é Esse?", Artista = "Legião Urbana", Duracao = 350 };
var musica2 = new Musica { Titulo = "Tempo Perdido", Artista = "Legião Urbana", Duracao = 455 };
var musica3 = new Musica { Titulo = "Pro Dia Nascer Feliz", Artista = "Barão Vermelho", Duracao = 345 };
var musica4 = new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 530 };
var musica5 = new Musica { Titulo = "Geração Coca-Cola", Artista = "Legião Urbana", Duracao = 380 };

var rockNacional = new Playlist { Nome = "Rock Nacional" };
rockNacional.Add(musica2);
rockNacional.Add(musica1);
rockNacional.Add(musica3);
rockNacional.Add(musica4);
rockNacional.Add(musica5);
rockNacional.Add(new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 530 });

var legiaoUrbana = new Playlist() { Nome = "Mais populares da Legião" };
legiaoUrbana.Add(musica1);
legiaoUrbana.Add(musica2);
legiaoUrbana.Add(musica4);
legiaoUrbana.Add(musica5);

//ExibirPlaylist(rockNacional);
ExibirMaisTocadas(rockNacional, legiaoUrbana);

void ExibirPlaylist(Playlist playlist)
{
    Console.WriteLine($"\n Tocando as músicas de {playlist.Nome}");
    foreach (var musica in playlist)
    {
        Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista}) - {musica.Duracao} segundos");
    }
}

void ExibirMaisTocadas(Playlist playlist1, Playlist playlist2)
{
    // Musica (chave/key), Contagem (valor/value)
    Dictionary<Musica, int> ranking = [];

    foreach (var musica in playlist1)
    {
        ranking.Add(musica, 1);
    }

    foreach (var musica in playlist2)
    {
        if (ranking.TryGetValue(musica, out int contagem))
        {
            contagem++;
            ranking[musica] = contagem;
        }
        else
        {
            ranking[musica] = 1;
        }
    }

    List<KeyValuePair<Musica, int>> top = new(ranking); //[..ranking];
    top.Sort(new PorContagem());

    Console.WriteLine("\nTop 3 músicas mais incluídas nas playlists:");
    int contador = 1;
    foreach (var par in top)
    {
        Console.WriteLine($"\t - {par.Key.Titulo}");
        contador++;
        if (contador > 3) break;
    }
}

void RemoverMusicaPeloTitulo(Playlist playlist, string titulo)
{
    var musicaEncontrada = playlist.ObterPeloTitulo(titulo);
    if (musicaEncontrada is not null)
    {
        Console.WriteLine("\nRemovendo música...");
        playlist.Remove(musicaEncontrada);
    }
    else
    {
        Console.WriteLine("\nMúsica não encontrada!");
    }

    ExibirPlaylist(playlist);
}

void ExibirMusicaAleatoria(Playlist playlist)
{
    var musicaAleatoria = playlist.ObterAleatoria();
    if (musicaAleatoria is not null)
    {
        Console.WriteLine($"\nA música aleatória é {musicaAleatoria.Titulo}");
    }
    else
    {
        Console.WriteLine("Playlist vazia!");
    }
}