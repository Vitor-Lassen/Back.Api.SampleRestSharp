#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Back.Api.SampleRestSharp/Back.Api.SampleRestSharp.csproj", "Back.Api.SampleRestSharp/"]
RUN dotnet restore "Back.Api.SampleRestSharp/Back.Api.SampleRestSharp.csproj"
COPY . .
WORKDIR "/src/Back.Api.SampleRestSharp"
RUN dotnet build "Back.Api.SampleRestSharp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Back.Api.SampleRestSharp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Back.Api.SampleRestSharp.dll"]