// Regras para criação de um componente componente
// 1 - O componente deve ser uma função
// 2 - Deve retornar apenas um elemento pai HTML
// 3 - Exportar o componente
// 4 - O nome da função precisa estar em PascalCasing

import { useEffect, useState } from "react";

function ListarProdutos() {
  //useEffect é o método que permite executar
  //agum código, no momento do carregamento
  //do componente

  //Pegar os dados que chegaram da requisição e 
  //mostrar no HTML
  // - Estado/VAriavel

    const [produtos, setProdutos] = useState([]);


  useEffect(() => {
    //Biblioteca AXIOS para requisições

    buscarProdutosAPI();
  }, []);

  async function buscarProdutosAPI() {
    try {
      const resposta = await fetch("http://localhost:5190/api/produto/listar");

      if (!resposta.ok) {
        throw new Error("Requisição com problema" + resposta.statusText);
      }

      const dados = await resposta.json();

      console.log(dados);
      setProdutos(dados);
    } catch (error) {
      console.log("Requisição com problema " + error);
    }
  }

  return (
    <div id="listar_produtos">
      <h1>Listar Produtos</h1>

       {/* 4. Exibir os produtos */}
       {produtos.length === 0 ? (
        <p>Carregando produtos...</p>
      ) : (
        <ul>
          {produtos.map((produto) => (
            <li key={produto.produto_id}>{produto.produto_nome}</li> // Assumindo que o produto tem "id" e "nome"
          ))}
        </ul>
      )}

    </div>
  );
}

export default ListarProdutos;
