var nom = "Marc", cognom1 = "Lladó", cognom2 = "Maldonado";
var dia = 9, mes = 1, any = 1995;

var nomcomplet = nom + " "+ cognom1 + " " + cognom2;
var naixement = dia + "/" + mes + "/" + any;

console.log("El meu nom és " + nomcomplet);
console.log("Vaig néixer el " + naixement);

if(any % 4 == 0)
    console.log("El meu any de naixement és de traspàs");

else
    console.log("El meu any de naixement NO és de traspàs");