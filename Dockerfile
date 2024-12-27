FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000   
ENV ASPNETCORE_ENVIRONMENT=Development

WORKDIR /app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["SHURALE/SHURALE.csproj","SHURALE/"]
RUN dotnet restore "SHURALE/SHURALE.csproj"

COPY . . 
FROM build as publish
RUN dotnet publish "SHURALE/SHURALE.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SHURALE.dll"]