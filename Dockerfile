FROM mcr.microsoft.com/dotnet/runtime:5.0-buster-slim AS base
WORKDIR /app

#FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS restore 5.0.102-ca-patch-buster-slim
FROM mcr.microsoft.com/dotnet/sdk:5.0.102-ca-patch-buster-slim AS restore
ARG USER
ARG TOKEN
WORKDIR /src
RUN dotnet nuget add source https://nuget.pkg.github.com/dkfz-unite/index.json -n github -u ${USER} -p ${TOKEN} --store-password-in-clear-text
COPY ["Unite.Data.Migrations/Unite.Data.Migrations.csproj", "Unite.Data.Migrations/"]
RUN dotnet restore "Unite.Data.Migrations/Unite.Data.Migrations.csproj"

FROM restore AS build
COPY . .
WORKDIR "/src/Unite.Data.Migrations"
RUN dotnet build "Unite.Data.Migrations.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Unite.Data.Migrations.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Unite.Data.Migrations.dll"]
