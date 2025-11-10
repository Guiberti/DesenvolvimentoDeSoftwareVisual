import { useState } from "react";
import Produto from "../../../models/Produto";
import axios from "axios";

function CadastrarProduto() {
  const [nome, setNome] = useState("");
  


  function enviarProduto() {  
    enviarProdutoAPI();
  }

  async function enviarProdutoAPI() {
    try {
      const produto: Produto = {
        nome,
        preco,
        quantidade,
      };

      const resposta = await axios.post(
        "http://localhost:5190/api/produto/cadastrar",
        produto
      );
      console.log(resposta.data);
    } catch (error) {
      console.log("Erro ao cadastrar o produto: " + error);
    }
  }

  return (
    <div>
      <h1>Cadastrar Produto</h1>
      <form onSubmit={enviarProduto}>
        <div>
          <label>Nome</label>
          <input onChange={(e: any) => setNome(e.target.value)} type="text" />
        </div>
        <div>
          <button type="submit">Cadastrar</button>
        </div>
      </form>
    </div>
  );
}

export default CadastrarProduto;
