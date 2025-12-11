class Banda
{
    private List<Album> albums = new List<Album>();
    public string Nome { get; set; }

    public Banda(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        this.albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {this.Nome}");
        foreach (Album album in this.albums)
        {
            Console.WriteLine($"Album: {album.Nome}, duração: {album.DuracaoTotal}");
        }
    }
}