# Warehouse Inventory Management System (WMS)

A desktop application built with C# WinForms and SQL Server as a 
3rd semester BCA college project at Gomendra Multiple College, 
Purbanchal University.

## Features

- **Dashboard** — Live summary cards showing total products, 
  low stock alerts, and total stock value with inventory snapshot
- **Inventory Management** — Full CRUD operations (Add, Update, 
  Delete, Search) for products with category management
- **Stock In/Out** — Record stock movements with supplier/customer 
  tracking and automatic quantity updates
- **Low Stock Alerts** — Color-coded urgency system (Low, Critical, 
  Out of Stock) with real-time refresh
- **Transaction Log** — Complete history of all stock movements
- **Reports** — Generate and export product list, low stock report, 
  and transaction summary to CSV
- **EOQ Calculator** — Economic Order Quantity formula with live 
  U-shaped cost curve chart
- **Profit Prediction** — Linear regression forecasting with dual 
  series chart (actual vs predicted)

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# (.NET 8) |
| UI Framework | Windows Forms (WinForms) |
| Database | SQL Server LocalDB |
| DB Client | Microsoft.Data.SqlClient |
| Charts | WinForms.DataVisualization |
| IDE | Visual Studio Community 2022 |

## Project Architecture
WarehouseUI/

├── Forms/       → UI layer (8 forms)

├── Data/        → Repository layer (SQL queries)

├── Models/      → Data classes

└── Services/    → Business logic (EOQ, prediction)

## Setup & Installation

### Prerequisites
- Visual Studio Community 2022
- SQL Server Management Studio (SSMS)
- .NET 8 SDK

### Step 1 — Clone the repository
```bash
git clone https://github.com/YOUR_USERNAME/WarehouseUI.git
cd WarehouseUI
```

### Step 2 — Set up the database
1. Open **SSMS** and connect to `(localdb)\MSSQLLocalDB`
2. Click **New Query**
3. Copy and paste the full SQL script below and press **F5**

