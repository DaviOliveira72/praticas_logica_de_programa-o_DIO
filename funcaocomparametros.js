/*
//torra("pão de integral", 10.90 , "Felipe" ) 
torra("pão de integral", undefined , "Felipe" ) 
//torra("pão de forma",10.90) 
//let nome = "felipe"
//var nome

//function torra(pao, valor, nome = "Cliente") {
function torra(pao, valor = 99.90, nome) {
    //let nome = "felipe"
    //nome = "felipe"
    console.log("torrada feita com "+ pao)
    console.log("pedido por "+ nome)
    console.log("O Valor total é " + valor)
    //console.log(nome)
}

//console.log(nome)
*/

//
createStringConnection("db_products", "felipe", "9876")

function createStringConnection (databaseName, user, pass){
    //não esta funcionando
    //console.log('connect:DBCONNECT;user=${user};pass=${pass};initial_database=${databaseName}')
    console.log("connect:DBCONNECT;user=" + user + ";pass=" + pass + ";initial_database="+ databaseName)
}
