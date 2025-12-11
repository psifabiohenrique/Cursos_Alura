class Musica
{
    public string nome { get; set; }
    public string artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {this.nome} pertence ao artista {this.artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {this.nome}");
        Console.WriteLine($"Artista: {this.artista}");
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