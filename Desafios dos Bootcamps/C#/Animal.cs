//Animal

/*
Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas(ver imagem Animal)

Entrada:
A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

Saída:
Imprima o nome do animal correspondente à entrada fornecida.
 
Exemplos de Entrada 	Exemplos de Saída

vertebrado
mamifero		homem
onivoro

vertebrado
ave			aguia
carnivoro

invertebrado
anelideo		minhoca
onivoro
*/

using System;
using System.Text;

class Desafio
{
    static void Main()
    {
	String x = Console.ReadLine(); 
	String y = Console.ReadLine();
	String z = Console.ReadLine();
	if ((x == "vertebrado") && (y == "ave")  && (z == "carnivoro")) 
	{
	    Console.WriteLine("aguia\n");
	}

	if ((x == "vertebrado") && (y == "ave")  && (z == "onivoro")) 
	{
	    Console.WriteLine("pomba\n");
	}

	if ((x == "vertebrado") && (y == "mamifero")  && (z == "onivoro")) 
	{
	    Console.WriteLine("homem\n");
	}

	if ((x == "vertebrado") && (y == "mamifero")  && (z == "herbivoro")) 
	{
	    Console.WriteLine("vaca\n");
	}

	if ((x == "invertebrado") && (y == "inseto")  && (z == "hematofago")) 
	{
	    Console.WriteLine("pulga\n");
	}

	if ((x ==  "invertebrado") && (y == "inseto")  && (z == "herbivoro")) 
	{
	    Console.WriteLine("lagarta\n");
	}
	
	if ((x  == "invertebrado") && (y == "anelideo") && (z == "hematofago"))
	{
  	    Console.WriteLine("sanguessuga\n");
	}

	if ((x  == "invertebrado") && (y == "anelideo") && (z == "onivoro")) 
	{
	    Console.WriteLine("minhoca\n");
	}
    }
}
