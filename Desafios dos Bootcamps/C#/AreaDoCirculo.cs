//Área do Círculo

/*
A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:

- Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

Entrada:
A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.

Saída:
Apresentar a mensagem "A=" seguido pelo valor da variável area, conforme exemplo abaixo, com 4 casas após o ponto decimal. Utilize variáveis de dupla precisão (double). Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
 
Exemplos de Entrada 	Exemplos de Saída
2.00			A=12.5664

100.64			A=31819.3103

150.00			A=70685.7750
*/

using System;

class Desafio
{
    static void Main()
    {
	double raio, area, area2, pi;
	raio = double.Parse(Console.ReadLine());

	pi =  3.14159;

        area = raio * raio * pi;
        area2 = Math.Round(area, 4);

	Console.WriteLine("A=" + String.Format("{0:0.0000}", area2));
    }
}
