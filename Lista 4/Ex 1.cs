using System;

class Program 
{
    static void Main(string[] args) {
        //Declarando a variavel
        int n;

        //Lendo os dados 
        Console.WriteLine("Digite o número de alunos:");
        n = int.Parse(Console.ReadLine());

        //Entrando no laço de repetição, iniciei i com 1 para ficar mais coeso 
        for (int i = 1; i <= n; i++) {
            Console.WriteLine("Aluno " + i + ":");
            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Tipo de média (A/P): ");
            char letra = char.Parse(Console.ReadLine());

            //Chamando o procedimento
            calcularMedia(nota1, nota2, nota3, letra);
        }
    }

    //Criando o procedimento 
    static void calcularMedia(double nota1, double nota2, double nota3, char letra) 
    {
        double media;
        
        //Condição para media aritmética
        if (letra == 'A') 
        {
            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Média aritmética: {0:f2}", media);
        }
        //Condição para media ponderada
        else if (letra == 'P') 
        {
            media = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
            Console.WriteLine("Média ponderada: {0:f2}", media);
        }
        else 
        {
            Console.WriteLine("Tipo de média inválido!");
        }
    }
}
