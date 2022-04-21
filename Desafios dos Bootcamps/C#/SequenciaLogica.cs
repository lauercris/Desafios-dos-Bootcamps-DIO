//Sequencia Lógica

/* 
Desenvolva um programa capaz de ler um valor inteiro N. N * 2 linhas de saída vão ser apresentadas na execução do programa, seguindo a lógica do exemplo mais abaixo. Para os valores com mais de seis dígitos, todos os dígitos devem ser apresentados.

Entrada:
O arquivo de entrada contém um número inteiro positivo N (1 < N < 1000).

Saída:
Imprima a saída conforme o exemplo fornecido.
 
Exemplos de Entrada 	Exemplos de Saída

5			1 1 1
			1 2 2
			2 4 8
			2 5 9
			3 9 27
			3 10 28
			4 16 64
			4 17 65
			5 25 125
			5 26 126
*/

using System;

class Program
{
    static void Main() 
    {
	int N = int.Parse(Console.ReadLine());
	int primeiro, segundo, terceiro, quarto, quinto, sexto;

	for(int i = 1; i  <= N; i++)
	{

	    primeiro = i;
            segundo = i * i;
            terceiro = (i * i * i);

            Console.WriteLine(primeiro + " " + segundo + " " + terceiro);

            quarto = i;
            quinto = segundo + 1;
            sexto = terceiro + 1;

            Console.WriteLine(quarto + " " + quinto + " " + sexto);
	}
    }
}
