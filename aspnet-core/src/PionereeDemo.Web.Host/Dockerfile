#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "NuGet.Config"]
COPY ["src/PionereeDemo.Web.Host/PionereeDemo.Web.Host.csproj", "src/PionereeDemo.Web.Host/"]
COPY ["src/PionereeDemo.Web.Core/PionereeDemo.Web.Core.csproj", "src/PionereeDemo.Web.Core/"]
COPY ["src/PionereeDemo.Application/PionereeDemo.Application.csproj", "src/PionereeDemo.Application/"]
COPY ["src/PionereeDemo.Application.Shared/PionereeDemo.Application.Shared.csproj", "src/PionereeDemo.Application.Shared/"]
COPY ["src/PionereeDemo.Core.Shared/PionereeDemo.Core.Shared.csproj", "src/PionereeDemo.Core.Shared/"]
COPY ["src/PionereeDemo.Core/PionereeDemo.Core.csproj", "src/PionereeDemo.Core/"]
COPY ["src/PionereeDemo.EntityFrameworkCore/PionereeDemo.EntityFrameworkCore.csproj", "src/PionereeDemo.EntityFrameworkCore/"]
COPY ["src/PionereeDemo.GraphQL/PionereeDemo.GraphQL.csproj", "src/PionereeDemo.GraphQL/"]
RUN dotnet restore "src/PionereeDemo.Web.Host/PionereeDemo.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/PionereeDemo.Web.Host"
RUN dotnet build "PionereeDemo.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PionereeDemo.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PionereeDemo.Web.Host.dll"]
