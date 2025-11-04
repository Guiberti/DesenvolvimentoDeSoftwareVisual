import { useState } from "react";
import Produto from "../../../models/Produto";

function CadastrarProduto() {
  const [nome, setNome] = useState("");

  function submeterProdutoAPI(e: any) {
    e.preventDefault();
    console.log("SUBMETEMOS O FORMULARIO");
  }

  async function enviarProdutoAPI() {
    const produto: Produto = {
      nome: nome,
      quantidade: 123,
      preco: 55.75,
    };

    const resposta = await fetch(
      "http://localhost:5190/api/produto/cadastrar",
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body : JSON.stringify(produto)
      }
    );
    console.log(resposta);
  }

  function escreverTxtNome(e: any) {
    console.log(e.target.value);
  }

  return (
    <div>
      <h1>Cadastrar Produto</h1>
      <form onSubmit={submeterProdutoAPI}>
        <div>
          <label>Nome</label>
          <input type="text" onChange={escreverTxtNome} />
        </div>
        <div>
          <button type="submit">Cadastrar</button>
        </div>
      </form>
    </div>
  );
}

export default CadastrarProduto;
