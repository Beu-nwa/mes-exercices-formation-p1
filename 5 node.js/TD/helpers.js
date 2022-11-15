
//Syntaxe ES5
// const success = (message, data) => {
//     return {
//         message: message,
//         data: data
//     };
// };

// exports.success;


// en ES6
exports.success = (message, data) => { return { message, data } };

// rediriger une fonction qui prends en params une liste et nous retourne le dernier id

exports.getUniqueId = (list) => {
    // recuperation de l'ensemble des clé id de mes objets + stockage dans un tableau
    const coursIds = list.map(cours => cours.id)
    // reduce permet de comparer 2 a 2 les ids, et math.max en retourne le plus grand des 2
    const maxId = coursIds.reduce((a, b) => Math.max(a, b));
    return (maxId + 1);
};

exports.M2iFunction = (port, ipAddress) => {
    return `\n\n\n                             __  __ ____  _                    
                            |  \\/  |___ \\(_)                   
                            | |\\/| | __) | |                   
                            | |  | |/ __/| |                   
                 _____      |_|  |_|_____|_|    _   _             
                |  ___|__  _ __ _ __ ___   __ _| |_(_) ___  _ __  
                | |_ / _ \\| '__| '_ ' _ \\ / _' | __| |/ _ \\| '_ \\ 
                |  _| (_) | |  | | | | | | (_| | |_| | (_) | | | |
                |_|  \\___/|_|  |_| |_| |_|\\__,_|\\__|_|\\___/|_| |_|
                                       \n
                 
                 \n\t\t\tL'application node est démarée\n
                ***************************************************
                 Local\t\t:\thttp://localhost:${port}     
                 on Network\t:\thttp://${ipAddress}:${port}  
                ***************************************************`;
}