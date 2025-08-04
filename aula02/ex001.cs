using System;
class ex001{

    static void Main (){

        Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
        Console.WriteLine($"Nome: {nome}\nIdade: {idade}");
    }
}
