# init un projet node
$ npm init 

# index.js

#dockerfile

# docker build -t <nom_image>
$ docker build -t node_server .

$ docker images


docker run --name=node_server_container -dp 8080:80 node_server
# d pour le faire tourner et p port 
