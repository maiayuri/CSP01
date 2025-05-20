namespace Aula_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Estruturas condicionais - decisão");
            double desconto = 0;
            //Será aplicado um desconto de 10% nas compras acima de R$ 200,00
            Console.WriteLine("Informe o valor da compra");
            double valor = Convert.ToDouble(Console.ReadLine());
            if (valor > 200)
            {
                desconto = valor * 0.10;
                Console.WriteLine("Desconto aplicado: " + desconto);
            }
            double valorFinal = valor - desconto;
            Console.WriteLine("valor total da compra R$ " + valorFinal);

            //Verificar se uma pessoa pode votar -> idade >= 16

            int idade;
            Console.WriteLine("Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 16)
                Console.WriteLine("Pode votar");
            else
            {
                Console.WriteLine("Não pode votar");
            }
            */

            /*
             Exercício: Você foi contratado para desenvolver um programa para uma ONG chamada “Solidariedade Sem Fronteiras”. 
             A ONG tem como objetivo ajudar comunidade carente do bairro em que estão inseridos. O estatuto da ONG determina que
             todas as doações recebidas devem gerar um valor para investimento, para cobrir momentos de necessidade. 
             O valor do investimento deve ser de 5% da doação. Porém, em casos em que as doações ultrapassem R$1000,00 o investimento
             deve ser de 10% da doação. Sua missão é criar um programa capaz de fazer os cálculos necessários e indicar
             quanto deve ser investido.

            */

            // Solicita ao usuário o valor da doação
            /*
            double investimento, doacao;
            Console.WriteLine("Informe o valor da doação: ");
            doacao = Convert.ToDouble(Console.ReadLine());

            // Verifica se a doação ultrapassa R$1000,00
            if (doacao > 1000.0)
                investimento = doacao * 0.10; // 10%
            else
                investimento = doacao * 0.05; // 5%
            Console.WriteLine("O valor do investimento será de R$: " + investimento);
            */

            //Calcular a média de um aluno
            //média >= 7 aluno é aprovado, média menos que 4 retido, entre 4 e 7 está de exame
            /*double nota1, nota2, media;
            Console.WriteLine("Nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            media = (nota1 + nota2) / 2;
            if (media >= 7)
                Console.WriteLine("Aprovado com média " + media);
            else if (media < 4)
                Console.WriteLine("Retido com média " + media);
            else
            {
                Console.WriteLine("Deverá realizar o exame, media " + media +
                    "\nInforme a nota do exame: ");

                double notaExame = Convert.ToDouble(Console.ReadLine());
                double mediaExame = (media + notaExame) / 2;
                if(mediaExame >= 6)
                    Console.WriteLine("Aprovado com média " + mediaExame);
                else
                    Console.WriteLine("Reprovado com média " + mediaExame);
            }
            */

            //Usuário deverá digitar o usuário e a senha, se estiver correto, exibir mensagem de boas vindas
            //Caso contrário, enviar mensagem usuário/senha inválidos

            /*string usuario, senha;
            Console.WriteLine("Informe o usuário: ");
            usuario = Console.ReadLine();
            Console.WriteLine("Informe a senha: ");
            senha = Console.ReadLine();
            if (usuario.Equals ("admin") && senha.Equals ("admin123"))
            {
                Console.WriteLine("Bem vindo ao sistema");
            }
            else
            {
                Console.WriteLine("Usuário ou senha inválidos");
            }
            */

            //Exemplo com operador OU (||)
            /*: Faça um programa que receba o total de compras de um usuário e um cupom.
             * Se o total ed compras exceder 1000 ou se o cupom for igual a DESCONTO20,
             * aplicar um desconto de 20% na compra.
             */

            /*uble valorCompra, valorTotal;
            string cupom;
            Console.WriteLine("Valor da compra: R$ ");
            valorCompra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o cupom de desconto, se houver");
            cupom = Console.ReadLine();
            if ((valorCompra > 1000 || cupom.Equals("desconto20")))
                valorTotal = valorCompra * 0.80;
            else
                valorTotal = valorCompra;


            Console.WriteLine("Valor final R$ {0}", valorTotal.ToString("0.00"));
            */

            /*
            Considerar que o usuário vai informar 4 dígitos da placa antiga HIO-9876 você vai exibir o final da placa"
            int placa, digito;
            Console.WriteLine("Informe os dígitos da placa");
            placa = Convert.ToInt32(Console.ReadLine());
            digito = placa % 10;
            Console.WriteLine("O dígito final é " + digito);
            if (digito == 1 || digito == 2)
                Console.WriteLine("Não pode rodar de segunda-feira");
            else if (digito == 3 || digito == 4)
                Console.WriteLine("Não pode rodar de terça-feira");
            else if (digito == 5 || digito == 6)
                Console.WriteLine("Não pode rodar de quarta-feira");
            else if (digito == 7 || digito == 8)
                Console.WriteLine("Não pode rodar de quinta-feira");
            else
                Console.WriteLine("Não pode rodar de sexta-feira");
            */

            /*
            switch (digito) {
            case 1: 
            case 2: Console.WriteLine("Não pode rodar de segunda-feira"); break;
            case 3: 
            case 4: Console.WriteLine("Não pode rodar de terça-feira"); break;
            case 5:
            case 6: Console.WriteLine("Não pode rodar de quarta-feira"); break;
            case 7:
            case 8: Console.WriteLine("Não pode rodar de quinta-feira"); break;
            case 9:
            case 0: Console.WriteLine("Não pode rodar de sexta-feira"); break;
            //default: Console.WriteLine("Opção inválida"); break ;
            */

            /*
            string mes = "mai";
            switch (mes)
            {
                case "jan":
                case "fev":
                case "mar":
                case "abr":
                case "mai":
                case "jun":
                    Console.WriteLine("mes util");
                    break;
                case "jul":
                    Console.WriteLine("ferias");
                    break;
                case "ago":
                case "set":
                case "out":
                case "nov":
                case "dez":
                    Console.WriteLine("mes util");
                    break;
                default:
                    Console.WriteLine("mês invalido");
                    break;

            }
            */

            /*
            double nota = 9.5;
            switch (nota)
            {
                case < 0.0:
                    Console.WriteLine($"nota negativa {nota}");

                    break;
                case > 10:
                    Console.WriteLine($"nota invalida {nota}");
                    break;
                default:
                    Console.WriteLine($"nota valida {nota}");
                    break;
            }
            */

            /*
            Sistema de doação
            1 - Registrar um novo usuário (nome, email, senha, apelido)
            2 - Login (solicitar usuário(email) e a senha (se estiverem corretos, vamos mandar mensagem "Bem vindo ao sistema de doação e
            o nome do usuário, senão usuário/senha inválidos
            3 - Sair - Obrigada(o) por utilizar nosso sistema!
             
             
             */

            //solução com IF ENCADEADO
            string nome, telefone, email, senha, apelido;
            Console.WriteLine("FIAP Donation System!");

            //Criar um menu
            Console.WriteLine("\n 1 - Registrar um novo usuário\n 2 - Logar\n 3 - Sair\n Digite a opção desejada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)  //registrar um novo usuario
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite seu telefone: ");
                telefone = Console.ReadLine();
                Console.WriteLine("Digite seu email: ");
                email = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();
                Console.WriteLine("Digite seu apelido: ");
                apelido = Console.ReadLine();
            }
            else if (opcao == 2)//logar
            {
                //email cadastrado = "admin@fiap.com" senha cadastrada = "admin123
                Console.WriteLine("Digite seu email: ");
                string emailParaLogin = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                string senhaParaLogin = Console.ReadLine();
                if (!string.IsNullOrEmpty(emailParaLogin) && !string.IsNullOrEmpty(senhaParaLogin) &&
                    emailParaLogin.Equals("admin@fiap.com.br") && senhaParaLogin.Equals("admin123"))
                {
                    Console.WriteLine("Bem vindo ao sistema " + emailParaLogin);
                }
                else
                {
                    Console.WriteLine("Usuario e/ou senha inválidos");
                }
                if (!string.IsNullOrEmpty(emailParaLogin) && !string.IsNullOrEmpty(senhaParaLogin) &&
                    emailParaLogin.Equals("admin@fiap.com.br") && senhaParaLogin.Equals("admin123"))
                {
                    Console.WriteLine("Bem vindo ao sistema " + emailParaLogin);
                }
                else
                {
                    Console.WriteLine("Usuario e/ou senha inválidos");
                }
                if (emailParaLogin.Equals("admin@fiap.com.br") && senhaParaLogin.Equals("admin123"))
                    Console.WriteLine("Bem vindo ao sistema " + emailParaLogin);
                else
                    Console.WriteLine("Usuario e/ou senha inválidos");

            }
            else
            {
                Console.WriteLine("Obrigada(o) por utilizar nosso sistema!");
            }
            //Solução com SWITCH()
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite seu nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite seu telefone: ");
                    telefone = Console.ReadLine();
                    Console.WriteLine("Digite seu email: ");
                    email = Console.ReadLine();
                    Console.WriteLine("Digite sua senha: ");
                    senha = Console.ReadLine();
                    Console.WriteLine("Digite seu apelido: ");
                    apelido = Console.ReadLine();
                    break;
                case 2:
                    //email cadastrado = "admin@fiap.com" senha cadastrada = "admin123"
                    Console.WriteLine("Digite seu email: ");
                    string? emailParaLogin = Console.ReadLine();
                    Console.WriteLine("Digite sua senha: ");
                    string? senhaParaLogin = Console.ReadLine();
                    if (emailParaLogin.Equals("admin@fiap.com.br") && senhaParaLogin.Equals("admin123"))
                        Console.WriteLine("Bem vindo ao sistema " + emailParaLogin);
                    else
                        Console.WriteLine("Usuario e/ou senha inválidos");
                    break;
                case 3:
                    Console.WriteLine("Obrigada(o) por utilizar nosso sistema!");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }

            //Operador Ternário
            //condição ? tratamento_condicaoV : tratamentoF;
            double valorCompra = 120;
            double desconto = valorCompra > 200 ? 10 : 0;
            Console.WriteLine($"Desconto aplicado: R$ {desconto}");
        }
    }
}
