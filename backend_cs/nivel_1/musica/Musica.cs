class Musica
{
    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {this.Nome} pertence ao artista {this.Artista}";

    public Musica(Banda artista, string nome)
    {
        this.Artista = artista;
        this.Nome = nome;
    }
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Artista: {this.Artista.Nome}");
        Console.WriteLine($"duracao: {this.Duracao}");
        if (this.Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adiquira o plano Plus");
        }
    }
}