namespace AulaFuncao
{
    internal class Program
    {
		//Variável global
		//public static tipo nomeVariavel;
		public static string emailDoUsuario, senhaDoUsuario;
		public static List<string> produtos = new List<string>();
		public static double[] precoProdutos = new double[10];


		public static double SomarValorCarrinho(double[] valores)
		{
			double soma = 0;
			for (int i = 0; i < valores.Length; i++)
			{
				soma += valores[i];
			}
			return soma;
		}
		public static void RegistrarProduto()
		{
			//prods[0] = Console.ReadLine();
			Console.Clear();
			ExibirTituloOpcao("Registro de produto");
			Console.WriteLine("Digite o nome do produto");
			string nomeProduto = Console.ReadLine();
			produtos.Add(nomeProduto);
			Console.WriteLine("Digite o preço do produto");
			precoProdutos[produtos.Count - 1] = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine($"\nO produto {nomeProduto} foi cadastrado com sucesso!");
		}



		public static void ExibirMenu()
		{
			Console.WriteLine("Boas vindas ao FIAP Donation System!");
			Console.WriteLine("Digite 1 para registrar um novo usuário");
			Console.WriteLine("Digite 2 para se logar");
			Console.WriteLine("Digite 3 para finalizar o sistema");
		}

		public static void SubMenu()
		{
			Console.Clear();
			Console.WriteLine("\nDigite 1 para registrar um produto");
			Console.WriteLine("Digite 2 para mostrar os produtos");
			Console.WriteLine("Digite 3 para avaliar um produto");
			Console.WriteLine("Digite 4 para exibir a média de um produto");
			Console.WriteLine("Digite 0 para voltar para o menu principal");

		}

		public static void RegistrarUsuario()
		{
			ExibirTituloOpcao("Cadastro de usuário");
			Console.Write("Digite o nome do usuário que deseja registrar: ");
			string nomeDoUsuario = Console.ReadLine()!;
			Console.Write("Digite o telefone do usuário: ");
			string telefoneDoUsuario = Console.ReadLine()!;
			Console.Write("Digite o e-mail do usuário: ");
			emailDoUsuario = Console.ReadLine()!;
			Console.Write("Digite a senha do usuário: ");
			senhaDoUsuario = Console.ReadLine()!;
			Console.Write("Digite o apelido do usuário: ");
			string apelidoDoUsuario = Console.ReadLine()!;
			Console.WriteLine($"\n\nO usuário {nomeDoUsuario} foi registrado com sucesso!");

		}
		public static void testeLista()
		{
			produtos.Add("Ana");
			produtos.Add("Maria");
			produtos.Add("Jose");
			produtos.Contains("Maria");
			produtos.RemoveAt(2);
			produtos.Sort();
		}


		//public static void NomeProcedimento(Parametros) => Recebe parâmetros
		public static void ExibirTituloOpcao(string texto)
		{
			int quantidadeDeLetras = texto.Length;
			string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
			Console.WriteLine(astericos);
			Console.WriteLine(texto);
			Console.WriteLine(astericos + "\n");

		}

		public static String ExibirProdutos()
		{
			string mensagem = "";
			Console.Clear();
			ExibirTituloOpcao("Listando os produtos registrados");
			foreach (string prod in produtos)
			{
				mensagem += prod + "\n";
			}
			return mensagem;
		}
		public static String ExibirProdutosEPrecos()
		{
			string mensagem = "";
			Console.Clear();
			ExibirTituloOpcao("Listando os produtos registrados");
			for(int i = 0; i < produtos.Count; i++)
			{
				mensagem += produtos[i] + " - R$ "  + precoProdutos[i] + "\n";
			}
			return mensagem;
		}

		//Função => tem um retorno (string, int, array, bool)
		public static bool ValidarUsuario(string user, string pass)
		{
			if (user.Equals(emailDoUsuario) && senhaDoUsuario.Equals(pass)) {
				return true;
			}
			return false;
		}

		//.Net 9
		public static void ImprimirValores(params Span<int> valores)
		{
			foreach (int i in valores)
			{
				Console.WriteLine(i);
			}

		}

		
		//Retorno  nomeFuncao
		List<int> GerarNumeros() => [1, 2, 3, 4];


		//Até a versão 8.0
		public static void ImprimirValoresParams(params int[] valores)
		{
			foreach (int i in valores)
			{
				Console.WriteLine(i);
			}
		}
		public static string CalcularMedia(params double[] notas)
		{
			return notas switch
			{
				[] => "Nenhuma nota fornecida",
				[< 0 or > 10, ..] => "Nota inválida",
				_ => $"Média do aluno: {notas.Sum() / notas.Length:0.00}"
			};
		}
		static void Main(string[] args)
        {
			double[] notas = [7.5, 8.0, 6.5];
			Console.WriteLine(CalcularMedia(notas));
		

			ImprimirValores(1,2,3,4, 5, 6);
			int op = 0, opSubMenu;
			double[] valores = new double[10];
		string usuario, senha;
			do
			{
				ExibirMenu();
				op = Convert.ToInt32(Console.ReadLine());
				switch (op)
				{
					case 1:
						RegistrarUsuario();
						break;
					case 2:
						Console.WriteLine("Digite seu usuário: ");
						usuario = Console.ReadLine();
						Console.WriteLine("Digite sua senha: ");
						senha = Console.ReadLine()!;
						
						if (ValidarUsuario(usuario, senha))
						{
							do
							{
								Console.WriteLine("Bem vindo ao sistema!");
								SubMenu();
								opSubMenu = Convert.ToInt32(Console.ReadLine());
								switch (opSubMenu)
								{
									case 1: RegistrarProduto(); break;
									case 2:
										Console.Clear();
										ExibirTituloOpcao("Listando os produtos registrados");
										foreach(string prod in produtos) {
											Console.WriteLine(prod);
										}
										break;
										case 3: Console.WriteLine("Soma = " + SomarValorCarrinho(valores));
										break;
								}
							} while(opSubMenu != 0);

						}
						else
						{
							Console.WriteLine("Usuário e/ou senha inválidos");
						}
							break;
					case 3: Console.WriteLine("Obrigada por utilizar nosso sistema"); break;
				}
			} while (op != 3);
		}
    }
}
