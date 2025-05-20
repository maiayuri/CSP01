using System.ComponentModel;
using System.Net;

namespace Aula03
{
    internal class Program
    {
		static void Main(string[] args)
		{

			//Dado um número exibir o fatorial dele
			//4! = 4 * 3 * 2 * 1 = 24
			//5! = 5 * 4 * 3 * 2 * 1 = 120
			int fat = 1;
			Console.WriteLine("Digite o número para calculo do fatorial: ");
			int num = Convert.ToInt32(Console.ReadLine());
			for(int i = num; i > 1; i--)
			{
				fat = fat * i;
			}
			Console.WriteLine($"{num}! = {fat}");
			double x = 1;
			for (; x <= 10; )
			{
				Console.WriteLine(x);
				x++;
			}

			/*
			//Exibir os números pares de 2 até 10
			//  1ºPasso    2ºPasso - 1ªvolta
			//			   2ºPasso - 1ºpasso - a partir da 2ªvolta
			for(int i = 2; i <= 10; i+=2)
				Console.WriteLine(i);

			//Exibir os números múltiplos de 3 de 30 até 3
			Console.WriteLine("-------------------------------" +
				"\nMúltiplos de 3");
			for(int i = 30; i >= 3; i-=3)
				Console.WriteLine(i);
			*/
			/*int soma = 0, num;
			string opcao;
			do
			{
				Console.WriteLine("Digite um valor: ");
				num = Convert.ToInt32(Console.ReadLine());
				soma += num;
				Console.WriteLine("Deseja somar outro valor [Sim]/[Não]");
				opcao = Console.ReadLine();
			} while (opcao.Equals("Sim") || opcao.Equals("sim") || opcao.Equals("S"));
			Console.WriteLine($"Soma = {soma}");
			/*
			 * Exercício 1: Caixa eletrônico 
			Utilizando a estrutura switch case, elabore um programa que leia um valor 
			referente a uma transação bancária de acordo com as opções abaixo:
			1 – Depósito 
			2 – Saque 
			3 – Ver saldo
			4 - Sair
			Lembre-se: o saldo começa com 0 (zero). O programa deve controlar o valor do 
			saldo a cada depósito ou saque. A conta pode ficar negativa. O usuário 
			permanecerá no programa até digitar a opção 4 – sair.
			 */
			/*
			int opcao;
			double valor, saldo = 0;
			do { 
				Console.Clear();
				Console.WriteLine("Bem vindo ao Banco FIAP");
				Console.WriteLine("\nOperações disponíveis neste caixa:" + "\n\n1 - Depósito" +
								  "\t\t2 - Saque" + "\n3 - Consultar Saldo\t4 - Sair");
				Console.WriteLine("Opção: ");
				opcao = Convert.ToInt32(Console.ReadLine());
				switch (opcao)
				{
					case 1:
						Console.WriteLine("Depósito\n---------------------------------" +
							"\nInforme o valor a ser depositado: ");
						valor = Convert.ToDouble(Console.ReadLine());
						saldo += valor;
						break;
					case 2:
						Console.WriteLine("Saque\n---------------------------------" +
							"\nInforme o valor a ser sacado: ");
						valor = Convert.ToDouble(Console.ReadLine());
						saldo -= valor;
						break;
					case 3:
						Console.WriteLine("Extrato\n---------------------------------" +
							$"\nSaldo atual: R$ {saldo}");
						Thread.Sleep(2000);
						break;
					case 4: Console.WriteLine("Obrigada por utilizar nosso sistema!"); break;
				} //fechando o switch
			} while (opcao != 4);
			*/
			/*
			int idade, media, somaIdade = 0, qtdAlunos;
			//Inicialização
			qtdAlunos = 1;
			Console.WriteLine("Qual a quantidade de alunos? ");
			int alunos = Convert.ToInt32(Console.ReadLine());
			//Laços condicionais => while (enquanto)
			do
			{
				Console.WriteLine($"Digite a idade do {qtdAlunos}º aluno: ");
				idade = Convert.ToInt32(Console.ReadLine());
				somaIdade += idade;
				//Mudança da variável de controle /incremento/decremento/leitura
				qtdAlunos++;
			} while (qtdAlunos <= alunos);
			media = somaIdade/5;
			Console.WriteLine("A média de idade dos alunos da escola é: " + media);
			*/
			/*
			//Inicialização
			qtdAlunos = 1;
			Console.WriteLine("Qual a quantidade de alunos? ");
			int alunos = Convert.ToInt32(Console.ReadLine());
			//Laços condicionais => while (enquanto)
			while (qtdAlunos <= alunos)
			{
				Console.WriteLine($"Digite a idade do {qtdAlunos}º aluno: ");
				idade = Convert.ToInt32(Console.ReadLine());
				somaIdade += idade;
				//Mudança da variável de controle /incremento/decremento/leitura
				qtdAlunos++;
			}
			media = somaIdade / 5;
			Console.WriteLine("A média de idade dos alunos da escola é: " + media);
			*/
		}
	}
}
