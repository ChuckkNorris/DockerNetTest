IMAGE_NAME="docker-net-test"
CONTAINER_NAME="sweet-app"
PORT=4000

# Build
# docker build --tag {myapps/image-name:optional-tag} {/path/to/folder-with-DockerFile/}
echo "Building Docker Image: $IMAGE_NAME"
docker build -t $IMAGE_NAME .

# Stop/Remove Existing Container
echo "Stopping/Removing Container: $CONTAINER_NAME"
docker stop $CONTAINER_NAME
docker rm $CONTAINER_NAME

# Run
# docker run --detach --publish 4000:80 --name {container-name-to-host} {image-name-to-run}
echo "Running /Removing Container: $CONTAINER_NAME"
docker run -d -p $PORT:80 --name $CONTAINER_NAME $IMAGE_NAME