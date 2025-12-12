using IntroAColecao;

DiasDaSemana diasDaSemana = new DiasDaSemana();

List<Produto> carrinho =
[
    new Produto() { Nome = "Caneta", Preco = 3.45 },
    new Produto() { Nome = "Caderno", Preco = 23.90 },
    new Produto() { Nome = "Borracha", Preco = 1.50 }
];

PercorrendoComEnumerator();


void PercorrendoComEnumerator()
{
    var enumerator = diasDaSemana.GetEnumerator();
    while (enumerator.MoveNext())
    {
        var dia = enumerator.Current;
        Console.WriteLine(dia);
    }
}
void PercorrendoDiasDaSemana()
{
    foreach (var dia in diasDaSemana)
    {
        Console.WriteLine(dia);
    }
}
void PercorrendoComFor()
{
    for (int i = 0; i < carrinho.Count; i++)
    {
        Console.WriteLine($"Produto: {carrinho[i].Nome} - Preço: {carrinho[i].Preco}");
    }
}

void PercorrendoComForEach()
{
    foreach (Produto produto in carrinho)
    {
        Console.WriteLine($"Produto: {produto.Nome} - Preço: {produto.Preco}");
    }
}