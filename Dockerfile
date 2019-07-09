FROM microsoft/aspnetcore-build


WORKDIR /home/EntidadesApi

COPY . .

RUN dotnet restore

RUN dotnet  publish -o /publish/

WORKDIR /publish

# Build runtime image

ENTRYPOINT ["dotnet", "EntidadesApi.dll"]

EXPOSE 8080
