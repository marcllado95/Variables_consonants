var x = 1948; z = 4; // Cada z anys hi ha un any de traspàs

var y = (1995 - x) /z;
y = Math.floor(y);   // Math.floor arrodoneix cap abaix

console.log("Entre 1948 i 1995 hi ha " + y + " anys de traspàs");