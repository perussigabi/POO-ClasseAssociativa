Cliente cliente1 = new Cliente(
    "Gabriele Perussi Silva",
    "123.456.789-00"
);

Cliente cliente2 = new Cliente(
    "Mariana Oliveira",
    "987.654.321-00"
);

Veiculo veiculo1 = new Veiculo(
    "Toyota Corolla",
    "ABC-1234"
);

Veiculo veiculo2 = new Veiculo(
    "Honda Civic",
    "DEF-5678"
);

Locacao locacao1 = new Locacao(
    cliente1,
    veiculo1,
    new DateOnly(2026, 10, 8),
    5,
    150m
);

Locacao locacao2 = new Locacao(
    cliente2,
    veiculo2,
    new DateOnly(2026, 10, 8),
    10,
    200m
);

locacao1.ExibirResumo();

Console.WriteLine();

locacao2.ExibirResumo();