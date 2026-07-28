//Estruturas condicionais (if, else if, else)

// O nosso herói João chegou a uma encruzilhada na floresta misteriosa.
// Ele precisa decidir qual caminho seguir para continuar a sua jornada.

if (caminhoEsquerdo === "obstaculo") {
    // Se o caminho da esquerda tiver um obstáculo,
    // João vai tentar o caminho da direita.
    seguirCaminhoDireito();

} else if (caminhoEsquerdo === "ponteQuebrada") {
    // Se o caminho da esquerda tiver uma ponte quebrada,
    // João vai procurar outro caminho.
    procurarOutroCaminho();

} else {
    // Se não tiver obstáculo nem ponte quebrada,
    // João seguirá por esse caminho.
    seguirCaminhoEsquerdo();
}



let possuiOvos = true
let itensComprados = ""

if(possuiOvos){
itensComprados = "Leite"
}
else{
console.log("passou na sessão de congelados")
itensComprados = "Lasanha congelada"
}

console.log("item comprado: " + itensComprados)


//if,else if ,else
let nivelDeFome =  "1"

if(nivelDeFome === 1){
console.log("pouca fome")
}else if(nivelDeFome ===2){
console.log("muita fome")
}else{
console.log("Você comeria mais que o pica pau")
}



//Estrutura Switch Case
let dia = "terça"; // Você pode mudar isso para outros dias

switch (dia) {
  case "segunda":
    console.log("Dia de começar a semana com energia!");
    break;
  case "terça":
    console.log("Hora de aprender coisas novas!");
    break;
  case "quarta":
    console.log("Metade da semana, continue firme!");
    break;
  case "quinta":
    console.log("Quase lá, um pouco mais de esforço!");
    break;
  case "sexta":
    console.log("Dia de comemorar, o fim de semana está chegando!");
    break;
  default:
    console.log("Final de semana! Descanse e divirta-se!");
}



//Estruturas de repetição (for, while, do-while)
const numeros = [1, 2, 3, 4, 5];

for(let i = 0; i < numeros.length; i++) {
  console.log(numeros[i]);
}



let jogadas = 0;
let cara = false;

while(!cara) {
  jogadas++;
  cara = Math.random() < 0.5;
}

console.log(`A moeda caiu cara após ${jogadas} jogadas!`);



let numero;

do {
  numero = prompt('Digite um número entre 1 e 10:');
} while(numero < 1 || numero > 10);

console.log(`Você digitou o número ${numero}.`);



for (let contador = 1; contador <= 5; contador++) {
  console.log(contador);
}


let dado = 0;

while (dado <= 4) {
  dado = Math.floor(Math.random() * 6) + 1;
  console.log("Você tirou um", dado);
}



let bolinhosComidos = 0;

do {
  bolinhosComidos++;
  console.log("Você comeu", bolinhosComidos, "bolinhos!");
} while (bolinhosComidos < 5);
