using ProdutoApp.Modelos;

namespace ProdutoApp.Repositorios;

public interface IProdutosRepositorios
{
    List<Produtos> ObterTodosProdutos();
}