class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album()
    {
    }

    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do album {this.Nome}");
        foreach (Musica musica in this.musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"A duração total do álbum é: {this.DuracaoTotal}");
    }
}