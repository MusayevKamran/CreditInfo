FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Creditinfo/src/CreditInfo.API/CreditInfo.API.csproj", "CreditInfo.API/"]
RUN dotnet restore "Creditinfo/src/CreditInfo.API/CreditInfo.API.csproj"
COPY . .
WORKDIR "/src/CreditInfo.API"
RUN dotnet build "CreditInfo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CreditInfo.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CreditInfo.API.dll"]
