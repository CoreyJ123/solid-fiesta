FROM mcr.microsoft.com/dotnet/nightly/runtime:8.0 AS build
COPY . .
RUN dotnet build
