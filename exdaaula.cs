public class Aluno {

    public string Nome {get; set;}
    public int Nota1 {get; set;}
    public int Nota2 {get; set;}
    public string Status {get; set;}

    public Aluno(string nome, int nota1, int nota2){
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
    }

    public void Validar_aluno(){
        if (((Nota1 + Nota2) / 2) >= 7)
        {
            Status = "Aprovado";
        }
        else
        {
            Status = "Reprovado";
        }
    }
}

public class Program{
    public static void Main(string[] args){

        Aluno aluno1 =  new Aluno("Gustavo", 70, 60);
        aluno1.Validar_aluno;
        Console.Write(aluno1.Status);
    }
}