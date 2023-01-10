FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["EFTToolsAPI/EFTToolsAPI.csproj", "EFTToolsAPI/"]
RUN dotnet restore "EFTToolsAPI/EFTToolsAPI.csproj"
COPY . .
WORKDIR "/src/EFTToolsAPI"
RUN dotnet build "EFTToolsAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EFTToolsAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EFTToolsAPI.dll"]
