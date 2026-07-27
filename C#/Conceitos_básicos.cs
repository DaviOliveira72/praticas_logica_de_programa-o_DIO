using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digita o nome do seu jogador");

        // Declara uma variável
        string nickname = "Maria mestra do Pikachu";

        // Concatenando uma mensagem fixa + uma variável
        Console.WriteLine("Bem vinda " + nickname);
        Console.WriteLine(nickname + " entrou no servidor");
    }
}