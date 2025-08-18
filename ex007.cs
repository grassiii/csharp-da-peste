int[] nums = new int[5];
int maior = 0;
int menor = 0;
string[] contagem = new string[5] {"primeiro", "segundo", "terceiro", "quarto", "quinto"};

for(int i = 0; i < 5; i++)
{
    Console.Write($"\nDigite o {contagem[i]} número: ");
    nums[i] = int.Parse(Console.ReadLine());
    if (i == 0)
    {
        maior = nums[i];
        menor = nums[i];
    }
    else if(nums[i] > maior)
    {
        maior = nums[i];
    }
    else if(nums[i] < menor)
    {
        menor = nums[i];
    }
}

Console.WriteLine($"Maior número: {maior}\nMenor número: {menor}");