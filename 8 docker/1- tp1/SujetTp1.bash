######################################################################
#				Tp1 - Premier conteneur Debian
######################################################################

## => Démarer un conteneur à partir d'une image debian:latest
## => Se connecter au bash du conteneur
## => mise à jour de ce conteneur
## => Installer l'editeur nano (vim)
## => Ecrire un fichier texte contenant du texte nommé text.txt
## => Afficher le contenu du fichier texte.txt

# -ti  -t crée un terminal et i l'integrate

$ docker search debian --filter "is-official=true" # recherche l'image debian en affichant suelement les images officelles
$ docker run -ti debian # cré un container à partir de l'image debian
$ mkdir text.txt # cré un dossier .txt
$ cd texte.txt # se placer dedans
$ exit  # pour en sortir
$ docker container ls -a # verifier si le container a bien été lancé
$ docker start 2 # relance le container dont l'id commence par 2
$ docker container exec -ti 2 bash # acceder au container
$ apt update # telecharge la liste des fichiers
$ apt upgrade # 
$ apt install nano
$ ls -l # verifie le contenu
$ cd text.txt # se placer dans le dossier "text.txt"
$ nano text.txt # crée un fichier (ou se place dans un fichier existant) nommé text.txt et nous place dedans, on peut alors l'editer
# nb quand on fait exit il demande si on save les changements et de valider le nom
$ cat text.txt # affiche le contenu du fichier text.txt
$ exit
$ docker ps # voir les containers in run
$ docker stop 2
$ docker rm 2 # supp le container commencant par 2
