import { stdin, stdout} from 'process';
import readline from 'readline';

export const askQuestion = async (message) => {
    console.log(message);
    const readlineinterface = readline.createInterface({
        input: stdin,
        output: stdout
    })
    const result = await( await readlineinterface[Symbol.asyncIterator]().next()).value
    readlineinterface.close();
    return result
}
