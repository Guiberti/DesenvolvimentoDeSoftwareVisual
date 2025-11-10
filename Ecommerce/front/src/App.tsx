import React from "react";
import ListarProdutos from "./components/pages/produto/ListarProduto";
import { BrowserRouter, Link, Route, Routes } from "react-router-dom";
import CadastrarProduto from "./components/pages/produto/CadastrarProduto";

function App() {
  return (
    <div id="componente_app">
      <BrowserRouter>
        <div className="App">
          <nav>
            <ul>
              <li>
                <Link to="/">Lista de Produtos</Link>
              </li>
              <li>
                <Link to="/produto/cadastrar">Cadastro de Produto</Link>
              </li>
            </ul>
          </nav>
          <div id="conteudo">
            <Routes>
              <Route path="/" element={<ListarProdutos />} />
              <Route path="/produto/cadastrar" element={<CadastrarProduto />} />
            </Routes>
          </div>
        </div>
        <footer>
          
        </footer>
      </BrowserRouter>
    </div>
  );
}

export default App;
