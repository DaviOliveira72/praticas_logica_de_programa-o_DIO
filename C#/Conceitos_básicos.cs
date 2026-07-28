using System;

class Program
{
    static void Main()  {
        //declarando variáveis
        
        Console.WriteLine("Digita o nome do seu jogador");

        // Declara uma variável
        string nickname = "Maria mestra do Pikachu";

        // Concatenando uma mensagem fixa + uma variável
        Console.WriteLine("Bem vinda " + nickname);
        Console.WriteLine(nickname + " entrou no servidor");
        



        //Declarando constantes
        
        const string notificacao = "Pokemon Go diz: ";

        Console.WriteLine(notificacao + "tem um novo pokemon na região");
        Console.WriteLine(notificacao + "você foi derrotado por um líder");
        



        //Ajudando a vovó
        
        string poteCafe = "Café Pilão";
        string poteAcucar = "Açúcar Cristal";
        string poteBiscoito = "Biscoito Maizena";

        const string mensagemDaVovo = "Na cozinha da vovó hoje tem: ";

        Console.WriteLine(mensagemDaVovo +
                          poteCafe + " - " +
                          poteAcucar + " - " +
                          poteBiscoito);

        poteCafe = "Café 3 Corações";

        Console.WriteLine(mensagemDaVovo +
                          poteCafe + " - " +
                          poteAcucar + " - " +
                          poteBiscoito);
        



        //Tipos de variáveis
        
        // String
        string nomePokemon = "Pikachu";
        string pokemonSexo = "M";

        // Inteiros
        int nivelPokemon = 20;
        int pontosDeVidaPokemon = 45;

        // Booleano
        bool selecionavel = false;

        Console.WriteLine(nomePokemon);
        Console.WriteLine(pokemonSexo);
        Console.WriteLine(nivelPokemon);
        Console.WriteLine(pontosDeVidaPokemon);
        Console.WriteLine(selecionavel);

    //Vetores e Matriz
    string[] nomesPokemon =
        {
            "Pikachu",
            "Charmander",
            "Bulbassaur"
        };

    object[,] timePokemon =
        {
            {"Pikachu", "M", 1},
            {"Charmander", "F", 3}
        };

    Console.WriteLine(
            "O pokemon " + timePokemon[1,0] +
            " é do sexo " + timePokemon[1,1] +
            " e está no nível " + timePokemon[1,2]
        );
        
    }
}