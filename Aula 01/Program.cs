//Entrada - Saída - Processamento

//Saída:Comunicação entre o sistema e o usuário
/*
 * Comentário
 * de várias linhas
 */

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Bem vindos a imersão C#-Pro");

//Variável de memória: é um espaço na memória RAM para armazenar informações
//tipo nomeVariavel;
using System.Numerics;

int idade;

//Entrada de dados
//variável = Console.ReadLine();
/*Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
idade = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(nome + " sua idade é " + idade);
*/
//Processamento => atribuição
idade = 40;

//Processamento => cálculos 
//variavel = var/valor operadorAritmético var/valor
// + - * / % (módulo => resto da divisão inteira)
/*int a, b;
double resultado;
a = 5;
b = 2;
double c = 5.0;

resultado = a + b;
Console.WriteLine("Soma = " + resultado);

resultado = a / b;
Console.WriteLine("Divisão = " + resultado);

resultado = c / b;
Console.WriteLine("Divisão = " + resultado);

resultado = a % b;
Console.WriteLine("Resto da divisão (módulo) = " + resultado);

//   {[()]}  =>  ((()))
int i = 0;
i++; //Soma 1 na variável
i--; //Subtrai 1 da variável


resultado = a + i++;
Console.WriteLine("Resultado = " + resultado);
Console.WriteLine("i = " + i);


Console.WriteLine("Resultado = " + resultado);
Console.WriteLine("i = " + i);

//+=   -=  *=  /=   %=
resultado += a; // resultado = resultado + a;
*/
/*Elaborar um programa que exiba a média de um aluno que fez duas provas*/
/*double nota1, nota2, media;
Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());
media = (nota1 + nota2) / 2;
Console.WriteLine("Média = " + media);
*/
/*1 e 2 segunda */
/*Considerar que o usuário vai informar 4 dígitos da placa antiga HIO-9876 você vai exibir o final da placa" */
/*
int placa, digito;
Console.WriteLine("Informe os dígitos da placa");
placa = Convert.ToInt32(Console.ReadLine());
digito = placa % 10;
Console.WriteLine("O dígito final é " + digito);
*/
/*
	Caixa eletrônico: 50, 20, 10
	Sacar um valor: 180
	Quantidade de notas de R$ 50: 3
	Quantidade de notas de R$ 20: 1
	Quantidade de notas de R$ 10: 1
 */

int valor;
Console.WriteLine("Informe o valor do saque: ");
valor = Convert.ToInt32(Console.ReadLine());

int q50 = valor / 50;
Console.WriteLine("Quantidade de notas de R$ 50: " + q50);
valor = valor % 50;
int q20 = valor / 20;
Console.WriteLine("Quantidade de notas de R$ 20: " + q20);
valor %= 20;
int q10 = valor / 10;
Console.WriteLine("Quantidade de notas de R$ 10: " + q10);


Console.WriteLine("Teste do git");





