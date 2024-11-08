using ProdutoApp.Modelos;

namespace ProdutoApp.Servicos;

public interface IProdutosServices
{
    List<Produtos> ObterTodosProdutos();
}