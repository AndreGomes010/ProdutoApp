namespace ProdutoApp.Modelos;

public class Produtos(int id, string name, decimal price)
{
    public int Id { get; set; } = id;
    public string Nome { get; set; } = name;
    public decimal Preco { get; set; } = price;

    public override string ToString()
    {
        return $"Código: {Id}, Nome: {Nome}, Preço: {Preco}";
    }
}