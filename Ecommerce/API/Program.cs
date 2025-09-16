using System.Collections;
using API.Models;
Console.Clear();
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Funcionalidade - Requisições
// - URL/Caminho/Endereço
// - Um método HTTP

//Lista de produtos fakes

List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Notebook", Quantidade = 5, Preco = 3500.00 },
    new Produto { Nome = "Smartphone", Quantidade = 10, Preco = 1800.00 },
    new Produto { Nome = "Mouse Gamer", Quantidade = 20, Preco = 120.00 },
    new Produto { Nome = "Teclado Mecânico", Quantidade = 15, Preco = 250.00 },
    new Produto { Nome = "Monitor 24\"", Quantidade = 8, Preco = 900.00 },
    new Produto { Nome = "Impressora", Quantidade = 4, Preco = 750.00 },
    new Produto { Nome = "Cadeira Gamer", Quantidade = 7, Preco = 1100.00 },
    new Produto { Nome = "Headset", Quantidade = 12, Preco = 200.00 },
    new Produto { Nome = "HD Externo 1TB", Quantidade = 9, Preco = 400.00 },
    new Produto { Nome = "Webcam Full HD", Quantidade = 6, Preco = 300.00 }
};

// Métodos HTTP são ações usadas para comunicação entre cliente e servidor.
// Os principais são:
// GET -> buscar dados
// POST -> enviar/criar dados
// PUT -> atualizar dados
// DELETE -> excluir dados

app.MapGet("/", () => "API de Produtos");

//GET: /api/produto/listar
app.MapGet("/api/produto/listar", () =>
{
    return produtos;
});

//POST: /api/produto/cadastrar
app.MapPost("api/produto/cadastrar", (Produto produto) =>
{
    produtos.Add(produto);
});


app.Run();
