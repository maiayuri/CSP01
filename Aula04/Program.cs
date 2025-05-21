namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estrutura de dados homogênea - Vetores");
            int[] idades = new int[5];
            int[] numeros = { 10, 20, 30, 40, 50 };
            string[] nomes = new string[5];

            idades[0] = 46;

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Informe a idade do aluno: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }

			for (int i = 0; i < idades.Length; i++)
			{
				Console.WriteLine($"A idade do aluno{i+1} aluno é {idades[i]}: ");
			
			}


		}
    }
}
