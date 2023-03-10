#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FoxBeTestA.Api/FoxBeTestA.Api.csproj", "FoxBeTestA.Api/"]
COPY ["FoxBeTestA.DAL/FoxBeTestA.DAL.csproj", "FoxBeTestA.DAL/"]
COPY ["FoxBeTestA.Application/FoxBeTestA.Application.csproj", "FoxBeTestA.Application/"]
RUN dotnet restore "FoxBeTestA.Api/FoxBeTestA.Api.csproj"
COPY . .
WORKDIR "/src/FoxBeTestA.Api"
RUN dotnet build "FoxBeTestA.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FoxBeTestA.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FoxBeTestA.Api.dll"]