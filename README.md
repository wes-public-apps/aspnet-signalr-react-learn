# aspnet-signalr-react-learn

# run
* open terminal
* change working directory to containers/dev
* sudo docker-compose up -d

# teardown
* sudo docker-compose down

# Project Setup
* in root run "dotnet new web -o RealTimeWebApp"
* cd RealTimeWebApp
* install typescript based react app "npx create-react-app client --template typescript"
* add @type/react-router-dom and react-router-dom to package.json and then run "npm install"
* 

* dotnet new web -o backend
* npx create-react-app frontend --template typescript
* create containers/dev folder and add docker-compose file