# 🧮 Calculator API

A simple **RESTful Calculator API** built with **ASP.NET Core** that supports four basic arithmetic operations: addition, subtraction, multiplication, and division.

## Features

- **Four Basic Arithmetic Operations** (`+`, `-`, `*`, `/`)
- **RESTful API with JSON responses**
- **Unit Tests with xUnit and Moq**
- **Automated CI/CD with GitHub Actions**

---

## Getting Started

### **Prerequisites**
- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download/dotnet)
- [Git](https://git-scm.com/)
- (Optional) [Docker](https://www.docker.com/)

### **1. Clone the Repository**
```sh
git clone https://github.com/bhanukad610/portfolio.git
cd CalculatorAPI
```

### **2. Build and Run the API**
```sh
dotnet build
dotnet run
```

## Usage

### **API Endpoints**
| HTTP Method |         Endpoint         | Query Parameters |                    Description                    |
|:-----------:|:------------------------:|:----------------:|:-------------------------------------------------:|
| GET         | /api/calculator/add      | a, b             |                 Adds two numbers                  |
| GET         | /api/calculator/subtract | a, b             |               Subtracts two numbers               |
| GET         | /api/calculator/multiply | a, b             |              Multiplies two numbers               |
| GET         | /api/calculator/divide   | a, b             | Divides two numbers |

### **Example Usage**
To add 5 + 3, make a GET request
```sh
curl "http://localhost:5000/api/calculator/add?a=5&b=3"
```
Expected Response:
```sh
{
  "result": 8
}
```
### **Running Tests**
The project includes unit tests to verify API functionality.

Run Tests
```sh
dotnet test
```
Note : This repository uses GitHub Actions for automated testing.
Every push and pull request triggers a build & test pipeline.