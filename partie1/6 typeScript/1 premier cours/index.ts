const message: string = "world";


// le parametre void indeiquera une fonction qui ne retourne rien
export function hello(name: string = message): string {
    return `Hello ${name}`;
    // ici la fonction retourne du string, prends en parametre name de type string avec message comme valeur par défaut
}

console.log(hello());
console.log(hello("Bébou"));