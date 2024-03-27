FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["No-Kill-Inventory/No-Kill-Inventory.csproj", "No-Kill-Inventory/"]
RUN dotnet restore "No-Kill-Inventory/No-Kill-Inventory.csproj"
COPY . .
WORKDIR "/src/No-Kill-Inventory"
RUN dotnet build "No-Kill-Inventory.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "No-Kill-Inventory.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "No-Kill-Inventory.dll"]
