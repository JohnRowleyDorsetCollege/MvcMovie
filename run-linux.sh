sudo docker build -t aspnetapp .
sudo docker run -it --rm -p 5000:5000 -e ASPNETCORE_URLS=http://+:5000 -e ASPNETCORE_ENVIRONMENT=Development --name aspnetcore_sample aspnetapp
