//Estrutura if, else if e else
string caminhoEsquerdo = "obstaculo";

if (caminhoEsquerdo == "obstaculo")
{
    Console.WriteLine("Seguindo caminho da direita");
}
else if (caminhoEsquerdo == "ponteQuebrada")
{
    Console.WriteLine("Procurando outro caminho");
}
else
{
    Console.WriteLine("Seguindo caminho da esquerda");
}



bool possuiOvos = true;
string itensComprados = "";

if (possuiOvos)
{
    itensComprados = "Leite";
}
else
{
    Console.WriteLine("Passou na sessão de congelados");
    itensComprados = "Lasanha congelada";
}

Console.WriteLine("Item comprado: " + itensComprados);



int nivelDeFome = 1;

if (nivelDeFome == 1)
{
    Console.WriteLine("Pouca fome");
}
else if (nivelDeFome == 2)
{
    Console.WriteLine("Muita fome");
}
else
{
    Console.WriteLine("Você comeria mais que o Pica-Pau");
}



//Switch Case
string dia = "terça";

switch (dia)
{
    case "segunda":
        Console.WriteLine("Dia de começar a semana com energia!");
        break;

    case "terça":
        Console.WriteLine("Hora de aprender coisas novas!");
        break;

    case "quarta":
        Console.WriteLine("Metade da semana, continue firme!");
        break;

    case "quinta":
        Console.WriteLine("Quase lá!");
        break;

    case "sexta":
        Console.WriteLine("Fim de semana chegando!");
        break;

    default:
        Console.WriteLine("Final de semana!");
        break;
}



int[] numeros = {1,2,3,4,5};

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}



Random random = new Random();

int jogadas = 0;
bool cara = false;

while (!cara)
{
    jogadas++;
    cara = random.NextDouble() < 0.5;
}

Console.WriteLine($"A moeda caiu cara após {jogadas} jogadas!");



int numero;

do
{
    Console.Write("Digite um número entre 1 e 10: ");
    numero = int.Parse(Console.ReadLine());

} while (numero < 1 || numero > 10);

Console.WriteLine($"Você digitou o número {numero}");



for (int contador = 1; contador <= 5; contador++)
{
    Console.WriteLine(contador);
}



Random random = new Random();

int dado = 0;

while (dado <= 4)
{
    dado = random.Next(1, 7);
    Console.WriteLine("Você tirou um " + dado);
}



int bolinhosComidos = 0;

do
{
    bolinhosComidos++;
    Console.WriteLine($"Você comeu {bolinhosComidos} bolinhos!");

} while (bolinhosComidos < 5);