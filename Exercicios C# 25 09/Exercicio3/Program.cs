float[,] notas = new float[2, 5];
float grupo1 = 0, grupo2 = 0;

Console.Write("Digite as notas do Grupo 1\n");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Nota do aluno {i + 1} do Primeiro grupo: \n");
    notas[0,i] = float.Parse(Console.ReadLine());
    grupo1 += notas[0, i];
}

Console.Write("Digite as notas do Grupo 2\n");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Nota do aluno {i + 1} do Segundo grupo: ");
    notas[0, i] = float.Parse(Console.ReadLine());
    grupo2 += notas[0, i];
}

float media1 = grupo1 / 5;
float media2 = grupo2 / 5;

Console.WriteLine($"\nA média do grupo 1 é: {media1}");
Console.WriteLine($"\nA média do grupo 2 é: {media2}");