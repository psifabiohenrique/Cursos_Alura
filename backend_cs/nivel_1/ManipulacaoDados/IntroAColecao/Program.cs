using System.Collections;

string[] diasDaSemana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"};

List<Produto> produtos =
[
    new Produto() { Nome = "Caneta", Preco = 3.45 },
    new Produto() { Nome = "Caderno", Preco = 23.90 },
    new Produto() { Nome = "Borracha", Preco = 1.50 }
];

class Produto {
    public string Nome { get; set; }
    public double Preco { get; set; }
}