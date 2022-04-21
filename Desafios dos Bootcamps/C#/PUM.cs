//PUM

/* 
Desenvolva um programa que leia um valor inteiro N. Este N refere-se à quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada:
O arquivo de entrada contém um número inteiro positivo N.

Saída:
Imprima a saída conforme o exemplo fornecido.
 
Exemplos de Entrada 	Exemplos de Saída
7			1 2 3 PUM
			5 6 7 PUM
			9 10 11 PUM
			13 14 15 PUM
			17 18 19 PUM
			21 22 23 PUM
			25 26 27 PUM
*/

using System;

class Program
{
    static void Main() 
    {
	int N = int.Parse(Console.ReadLine());
	int primeiro, segundo, terceiro;
	for(int i = 0; i  < N; i++)
	{
            primeiro = (i * 4) + 1;
            segundo = (i * 4) + 2;
            terceiro = (i * 4) + 3;
            
	    Console.WriteLine(primeiro + " " + segundo + " " + terceiro + " PUM");
        }
    }
}
