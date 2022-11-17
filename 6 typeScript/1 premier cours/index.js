"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.hello = void 0;
const message = "world";
// le parametre void indeiquera une fonction qui ne retourne rien
function hello(name = message) {
    return `Hello ${name}`;
    // ici la fonction retourne du string, prends en parametre name de type string avec message comme valeur par défaut
}
exports.hello = hello;
console.log(hello());
console.log(hello("Bébou"));
