// Création d'un élément réact JSX

const nom = "Beu";
const elementReact = <h2>Bonjour {nom}</h2>;
// rendu avec elementReact
ReactDOM.render(elementReact, document.getElementById('root'));


// // création d'un composant react
// // premier component
function MyFirstComponent() {
    return (
        <h2>Bonjour {nom}</h2>
    )
}
ReactDOM.render(
    // <myFirstComponent></myFirstComponent>,
    <MyFirstComponent />,
    document.getElementById('app')
);


// second component
function MySecondComponent({ nom, prenom }) {
    return (
        <h2>Bonjour {nom} {prenom}</h2>
    )
}
// rendu avec un second component qui attends 2 parametres
ReactDOM.render(
    <MySecondComponent nom="Lelaitier" prenom="Maxouille" />,
    document.getElementById('app2')
);


// création d'un component react avec parametres et utilisaton d'une fonction
const user = { firstname: "Kaaris", lastname: "OkouGnakouri" }
function formatName({ user }) {
    return user.firstname + " " + user.lastname
}
function MyThirdComponent(user) {
    return <h2>Bonjour {formatName(user)}</h2>
}
ReactDOM.render(
    <MyThirdComponent user={user} />,
    document.getElementById('app3')
);


function MyPage() {
    const user = {
        firstname: "aurelien",
        lastname: "leMongolien"
    }
    return (
        <div>
            <MyFirstComponent />
            <MySecondComponent nom="nek" prenom="feu" />
            <MyThirdComponent user={user} />
        </div>
    )
}
ReactDOM.render(
    // <MyPage />,
    <React.StrictMode>
    <MyPage/>    
    </React.StrictMode>,
    document.getElementById('app4')
);
