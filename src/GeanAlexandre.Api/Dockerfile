FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY ./bin/Release/netcoreapp2.0/publish/ /app/
ENV ASPNETCORE_URLS http://*:80
ENV ASPNETCORE_ENVIRONMENT Production
EXPOSE 80
ENTRYPOINT ["dotnet", "GeanAlexandre.Api.dll"]
