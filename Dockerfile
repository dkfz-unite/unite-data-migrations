FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS restore
WORKDIR /src
COPY ["Unite.Data.Migrations/Unite.Data.Migrations.csproj", "NuGet.Config", "Unite.Data.Migrations/"]
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