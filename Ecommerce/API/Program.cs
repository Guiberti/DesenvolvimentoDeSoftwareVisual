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
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "Notebook", Quantidade = 5, Preco = 3500.00 },
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "Smartphone", Quantidade = 10, Preco = 1800.00 },
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "Mouse Gamer", Quantidade = 20, Preco = 120.00 },
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "Teclado Mecânico", Quantidade = 15, Preco = 250.00 },
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "Monitor 24\"", Quantidade = 8, Preco = 900.00 },
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "Impressora", Quantidade = 4, Preco = 750.00 },
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "Cadeira Gamer", Quantidade = 7, Preco = 1100.00 },
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "Headset", Quantidade = 12, Preco = 200.00 },
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "HD Externo 1TB", Quantidade = 9, Preco = 400.00 },
    new Produto { Id = Guid.NewGuid().ToString(), Nome = "Webcam Full HD", Quantidade = 6, Preco = 300.00 }
};

// Métodos HTTP são ações usadas para comunicação entre cliente e servidor.
// GET -> buscar dados
// POST -> enviar/criar dados
// PUT -> atualizar dados
// DELETE -> excluir dados
// PATCH - Atualiza parcialmente um recurso

app.MapGet("/", () => "API de Produtos");

//GET: /api/produto/listar
app.MapGet("/api/produto/listar", () =>
{
    if (produtos.Any())
    {
        return Results.Ok(produtos);
    }
    return Results.NotFound("Lista vazia");
});

//GET: /api/produto/buscar/nome_produto_buscado
app.MapGet("/api/produto/buscar/{nome}", (string nome) =>
{
    Produto? resultado = produtos.FirstOrDefault(x => x.Nome == nome);
    if (resultado is null)
    {
        return Results.NotFound("Produto não cadastrado!");
    }
    return Results.Ok(resultado);
});

//POST: /api/produto/cadastrar  
app.MapPost("/api/produto/cadastrar", (Produto produto) =>
{
    Produto? resultado = produtos.FirstOrDefault(x => x.Nome == produto.Nome);
    if (resultado is not null)
    {
        return Results.Conflict("Produto já cadastrado!");
    }
    produto.Id = Guid.NewGuid().ToString();
    produtos.Add(produto);
    return Results.Created($"/api/produto/buscar/{produto.Nome}", produto);
});

//DELETE: /api/produto/deletar/{id}
app.MapDelete("/api/produto/deletar/{id}", (string id) =>
{
    Produto? resultado = produtos.FirstOrDefault(x => x.Id == id);
    if (resultado is null)
    {
        return Results.NotFound("Produto não encontrado!");
    }
    produtos.Remove(resultado);
    return Results.Ok(resultado);
});

//PUT: /api/produto/atualizar/{id}
app.MapPatch("/api/produto/atualizar/{id}", (string id, Produto produtoAtualizado) =>
{
    Produto? resultado = produtos.FirstOrDefault(x => x.Id == id);

    if (resultado is null)
    {
        return Results.NotFound("Produto não encontrado!");
    }
    // Atualiza apenas os campos necessários
    resultado.Nome = produtoAtualizado.Nome;
    resultado.Preco = produtoAtualizado.Preco;
    resultado.Quantidade = produtoAtualizado.Quantidade;
    return Results.Ok(resultado);
});

app.Run();

AppDataContext ctx = new AppDataContext();
ctx.Add
