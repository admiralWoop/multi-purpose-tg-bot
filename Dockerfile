FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim
WORKDIR /app
COPY /app .
ENTRYPOINT ["dotnet", "WordCounterBot.APIL.WebApi.dll"]