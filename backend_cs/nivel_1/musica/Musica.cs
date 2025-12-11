class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {this.nome}");
        Console.WriteLine($"Artista: {this.artista}");
        Console.WriteLine($"duracao: {this.duracao}");
        if (this.disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adiquira o plano Plus");
        }
    }
}