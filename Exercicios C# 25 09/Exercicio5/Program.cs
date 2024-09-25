using System;
using System.Collections.Generic;
using System.Linq;

List<Produto> listaProdutos = new List<Produto>
{
    new Produto("Clips", 3.95m),
    new Produto("Caneta", 5.99m),
    new Produto("Lápis", 4.15m),
    new Produto("Estojo", 6.99m),
    new Produto("Caderno", 7.55m)
};

Console.WriteLine("Lista: \n");
ExibirLista(listaProdutos);

listaProdutos.Add(new Produto("Mochila", 22.44m));
Console.WriteLine("\nLista após adicionar Mochila");
ExibirLista(listaProdutos);


listaProdutos = listaProdutos.OrderBy(p => p.Nome).ToList();
Console.WriteLine("\nLista de produtos ordenada por nome:");
ExibirLista(listaProdutos);


Console.WriteLine("\nProdutos com preço inferior a 5 reais:");
var produtosBaratos = listaProdutos.Where(p => p.Preco < 5.00m);
foreach (var produto in produtosBaratos)
{
    produto.Exibir();
}


var produtoEncontrado = listaProdutos.FirstOrDefault(p => p.Nome == "Estojo");
if (produtoEncontrado != null)
{
    Console.WriteLine("\nProduto encontrado: Estojo");
    produtoEncontrado.Exibir();
}
else
{
    Console.WriteLine("\nProduto 'Estojo' não encontrado");
}

static void ExibirLista(List<Produto> lista)
{
    foreach (var produto in lista)
    {
        produto.Exibir();
    }

    decimal somaTotal = lista.Sum(p => p.Preco);

    // Correção: Média de preços, use 'Average'
    decimal mediaPreco = lista.Average(p => p.Preco);
    int quantidade = lista.Count;

    Console.WriteLine($"\nSoma: R$ {somaTotal:F2}");
    Console.WriteLine($"Média: R$ {mediaPreco:F2}");
    Console.WriteLine($"Quantidade: {quantidade}");
}
