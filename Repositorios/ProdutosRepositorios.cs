using ProdutoApp.Modelos;

namespace ProdutoApp.Repositorios;

public class ProdutosRepositorios : IProdutosRepositorios
{
    public List<Produtos> ObterTodosProdutos()
    {
        return new List<Produtos>()
        {
            new Produtos(1, "Coca Cola", 990),
            new Produtos(2, "Pepsi", 890),
            new Produtos(3, "Biscoito Passatempo", 290)
        };
    }
}