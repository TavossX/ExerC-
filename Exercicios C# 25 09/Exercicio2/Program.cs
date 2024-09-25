string comando = "";
do
{
    Console.Write("Digite o número de valores do Array: ");

    var quantidadeValores = int.Parse(Console.ReadLine());

    int[] valores = new int[quantidadeValores];

    Console.WriteLine("Digite os valores do Array");
    for (int i = 0; i < quantidadeValores; i++)
    {
        Console.Write($"Valor {i + 1}: ");
        valores[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Digite qual valor quer pesquisar?");
    int valorPesquisado;

    while (!int.TryParse(Console.ReadLine(), out valorPesquisado))
    {
        Console.Write("Esse número não existe ");
    }

    bool encontrado = false;
    for (int i = 0; i < valores.Length; i++)
    {
        if (valores[i] == valorPesquisado)
        {
            Console.WriteLine($"O valor {valorPesquisado} é: {i}.");
            encontrado = true;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine($"O valor {valorPesquisado} não foi encontrado.");
    }
    Console.Write("\nDigite 'fim' para sair ou qualquer outra tecla para continuar: ");
    comando = Console.ReadLine().ToLower();
} while (comando != "fim");
