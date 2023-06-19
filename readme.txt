
Repository link for WebAPI source code including docker file -->https://github.com/AteetAgarwal/mssql-k8s/tree/main/WebAPI

Commands to create webapi image
1) docker build -t mssqlwebapi -f Dockerfile .
2) docker tag mssqlwebapi ateet1989/mssqlwebapi:v3
3) docker images
4) docker login
5) docker push ateet1989/mssqlwebapi:v3

----------------------------------------------------------------------------------------------------------------------------------------


Repository for docker image of WebAPI --> https://hub.docker.com/repository/docker/ateet1989/mssqlwebapi/general


----------------------------------------------------------------------------------------------------------------------------------------


Repository for yaml and docker files --> https://github.com/AteetAgarwal/nagp-k8s-assignment


----------------------------------------------------------------------------------------------------------------------------------------


URL for WebAPI is http://<external-ip>:8080/swagger/index.html

Get external-ip by executing below command-
1) kubectl get svc


----------------------------------------------------------------------------------------------------------------------------------------