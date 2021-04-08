FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /app
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["CloudBar.BussinesLogic/CloudBar.BusinessLogic.csproj", "CloudBar.BussinesLogic/"]
COPY ["CloudBar.Common/CloudBar.Common.csproj", "CloudBar.Common/"]
COPY ["CloudBar.DataAccess/CloudBar.DataAccess.csproj", "CloudBar.DataAccess/"]
COPY ["CloudBar.Domain/CloudBar.Domain.csproj", "CloudBar.Domain/"]
COPY ["CloudBarAPI/CloudBar.csproj", "CloudBarAPI/"]
RUN dotnet restore "CloudBarAPI/CloudBar.csproj"
COPY . .
WORKDIR "/src/CloudBarAPI"
RUN dotnet build "CloudBar.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "CloudBar.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet CloudBar.dll