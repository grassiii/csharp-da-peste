Console.Write("Digite o nome do aluno: ");
string nome = Console.ReadLine();
int[] notas = new int[3];
string[] contagem = new string[7] {"primeira", "segunda", "terceira", "quinta", "sexta", "sétima", "oitava"};
int media = 0;

for(int i = 0; i < 3; i++)
{
    Console.Write($"\nDigite a {contagem[i]} nota de {nome}: ");
    notas[i] = int.Parse(Console.ReadLine());
}
for(int i = 0; i < 3; i++)
{
    media += notas[i];
}
media = media / 3;

Console.Write($"\nAluno: {nome}\nMédia: {media}");