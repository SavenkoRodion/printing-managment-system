FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App

EXPOSE 3000
EXPOSE 3001
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Development
WORKDIR /src

COPY ["PMS-Api/PMS-Api.csproj", "PMS-Api/"]

RUN dotnet restore "PMS-Api/PMS-Api.csproj"
COPY . .

WORKDIR "/src/PMS-Api"
RUN dotnet build "PMS-Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build as publish
ARG BUILD_CONFIGURATION=Development
RUN dotnet publish "PMS-Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "PMS-Api.dll"]