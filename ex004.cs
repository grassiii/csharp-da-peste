Console.WriteLine("Digite a temperatura em celsius: ");
int graus_c = int.Parse(Console.ReadLine());
int graus_f = graus_c * 9 / 5 + 32;

Console.WriteLine($"Graus convertido para Fahrenheit: {graus_f}");
