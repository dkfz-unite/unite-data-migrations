FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS restore
ARG GITHUB_TOKEN
WORKDIR /src
RUN echo ${GITHUB_TOKEN}
RUN dotnet nuget add source https://nuget.pkg.github.com/dkfz-unite/index.json -n github -u vulasau-dkfz -p ${GITHUB_TOKEN}
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
