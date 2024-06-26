#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Paymentapi2/Paymentapi2.csproj", "Paymentapi2/"]
RUN dotnet restore "Paymentapi2/Paymentapi2.csproj"
COPY . .
WORKDIR "/src/Paymentapi2"
RUN dotnet build "Paymentapi2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Paymentapi2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Paymentapi2.dll"]