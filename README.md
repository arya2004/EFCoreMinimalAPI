
# **EF Core Minimal API**  

A **.NET 8 Minimal API** template with **Entity Framework Core (EF Core)**, **Identity (User Authentication)**, and **SQL Server**. This repository provides a structured way to build APIs using **Minimal API** while keeping the folder structure similar to **Controller-based APIs**.  

[![.NET Version](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
[![EF Core](https://img.shields.io/badge/Entity%20Framework%20Core-8.0-green)](https://docs.microsoft.com/en-us/ef/core/)  
[![Minimal API](https://img.shields.io/badge/Minimal%20API-Supported-orange)](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis)  
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)  

---

## **🚀 Features**
✅ **.NET 8 Minimal API**  
✅ **Entity Framework Core (EF Core) with SQL Server**  
✅ **ASP.NET Core Identity for User Management**  
✅ **Modular Folder Structure (Not everything in `Program.cs`)**  
✅ **Dependency Injection for Clean Architecture**  
✅ **Swagger UI for API Documentation**  

---

---

## **📦 Installation**
1️⃣ **Clone the repository**  
```sh
git clone https://github.com/arya2004/EFCoreMinimalAPI.git
cd EFCoreMinimalAPI
```

2️⃣ **Restore dependencies**  
```sh
dotnet restore
```

3️⃣ **Apply database migrations**  
```powershell
# If using Visual Studio (Package Manager Console)
# Add-Migration MigrationName (For making further migrations)
Update-Database
```
Or, if using CLI:
```sh
# dotnet ef migrations add MigrationName (For making further migrations)
dotnet ef database update
```

4️⃣ **Run the API**  
```sh
dotnet run
```

---
---

## **🔗 Connection String**
- Update your `appsettings.json` file with your SQL Server connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=UserDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

---

## **🎯 Using this as a Template?**
1. Click on **"Use this template"** on GitHub.  
2. Clone your new repo.  
3. Update the project name in `EFCoreMinimalAPI.csproj`  
4. Run the setup commands above.  

---

## **📝 License**
This project is licensed under the **MIT License** – see the [`LICENSE`](LICENSE) file for details.  

---


## **💡 Need Help?**
Feel free to **open an issue** or **start a discussion** if you encounter any problems! 🚀  
