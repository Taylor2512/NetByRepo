# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Instalar libicu-dev (si es necesario)
RUN apt-get update && apt-get install -y --no-install-recommends \
    libicu-dev \
 && rm -rf /var/lib/apt/lists/*

# Copia todo el contenido del proyecto
COPY . .  
RUN dotnet restore "NetByForms.Api/NetByForms.Api.csproj"

# Compila y publica la aplicación
RUN dotnet publish "NetByForms.Api/NetByForms.Api.csproj" -c Release -o /app/publish

# Etapa final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 7130

# Copia los archivos publicados desde la etapa de construcción
COPY --from=build /app/publish .

# Configura las variables de entorno necesarias
ENV ASPNETCORE_URLS=http://+:7130 \
    ASPNETCORE_ENVIRONMENT=Production

# Configura el punto de entrada de la aplicación
ENTRYPOINT ["dotnet", "NetByForms.Api.dll"]