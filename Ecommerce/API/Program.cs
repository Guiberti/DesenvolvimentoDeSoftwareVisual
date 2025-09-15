var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Funcionalidade - Requisições
// - URL/Caminho/Endereço
// - Um método HTTP

app.MapGet("/", () => "Testando a API");

app.MapGet("/endereco", () => "Outra funcionalidade");

app.MapPost("/endereco", () => "Funcionalidade do POST");

app.Run();  
