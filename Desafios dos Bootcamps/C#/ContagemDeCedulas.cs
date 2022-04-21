//Contagem de Cédulas

/* 
Faça a leitura de um valor inteiro. Em seguida, calcule o menor número de notas possíveis (cédulas) onde o valor pode ser decomposto. As notas que você deve considerar são de 100, 50, 20, 10, 5, 2 e 1. Na sequência mostre o valor lido e a relação de notas necessárias.

Entrada:
Você receberá um valor inteiro N (0 < N < 1000000).

Saída:
Exiba o valor lido e a quantidade mínima de notas de cada tipo necessárias, seguindo o exemplo de saída abaixo. Após cada linha deve ser imprimido o fim de linha.

Exemplo de Entrada 	Exemplo de Saída

576			576
			5 nota(s) de R$ 100,00
			1 nota(s) de R$ 50,00
			1 nota(s) de R$ 20,00
			0 nota(s) de R$ 10,00
			1 nota(s) de R$ 5,00
			0 nota(s) de R$ 2,00
			1 nota(s) de R$ 1,00

11257 			11257
			112 nota(s) de R$ 100,00
			1 nota(s) de R$ 50,00
			0 nota(s) de R$ 20,00
			0 nota(s) de R$ 10,00
			1 nota(s) de R$ 5,00
			1 nota(s) de R$ 2,00
			0 nota(s) de R$ 1,00

503 			503
			5 nota(s) de R$ 100,00
			0 nota(s) de R$ 50,00
			0 nota(s) de R$ 20,00
			0 nota(s) de R$ 10,00
			0 nota(s) de R$ 5,00
			1 nota(s) de R$ 2,00
			1 nota(s) de R$ 1,00

*/

using System;

class Program
{
    static void Main() 
    {
	int n, nota, quociente, resto, nota2, quociente2, nota3, quociente3;
	int nota4, quociente4, nota5, quociente5, nota6, quociente6, nota7, quociente7;

        n = int.Parse(Console.ReadLine());
	Console.WriteLine(n);

	resto = n;

	//Quantidade de notas de 100
	nota = 100;
	quociente = resto / 100;
	Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
	resto = resto % nota;

	//Quantidade de notas de 50
	nota2 = 50;
	quociente2 = resto / 50;
	Console.WriteLine($"{quociente2} nota(s) de R$ {nota2},00");
	resto = resto % nota2;

	//Quantidade de notas de 20
	nota3 = 20;
	quociente3 = resto / 20;
        Console.WriteLine($"{quociente3} nota(s) de R$ {nota3},00");
	resto = resto % nota3;

        //Quantidade de notas de 10    
	nota4 = 10;
	quociente4 = resto / nota4;
	Console.WriteLine($"{quociente4} nota(s) de R$ {nota4},00");
	resto = resto % nota4; 

	//Quantidade de notas de 5
	nota5 = 5;
	quociente5 = resto / nota5;
	Console.WriteLine($"{quociente5} nota(s) de R$ {nota5},00");
	resto = resto % nota5; 

	//Quatidade de notas de 2
	nota6 = 2;
	quociente6 = resto / nota6;
	Console.WriteLine($"{quociente6} nota(s) de R$ {nota6},00");
	resto = resto % nota6;

	//Quantidade de notas de 1
	nota7 = 1;
	quociente7 = resto / nota7;
	Console.WriteLine($"{quociente7} nota(s) de R$ {nota7},00");
    }
}
