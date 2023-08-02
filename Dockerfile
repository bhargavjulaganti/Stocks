FROM mcr.microsoft.com/dotnet/sdk:6.0 AS publish

WORKDIR /app

COPY . ./

RUN dotnet restore ./Stocks.Api/Stocks.Api.csproj
RUN dotnet publish ./Stocks.Api/Stocks.Api.csproj -c Release -o publish/

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as deploy

WORKDIR /app

EXPOSE 80

COPY --from=publish /app/publish .

ENTRYPOINT [ "dotnet", "Stocks.Api.dll"]