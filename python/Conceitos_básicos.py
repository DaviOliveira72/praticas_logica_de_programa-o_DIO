#declarando variáveis
print("Digita o nome do seu jogador")

#Declara uma variável
nickname = "Maria mestra do Pikachu"

# Concatenando uma mensagem fixa + uma variável
print("Bem vinda " + nickname)
print(nickname + " entrou no servidor")



#declarando constantes
# Python não possui constantes verdadeiras.
NOTIFICACAO = "Pokemon Go diz: "

print(NOTIFICACAO + "tem um novo pokemon na região")
print(NOTIFICACAO + "você foi derrotado por um líder")



#Ajudando a vovó
poteCafe = "Café Pilão"
poteAcucar = "Açúcar Cristal"
poteBiscoito = "Biscoito Maizena"

MENSAGEM_DA_VOVO = "Na cozinha da vovó hoje tem: "

print(MENSAGEM_DA_VOVO +
      poteCafe + " - " +
      poteAcucar + " - " +
      poteBiscoito)

poteCafe = "Café 3 Corações"

print(MENSAGEM_DA_VOVO +
      poteCafe + " - " +
      poteAcucar + " - " +
     poteBiscoito)



#Tipos de variáveis
# String
nomePokemon = "Pikachu"
pokemonSexo = "M"

# Inteiros
nivelPokemon = 20
pontosDeVidaPokemon = 45

# Booleano
selecionavel = False

print(nomePokemon)
print(pokemonSexo)
print(nivelPokemon)
print(pontosDeVidaPokemon)
print(selecionavel)

#Vetores e matrizes

nomesPokemon = [
    "Pikachu",
    "Charmander",
    "Bulbassaur"
]

timePokemon = [
    ["Pikachu", "M", 1],
    ["Charmander", "F", 3]
]

print(
    "O pokemon", timePokemon[1][0],
    "é do sexo", timePokemon[1][1],
    "e está no nível", timePokemon[1][2]
)