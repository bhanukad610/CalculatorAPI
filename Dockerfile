# Use official .NET runtime as base
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Set working directory
WORKDIR /app

# Copy published files from build
COPY ./CalculatorAPI/bin/Release/net8.0/publish/ .

# Expose API port
EXPOSE 5000

# Run the application
ENTRYPOINT ["dotnet", "CalculatorAPI.dll"]