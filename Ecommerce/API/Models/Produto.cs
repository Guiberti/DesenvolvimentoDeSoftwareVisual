using System;

namespace API.Models;

public class Produto
{
    //Atributos|Propriedades|Caracteristicas

    //Como nós fazemos em JAVA
    /*     private string nome;

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = "Nome: " + nome + " " + DateTime.Now;
        }
     */


    //C#

    //Construtor


    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;

    }

    public String Id { get; set; }

    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }
    public DateTime CriadoEm { get; set; }


}
