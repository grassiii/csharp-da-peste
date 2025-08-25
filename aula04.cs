using System;

public class aula04
{
    public class Aluno
    {
        public string Nome {get; set;}
        public string Matricula {get; set;}
        private float[] Notas = new float[2];
        public float Media {get; set;}
        public string Status {get; set;}

        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota: ");
            Notas[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            Notas[1] = float.Parse(Console.ReadLine());
            Media = (Notas[0]+ Notas[1]) / 2;
            if (Media >= 7){Status = "Aprovado";}
            else{Status = "Reprovado";}
        }

        public void MostrarDados()
        {
            Console.Write($"Nome: {Nome}\nMatrícula: {Matricula}");
            Console.Write($"\nMédia: {Media}\nStatus: {Status}");
        }
    }

    public static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno("Gustavo", "123456");
        aluno1.CalcularMedia();
        aluno1.MostrarDados();
    }
}