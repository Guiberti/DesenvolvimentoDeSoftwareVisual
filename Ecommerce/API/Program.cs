using API.Models;
Console.Clear();
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Funcionalidade - Requisições
// - URL/Caminho/Endereço
// - Um método HTTP

app.MapGet("/", () => "Testando a API");

app.MapGet("/endereco", () => "Outra funcionalidade");

app.MapPost("/endereco", () => "Funcionalidade do POST");


Produto produto = new Produto();
produto.Nome = "Teclado";
Console.WriteLine(produto.Nome);

app.Run();
