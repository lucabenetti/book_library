# Books Library

## How to execute

The following commands enable the local execution of application and dependencies using Docker:

### Only dependencies
In case you want to run the code through Visual Studio (create the containers only for the dependencies):
```
cd docker
docker-compose -f docker-compose-local.yml up
```

### Dependencies + API + WebApp
In case you want to run everything using Docker (the API + WebApp + dependencies):
```
cd docker
docker-compose up -d --build
```

After the successfull creation of the containers, the api will be available in [http://localhost:5010/](http://localhost:5010/) and the web app in [http://localhost:5020/](http://localhost:5020/).

Swagger documentation will be available on http://localhost:5010/swagger.

### Folder structure
- **docker**: contains the docker compose files
- **src**: contains the source code

### Solution project division
**Core**: re-usable classes in different projects layers, like BaseController
**Domain**: entity models and contracts, like Posts
**Presentation**: web api and web app project
**Data**: contains data access logic, implementation of repositories
**Tests**: contains the tests

### Dependencies
- SQL Server