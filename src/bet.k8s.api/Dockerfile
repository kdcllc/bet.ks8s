#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["src/bet.k8s.api/bet.k8s.api.csproj", "src/bet.k8s.api/"]
COPY ["src/bet.k8s.test/bet.k8s.test.csproj", "src/bet.k8s.test/"]
RUN dotnet restore "src/bet.k8s.api/bet.k8s.api.csproj"
COPY . .
WORKDIR "/src/src/bet.k8s.api"
RUN dotnet build "bet.k8s.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "bet.k8s.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bet.k8s.api.dll"]