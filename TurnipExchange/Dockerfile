FROM mcr.microsoft.com/dotnet/core/sdk:3.1.201-alpine3.10 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY TurnipExchange/*.csproj ./TurnipExchange/
RUN dotnet restore ./TurnipExchange/TurnipExchange.csproj

# Copy everything else and build
COPY TurnipExchange/ ./TurnipExchange/
RUN dotnet publish -c Release -o out ./TurnipExchange/TurnipExchange.csproj

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1.3-alpine3.10
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "TurnipExchange.dll"]
