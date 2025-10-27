// Regras para criação de um componente componente
// 1 - O componente deve ser uma função
// 2 - Deve retornar apenas um elemento pai HTML
// 3 - Exportar o componente
// 4 - O nome da função precisa estar em PascalCasing



function ListarProdutos() {
  return (
    <div id="listar_produtos">
      <h1>Listar Produtos</h1>
      <ul>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
      </ul>
    </div>
  );
}

export default ListarProdutos;
