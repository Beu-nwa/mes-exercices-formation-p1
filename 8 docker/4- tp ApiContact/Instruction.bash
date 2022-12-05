###
# BACK
###
créer un dockerfile en faisant attention au port du EXPOSE, et au CMD
créer fichier .dockerignore et ajouter .dockerfile
pointer un terminal sur le dossier back_api_node

$ docker build -t back_api_node .     # création de l'image, le point est important
$ docker images
$ docker run --name=back_api_container -dp 7777:7777 back_api_node # création du container issu de l'image
$ docker ps
$ docker exec -it back_api_container bash
$ ls -l
verifier http://localhost:7777/api/contacts
$ exit
###
# FRONT
###
$ docker build -t front_api_react .
$ docker run --name=front_api_container -dp 3000:3000 front_api_react
$ docker exec -it front_api_container bash
verifier http://localhost:3000

# dans le back terminal
$ docker exec -it back_api_container bash
$ cd datas
$ nano savedList.json
# function saveList() {
#    const objectToJson = JSON.stringify(contactList, null, '\t');
#    writeFileSync('./datas/savedList.json', objectToJson);
#    console.log("Données sauvegardées...");
#}
# contactList, null, '\t' permet d'indenter dans le fichier json et donc dans la console.
# pour affecter le changement, il faut supp l'ancienne image et recréer une image back



# création d'un volume pour assurer la persistence des données
$ docker volume create volume_api_contact
$ docker volume ls # lister les volumes
$ docker volume inspect volume_api_contact # retourne les infos d'un volume nommé
$ docker run -d --name=back_api_container -p 7777:7777 -v volume_api_contact:/home/web/public back_api_node