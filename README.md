# 📦 OstadMiniInventory

A simple Inventory Management System built using **ASP.NET 8 Core MVC**, **Entity Framework Core**, and **Bootstrap 5** that allows users to manage products with full CRUD operations, category filtering, and product search.

---

## 🚀 Features

- ✅ Add new products
- ✅ View product list
- ✅ Edit existing products
- ✅ Delete products
- ✅ Search products by name
- ✅ Filter products by category
- ✅ Status badges: In Stock, Low Stock, Out of Stock
- ✅ Responsive Bootstrap 5 UI

---

## 🛠️ Technologies Used

- ASP.NET Core 8 MVC
- Entity Framework Core
- SQL Server 
- Razor Views
- Bootstrap 5

---

## 📁 Project Structure

```
OstadMiniInventory/
│
├── Controllers/
│   └── ProductsController.cs
│
├── Models/
│   └── Product.cs
│
├── Views/
│   └── Products/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       ├── Delete.cshtml
│       └── Details.cshtml
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── wwwroot/
│   └── (CSS, JS, Bootstrap)
│
└── Program.cs
```

---

## ⚙️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/SohelPerves/OstadMiniInventory.git
cd OstadMiniInventory
```

### 2. Restore NuGet packages

```bash
dotnet restore
```

### 3. Update the database

```bash
dotnet ef database update
```

### 4. Run the application

```bash
dotnet run
```

Visit `https://localhost:5001` or `http://localhost:5000` in your browser.

---
## 🤝 Contributing

Feel free to fork this repository and submit pull requests. For any issues, open a GitHub issue.

---

## 🙋‍♂️ Author

Developed by [Mohammad Sohel Parves](https://github.com/SohelPerves)  

