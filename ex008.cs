Console.Write("Digite um número: ");
int num = int.Parse(Console.ReadLine());

for (int i = num; i >= 0; i--)
{
    Console.WriteLine($"{i}. . .");
}