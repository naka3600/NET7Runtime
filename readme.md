# Docker Image build

docker build -t myapp .

# run

docker run -d myapp

# log output

docker logs -f myapp

docker logs myapp

docker logs --tail 10 myapp

# container shutdown

docker ps
docker exec [CONTAINER ID] ps aux
docker exec [CONTAINER ID] kill 1
