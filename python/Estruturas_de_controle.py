#Estrutura if, else if e else
caminhoEsquerdo = "obstaculo"

if caminhoEsquerdo == "obstaculo":
    print("Seguindo caminho da direita")
elif caminhoEsquerdo == "ponteQuebrada":
    print("Procurando outro caminho")
else:
    print("Seguindo caminho da esquerda")


possuiOvos = True
itensComprados = ""

if possuiOvos:
    itensComprados = "Leite"
else:
    print("Passou na sessão de congelados")
    itensComprados = "Lasanha congelada"

print("Item comprado:", itensComprados)


nivelDeFome = 1

if nivelDeFome == 1:
    print("Pouca fome")
elif nivelDeFome == 2:
    print("Muita fome")
else:
    print("Você comeria mais que o Pica-Pau")



#Switch Case
dia = "terça"

match dia:
    case "segunda":
        print("Dia de começar a semana com energia!")
    case "terça":
        print("Hora de aprender coisas novas!")
    case "quarta":
        print("Metade da semana, continue firme!")
    case "quinta":
        print("Quase lá!")
    case "sexta":
        print("Fim de semana chegando!")
    case _:
        print("Final de semana!")


numeros = [1, 2, 3, 4, 5]

for numero in numeros:
    print(numero)


import random

jogadas = 0
cara = False

while not cara:
    jogadas += 1
    cara = random.random() < 0.5

print(f"A moeda caiu cara após {jogadas} jogadas!")


#Do While
while True:
    numero = int(input("Digite um número entre 1 e 10: "))

    if 1 <= numero <= 10:
        break

print(f"Você digitou o número {numero}.")


for contador in range(1, 6):
    print(contador)


import random

dado = 0

while dado <= 4:
    dado = random.randint(1, 6)
    print("Você tirou um", dado)


bolinhosComidos = 0

while True:
    bolinhosComidos += 1
    print(f"Você comeu {bolinhosComidos} bolinhos!")

    if bolinhosComidos >= 5:
        break