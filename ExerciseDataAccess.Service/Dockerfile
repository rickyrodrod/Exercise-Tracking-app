#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ExerciseDataAccess.Service/ExerciseDataAccess.Service.csproj", "ExerciseDataAccess.Service/"]
RUN dotnet restore "ExerciseDataAccess.Service/ExerciseDataAccess.Service.csproj"
COPY . .
WORKDIR "/src/ExerciseDataAccess.Service"
RUN dotnet build "ExerciseDataAccess.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExerciseDataAccess.Service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExerciseDataAccess.Service.dll"]