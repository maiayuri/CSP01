
using Microsoft.Win32;
using System.ComponentModel;

namespace Aula05
{
    internal class Program
    {
        //PROCEDIMENTO - FUNÇÃO SEM RETORNO
        //public static void nomeProcedimento(){}
        public static void ExibirMenu()
        {
			Console.WriteLine("Boas vindas ao FIAP Donation System!");
			Console.WriteLine("Digite 1 para registrar um novo usuário");
			Console.WriteLine("Digite 2 para se logar");
			Console.WriteLine("Digite 3 para finalizar o sistema");
		}

		public static void RegistrarUsuario()
		{
			Console.Write("Digite o nome do usuário que deseja registrar: ");
			string nomeDoUsuario = Console.ReadLine()!;
			Console.Write("Digite o telefone do usuário: ");
			string telefoneDoUsuario = Console.ReadLine()!;
			Console.Write("Digite o e-mail do usuário: ");
			string emailDoUsuario = Console.ReadLine()!;
			Console.Write("Digite a senha do usuário: ");
			string senhaDoUsuario = Console.ReadLine()!;
			Console.Write("Digite o apelido do usuário: ");
			string apelidoDoUsuario = Console.ReadLine()!;
			Console.WriteLine($"\n\nO usuário {nomeDoUsuario} foi registrado com sucesso!");

		}



		static void Main(string[] args)
        {
			int op;
			do
			{
				ExibirMenu();
				op = Convert.ToInt32(Console.ReadLine);
				switch (op)
				{
					case 1:
						RegistrarUsuario();
						break;
					case 2: break;
					case 3: Console.WriteLine("Obrigada por utilizar nosso sistema"); break;
				}
			} while (op != 3);
			




		}
	}
}
