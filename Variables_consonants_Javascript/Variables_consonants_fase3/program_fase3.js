var x = 1948;

for( var i = x; i <= 1995; i++){
    
    var bisi = false;

    if(i % 4 == 0)
        bisi = true;

    if(bisi)
        console.log(i + " és de traspàs");
    else
        console.log(i + " NO és de traspàs");
}