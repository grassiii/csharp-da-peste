using System;
class ex001{

    static void Main (){

        Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
        Console.WriteLine($"\nNome: {nome}\nIdade: {idade}");

        Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Soma: {n1 + n2}");
    }
}
