FROM gcr.io/cloud-builders/csharp/dotnet AS builder
COPY . /src 
WORKDIR /src 
RUN dotnet restore --packages /packages 
RUN dotnet publish -c Release -o /published 

FROM gcr.io/google-appengine/aspnetcore:2.0 
COPY --from=builder /published /app 
ENV ASPNETCORE_URLS=http://*:${PORT} 
WORKDIR /app 
ENTRYPOINT [ "dotnet", "WebApplication.dll" ]