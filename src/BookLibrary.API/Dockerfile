#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/BookLibrary.API/BookLibrary.API.csproj", "src/BookLibrary.API/"]
RUN dotnet restore "src/BookLibrary.API/BookLibrary.API.csproj"
COPY . .
WORKDIR "/src/src/BookLibrary.API"
RUN dotnet build "BookLibrary.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BookLibrary.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BookLibrary.API.dll"]