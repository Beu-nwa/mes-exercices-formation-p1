######################################################################
#				Tp2 - Conteneur Web
######################################################################

--commencer par ouvrir l appli docker--

## => Démarer un conteneur nommé "My_httpd" en tache de fond à partir de l'image httpd:latest (ne pas oublier le mapping des ports)
$ docker run --name=My_httpd -dp 8080:80 httpd:latest
container nommé: 8d95caf8752456b752ac7fe9c94bb5314f668b9373af4ed6c26ec4cbcc84319a
## => Se connecter au bash du conteneur
$ docker container exec -ti 8 bash
## => mise à jour de ce conteneur
$ apt update && apt upgrade -y && apt install nano -y
## => Vérifier sur "http://localhost:8080/" que le message s'affiche bien
ok
## => Changez le message retourné par le serveur web: /usr/local/apache2/htdocs/index.html
$ cd htdocs
$ cat index.html   # retourne: <html><body><h1>It works!</h1></body></html>
$ nano index.html  
^X puis yes pour quitter sauvegarder
## => Vérifier sur "http://localhost:8080/" que le nouveau message s'affiche bien
refresh de la page et c ok
## => Proceder à l'installation de git
$ exit
$ docker container exec -ti 8 bash
$ apt-get install -y git
## => Vérifier son installation avec la commande git --version
$ git --version