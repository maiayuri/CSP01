namespace Aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notas = new double[3];
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a nota {i + 1} do aluno: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                soma += notas[i];
            }
            Console.WriteLine($"\nMédia do aluno: {soma / notas.Length:0.0}");
        }
    }
}
