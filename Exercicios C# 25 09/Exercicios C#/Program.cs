using System;
using System.Linq;
using System.Collections.Generic;
//Criando a lista de frutas.
List<string> frutas = new List<string>() {"Maçã", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"};

//A) Mostrando a segunda fruta
string elemento = frutas[1];
Console.WriteLine("--Segunda fruta--\n\n" + elemento);
Console.WriteLine("\n==========================\n");

//A) Mostrando penultima fruta
if (frutas.Count >= 2)
{
    string penultimaFruta = frutas[frutas.Count - 2];
    Console.WriteLine("--Penúltima fruta-- \n\n" + penultimaFruta);
}
Console.WriteLine("\n==========================\n");

//B) Mudando a terceira e ultima fruta para Kiwi e Caqui
var indices = new List<int> { 2, 9 };
var novasFrutas = new List<string> { "Kiwi", "Caqui" };

for (int i = 0; i < indices.Count; i++)
{
    int indice = indices[i];
    string novaFruta = novasFrutas[i];
    if (indice >= 0 && indice < frutas.Count)
    {
        frutas[indice] = novaFruta;
    }
}

//B) Exibindo Lista de frutas
Console.WriteLine("Lista de Frutas---------");
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}
Console.WriteLine("\n==========================\n");

//C) Exibir nome das frutas
foreach(var fruta in frutas)
{
    Console.WriteLine(fruta);
}
//C) Quantidade de Frutas
Console.WriteLine("Quantidade de elementos no Array\n" + frutas.Count);

//D) Lista em ordem crescente
frutas.Sort();

//E) Mostrando a Lista em ordem inversa
frutas.Reverse();
Console.WriteLine(String.Join(',',frutas));