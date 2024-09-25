public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void Exibir()
    {
        Console.WriteLine($"Produto: {Nome}, Preço: R$ {Preco}");
    }
}
