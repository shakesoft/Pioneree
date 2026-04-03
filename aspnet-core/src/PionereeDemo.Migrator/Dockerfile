#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "NuGet.Config"]
COPY ["src/PionereeDemo.Migrator/PionereeDemo.Migrator.csproj", "src/PionereeDemo.Migrator/"]
COPY ["src/PionereeDemo.EntityFrameworkCore/PionereeDemo.EntityFrameworkCore.csproj", "src/PionereeDemo.EntityFrameworkCore/"]
COPY ["src/PionereeDemo.Core/PionereeDemo.Core.csproj", "src/PionereeDemo.Core/"]
COPY ["src/PionereeDemo.Core.Shared/PionereeDemo.Core.Shared.csproj", "src/PionereeDemo.Core.Shared/"]
RUN dotnet restore "src/PionereeDemo.Migrator/PionereeDemo.Migrator.csproj"
COPY . .
WORKDIR "/src/src/PionereeDemo.Migrator"
RUN dotnet build "PionereeDemo.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PionereeDemo.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PionereeDemo.Migrator.dll", "-s"]
