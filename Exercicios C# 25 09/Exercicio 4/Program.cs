using System.Collections;

ArrayList listaPessoas = new ArrayList();

for (int i = 0; i < 3; i++)
{
    Console.Write($"Digite o nome da pessoa {i + 1}: ");
    string nome = Console.ReadLine();

    Console.Write($"Digite a idade da pessoa {i + 1}: ");
    int idade = int.Parse(Console.ReadLine());

    listaPessoas.Add(new Pessoa(nome, idade));
}

Console.WriteLine("\nLista inicial:");
ExibirLista(listaPessoas);

listaPessoas.Add(new Pessoa("Jaime", 20));
listaPessoas.Add(new Pessoa("Tânia", 18));

Console.WriteLine("\nLista depois de adicionar mais duas pessoas:");
ExibirLista(listaPessoas);

listaPessoas.RemoveAt(listaPessoas.Count - 1);

Console.WriteLine("\nLista depois de remover a ultima pessoa:");
ExibirLista(listaPessoas);

static void ExibirLista(ArrayList lista)
{
    foreach (Pessoa pessoa in lista)
    {
        pessoa.Exibir();
    }
}
