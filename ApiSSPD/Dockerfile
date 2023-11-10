#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
ENV DOTNET_URLS=http://+:80


ENV DOTNET_URLS=http://+:80
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Production


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ApiSSPD/ApiSSPD.csproj", "ApiSSPD/"]
RUN dotnet restore "ApiSSPD/ApiSSPD.csproj"
COPY . .
WORKDIR "/src/ApiSSPD"
RUN dotnet build "ApiSSPD.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiSSPD.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiSSPD.dll"]