```sql
-- ================================================================
-- WAREHOUSE INVENTORY MANAGEMENT SYSTEM
-- Complete Database Setup Script
-- Run this in SSMS connected to (localdb)\MSSQLLocalDB
-- ================================================================

USE master;
GO

-- Drop and recreate clean
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'WarehouseDB')
BEGIN
    ALTER DATABASE WarehouseDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE WarehouseDB;
END
GO

CREATE DATABASE WarehouseDB;
GO

USE WarehouseDB;
GO

-- ================================================================
-- TABLES
-- ================================================================

-- 1. Categories
CREATE TABLE Categories (
    CategoryID   INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL
);
GO

-- 2. Products
CREATE TABLE Products (
    ProductID          INT IDENTITY(1,1) PRIMARY KEY,
    ProductName        NVARCHAR(150) NOT NULL,
    CategoryID         INT FOREIGN KEY REFERENCES Categories(CategoryID),
    Quantity           INT NOT NULL DEFAULT 0,
    ReorderLevel       INT NOT NULL DEFAULT 0,
    UnitPrice          DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    AnnualDemand       INT NOT NULL DEFAULT 0,
    OrderingCost       DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    HoldingCostPerUnit DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    EntryDate          DATE DEFAULT GETDATE()
);
GO

-- 3. Transactions
CREATE TABLE Transactions (
    TransactionID   INT IDENTITY(1,1) PRIMARY KEY,
    ProductID       INT FOREIGN KEY REFERENCES Products(ProductID) ON DELETE SET NULL,
    ProductName     NVARCHAR(150) NULL,
    CategoryName    NVARCHAR(100) NULL,
    TransactionType NVARCHAR(10) NOT NULL,   -- 'IN' or 'OUT'
    Quantity        INT NOT NULL,
    Price           DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    SupplierName    NVARCHAR(150) NULL,
    CustomerName    NVARCHAR(150) NULL,
    Remarks         NVARCHAR(500) NULL,
    TransactionDate DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- 4. SalesHistory
CREATE TABLE SalesHistory (
    SaleID    INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID) ON DELETE SET NULL,
    SaleDate  DATETIME NOT NULL,
    UnitsSold INT NOT NULL DEFAULT 0,
    Revenue   DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    Cost      DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    NetProfit DECIMAL(18,2) NOT NULL DEFAULT 0.00
);
GO

-- 5. Users (Login and Register)
CREATE TABLE Users (
    UserID    INT IDENTITY(1,1) PRIMARY KEY,
    Username  NVARCHAR(50) NOT NULL UNIQUE,
    Password  NVARCHAR(100) NOT NULL,
    FullName  NVARCHAR(100) NULL,
    Role      NVARCHAR(20) NOT NULL DEFAULT 'Staff',
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- ================================================================
-- SEED DATA
-- ================================================================

-- Categories
INSERT INTO Categories (CategoryName) VALUES
('Electronics'),
('Stationery'),
('Furniture');
GO

-- Products
INSERT INTO Products
    (ProductName, CategoryID, Quantity, ReorderLevel, UnitPrice,
     AnnualDemand, OrderingCost, HoldingCostPerUnit)
VALUES
('Laptop',       1, 50,  5,  85000.00, 1200, 150.00, 25.00),
('Pen',          2, 200, 20, 15.00,    5000, 25.00,  1.50),
('Office Chair', 3, 3,   5,  12000.00, 400,  75.00,  15.00),
('Monitor',      1, 25,  3,  35000.00, 600,  100.00, 20.00),
('Notebook',     2, 150, 30, 120.00,   3000, 30.00,  2.00),
('Desk',         3, 8,   2,  18000.00, 200,  80.00,  18.00);
GO

-- Transactions
INSERT INTO Transactions
    (ProductID, ProductName, CategoryName, TransactionType,
     Quantity, Price, SupplierName, CustomerName, Remarks, TransactionDate)
VALUES
(1, 'Laptop',       'Electronics', 'IN',  50,  85000.00, 'Global Tech Distro',  NULL,              'Initial stock load',       DATEADD(day,-10, GETDATE())),
(2, 'Pen',          'Stationery',  'IN',  250, 15.00,    'Pen Craft Wholesale', NULL,              'Bulk stock order',         DATEADD(day,-9,  GETDATE())),
(3, 'Office Chair', 'Furniture',   'IN',  5,   12000.00, 'Comfort Seat Co',     NULL,              'Showroom delivery',        DATEADD(day,-8,  GETDATE())),
(4, 'Monitor',      'Electronics', 'IN',  30,  35000.00, 'Vision Displays Ltd', NULL,              'Initial procurement',      DATEADD(day,-7,  GETDATE())),
(5, 'Notebook',     'Stationery',  'IN',  200, 120.00,   'Paper World',         NULL,              'Office supply restock',    DATEADD(day,-6,  GETDATE())),
(2, 'Pen',          'Stationery',  'OUT', 50,  15.00,    NULL, 'City Office Supply',  'Corporate bulk order',     DATEADD(day,-5,  GETDATE())),
(1, 'Laptop',       'Electronics', 'OUT', 5,   85000.00, NULL, 'Tech Solutions Inc',  'Client delivery',          DATEADD(day,-4,  GETDATE())),
(3, 'Office Chair', 'Furniture',   'OUT', 2,   12000.00, NULL, 'Modern Office Co',    'Showroom sale',            DATEADD(day,-3,  GETDATE())),
(4, 'Monitor',      'Electronics', 'OUT', 5,   35000.00, NULL, 'Digital Hub',         'Invoice dispatch',         DATEADD(day,-2,  GETDATE())),
(5, 'Notebook',     'Stationery',  'OUT', 50,  120.00,   NULL, 'School Supplies Ltd', 'Education sector order',   DATEADD(day,-1,  GETDATE()));
GO

-- SalesHistory (6 months for profit prediction chart)
INSERT INTO SalesHistory (ProductID, SaleDate, UnitsSold, Revenue, Cost, NetProfit)
VALUES
(1, '2026-01-15', 10, 850000.00, 650000.00, 200000.00),
(2, '2026-01-15', 100, 1500.00,  800.00,    700.00),
(1, '2026-02-15', 12, 1020000.00, 780000.00, 240000.00),
(3, '2026-02-15', 3,  36000.00,  25000.00,  11000.00),
(1, '2026-03-15', 8,  680000.00, 520000.00, 160000.00),
(2, '2026-03-15', 150, 2250.00,  1200.00,   1050.00),
(4, '2026-04-15', 8,  280000.00, 210000.00, 70000.00),
(5, '2026-04-15', 80, 9600.00,   6000.00,   3600.00),
(1, '2026-05-15', 15, 1275000.00, 975000.00, 300000.00),
(4, '2026-05-15', 10, 350000.00, 260000.00, 90000.00),
(1, '2026-06-15', 18, 1530000.00, 1170000.00, 360000.00),
(3, '2026-06-15', 2,  24000.00,  16000.00,  8000.00);
GO

-- Users (default admin + sample staff)
INSERT INTO Users (Username, Password, FullName, Role) VALUES
('admin',   'admin123',  'Administrator',  'Admin'),
('staff1',  'staff123',  'Ram Sharma',     'Staff'),
('staff2',  'staff123',  'Sita Thapa',     'Staff');
GO

-- ================================================================
-- VERIFICATION
-- ================================================================
SELECT 'Categories'   AS TableName, COUNT(*) AS Records FROM Categories   UNION ALL
SELECT 'Products',                  COUNT(*)             FROM Products      UNION ALL
SELECT 'Transactions',              COUNT(*)             FROM Transactions   UNION ALL
SELECT 'SalesHistory',              COUNT(*)             FROM SalesHistory   UNION ALL
SELECT 'Users',                     COUNT(*)             FROM Users;
GO

-- Quick preview of each table
SELECT * FROM Categories;
SELECT * FROM Products;
SELECT * FROM Transactions ORDER BY TransactionDate DESC;
SELECT * FROM SalesHistory ORDER BY SaleDate;
SELECT UserID, Username, FullName, Role, CreatedAt FROM Users;
GO
```

### Step 3 — Open in Visual Studio
1. Open `WarehouseUI.sln`
2. Press **F5** to build and run

### Default Login
Username: admin

Password: admin123

## What the seed data sets up

| Table | Records | Purpose |
|---|---|---|
| Categories | 3 | Electronics, Stationery, Furniture |
| Products | 3 | Laptop, Pen, Office Chair |
| Transactions | 4 | Sample IN/OUT history |
| SalesHistory | 6 months | Feeds profit prediction chart |

> Office Chair is intentionally set below reorder level to 
> demonstrate the Low Stock Alerts feature on first run.

## License

MIT License — free to use for educational purposes.
