import React from 'react';
import ListarProdutos from './ListarProdutos';
import CadastrarProduto from './components/pages/produto/CadastrarProduto';


function App() {
  return (
    <div id="component_app">
        <ListarProdutos/>
        <CadastrarProduto/>
    </div>
  );
}

export default App;
