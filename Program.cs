namespace Aula02Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            // (medido em Km/ l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            // consumido para percorrê-la(medido em l).

            double distanciaTotal, volumeCombustivel, consumoMedio;

            // Comando para leitura da quilometragem;
            Console.Write("Digite a distância total percorrida (em km): ");
            distanciaTotal = double.Parse(Console.ReadLine());

            // Comando para leitura de litros;
            Console.Write("Digite o volume de combustível consumido (em litros): ");
            volumeCombustivel = double.Parse(Console.ReadLine());

            consumoMedio = distanciaTotal / volumeCombustivel;

            Console.WriteLine("O consumo médio do automóvel foi de: " + consumoMedio.ToString("F2") + " km/l.");
        }
    }
}