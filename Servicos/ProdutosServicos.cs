using ProdutoApp.Modelos;
using ProdutoApp.Repositorios;

namespace ProdutoApp.Servicos;

public class ProdutosServicos : IProdutosServices
{
    private readonly IProdutosRepositorios _produtosRepositorios;

    public ProdutosServicos(IProdutosRepositorios produtosRepositorios)
    {
        _produtosRepositorios = produtosRepositorios;
    }

    public List<Produtos> ObterTodosProdutos()
    {
        return _produtosRepositorios.ObterTodosProdutos();
    }
}
