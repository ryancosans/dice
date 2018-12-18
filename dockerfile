FROM fsharp:netcore
COPY . /app
WORKDIR /app
RUN dotnet test ./tests
CMD dotnet run