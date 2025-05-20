namespace Aula03_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
        * A ONG "Solidariedade Sem Fronteiras" está empenhada em coletar e processar dados para 
        * melhorar suas ações  de apoio às comunidades carentes.
        * Eles precisam de um programa que permita registrar informações sobre as doações recebidas e,
        * em seguida, analisar e apresentar estatísticas sobre essas doações. Você foi convidado a 
        * elaborar este programa, considere os seguintes requisitos:
        */
            double numeroDoacoes, valorDoacao, totalDoacao = 0;
         // 1. Solicitar ao usuário o número de doações recebidas no mês.
            Console.WriteLine("Informe o número de doações recebidas no mês: ");
            numeroDoacoes = double.Parse(Console.ReadLine());

            //2. Para cada doação, solicitar ao usuário o valor doado.
            //3. Calcular e armazenar o valor total das doações recebidas.
            for (int i = 1; i <= numeroDoacoes; i++)
            {
                Console.WriteLine($"Informe o valor da {i}ª doação");
                valorDoacao = double.Parse(Console.ReadLine());
                totalDoacao += valorDoacao;
            }
            
            /* 4. Verificar se o valor total das doações é superior a R$ 10.000,00.
                a) Se for superior, exibir a mensagem "Parabéns! O valor das doações é significativo para a ONG.".
                b) Se for igual ou inferior, exibir a mensagem "O valor das doações precisa ser aumentado para garantir a continuidade dos projetos da ONG.".
            */

            if (totalDoacao > 10000)
                Console.WriteLine("Parabéns! O valor das doações é significativo para a ONG.");
            else
                Console.WriteLine("O valor das doações precisa ser aumentado para garantir a continuidade dos projetos da ONG.");

            double numeroProjetos, valorDoacaoPorProjeto, totalDoacaoProjeto = 0;
            //    5. Solicitar ao usuário o número de projetos que a ONG realizou no mês.
            Console.WriteLine("Informe o número de projetos realizados no mês: ");
            numeroProjetos = double.Parse(Console.ReadLine());
			/* 6. Verificar se o número de projetos é maior ou igual a 3.
				a) Se for maior ou igual a 3, exibir a mensagem "A ONG está realizando um excelente trabalho! Parabéns a toda a equipe.".
				b) Se for inferior a 3, exibir a mensagem "É importante realizar mais projetos para impactar ainda mais vidas.".
			 */
			if (numeroProjetos >= 3)
				Console.WriteLine("A ONG está realizando um excelente trabalho! Parabéns a toda a equipe.");
			else
				Console.WriteLine("É importante realizar mais projetos para impactar ainda mais vidas.");

            // 7. Calcular e armazenar a média de valor das doações recebidas por projeto (valor total das doações dividido pelo número de projetos).
            for (int i = 1; i <= numeroProjetos; i++)
            {
                Console.WriteLine($"Informe o valor da doação do {i}º projeto");
                valorDoacaoPorProjeto = double.Parse(Console.ReadLine());
                totalDoacaoProjeto += valorDoacaoPorProjeto;
            }
            // 8. Exibir a média de valor das doações por projeto com duas casas decimais.
            double mediaDoacaoProjeto = totalDoacaoProjeto / numeroProjetos;
            Console.WriteLine("A média de doações por projeto foi de R$ {0}", mediaDoacaoProjeto.ToString("0.00"));
            // 9. Exibir a quantidade de doações recebidas.
            Console.WriteLine($"Quantidade de doações recebidas foram {numeroDoacoes} ");

			// 10. Exibir o valor total das doações recebidas.
			Console.WriteLine("O total de doações recebidas foi {0} e por projeto foi de R$ {1}",
			   totalDoacao.ToString("0.00"), totalDoacaoProjeto.ToString("0.00"));

            // 11. Encerrar o programa exibindo uma mensagem de agradecimento e encorajamento para a continuidade do trabalho da ONG.
            Console.WriteLine("Agradecemos sua ajuda!");



		}
	}
}
