using ProdutoApp.Modelos;
using ProdutoApp.Repositorios;
using ProdutoApp.Servicos;

IProdutosRepositorios produtosRepositorios = new ProdutosRepositorios();
IProdutosServices produtosServices = new ProdutosServicos(produtosRepositorios);

List<Produtos> produtos = produtosServices.ObterTodosProdutos();

Console.WriteLine("Lista de Produtos:");

foreach (var item in produtos)
{
    Console.WriteLine(item);
}