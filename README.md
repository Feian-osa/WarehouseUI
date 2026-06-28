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
-- ========================================================
-- 1. DATABASE CREATION AND INITIALIZATION
-- ========================================================
USE master;
GO

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

-- ========================================================
-- 2. TABLE DEFINITIONS
-- ========================================================

CREATE TABLE Categories (
    CategoryID   INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Products (
    ProductID          INT IDENTITY(1,1) PRIMARY KEY,
    ProductName        NVARCHAR(150) NOT NULL,
    CategoryID         INT FOREIGN KEY REFERENCES Categories(CategoryID),
    Quantity           INT NOT NULL DEFAULT 0,
    ReorderLevel       INT NOT NULL DEFAULT 0,
    UnitPrice          DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    AnnualDemand       INT NOT NULL DEFAULT 0,
    OrderingCost       DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    HoldingCostPerUnit DECIMAL(18,2) NOT NULL DEFAULT 0.00
);
GO

CREATE TABLE Transactions (
    TransactionID   INT IDENTITY(1,1) PRIMARY KEY,
    ProductID       INT FOREIGN KEY REFERENCES Products(ProductID) ON DELETE SET NULL,
    ProductName     NVARCHAR(150) NULL,
    CategoryName    NVARCHAR(100) NULL,
    TransactionType NVARCHAR(10) NOT NULL,
    Quantity        INT NOT NULL,
    Price           DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    SupplierName    NVARCHAR(150) NULL,
    CustomerName    NVARCHAR(150) NULL,
    Remarks         NVARCHAR(500) NULL,
    TransactionDate DATETIME NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE SalesHistory (
    SaleID    INT IDENTITY(1,1) PRIMARY KEY,
    SaleDate  DATETIME NOT NULL,
    Revenue   DECIMAL(18,2) NOT NULL,
    Cost      DECIMAL(18,2) NOT NULL,
    NetProfit DECIMAL(18,2) NOT NULL
);
GO

-- ========================================================
-- 3. SEED DATA
-- ========================================================

INSERT INTO Categories (CategoryName) VALUES
('Electronics'), ('Stationery'), ('Furniture');
GO

INSERT INTO Products 
    (ProductName, CategoryID, Quantity, ReorderLevel, UnitPrice, 
     AnnualDemand, OrderingCost, HoldingCostPerUnit)
VALUES
('Laptop',       1, 50,  5,  85000.00, 1200, 150.00, 25.00),
('Pen',          2, 200, 20, 15.00,    5000, 25.00,  1.50),
('Office Chair', 3, 3,   5,  12000.00, 400,  75.00,  15.00);
GO

INSERT INTO Transactions 
    (ProductID, ProductName, CategoryName, TransactionType, 
     Quantity, Price, SupplierName, Remarks, TransactionDate)
VALUES
(1, 'Laptop',       'Electronics', 'IN',  50,  85000.00, 'Global Tech Distro',  'Initial delivery',       DATEADD(day,-5,GETDATE())),
(2, 'Pen',          'Stationery',  'IN',  250, 15.00,    'Pen Craft Wholesale', 'Bulk stock update',      DATEADD(day,-4,GETDATE())),
(2, 'Pen',          'Stationery',  'OUT', 50,  15.00,    'City Office Supply',  'Corporate dispatch',     DATEADD(day,-2,GETDATE())),
(3, 'Office Chair', 'Furniture',   'IN',  3,   12000.00, 'Comfort Seat Co',     'Showroom procurement',   DATEADD(day,-1,GETDATE()));
GO

INSERT INTO SalesHistory (SaleDate, Revenue, Cost, NetProfit) VALUES
('2026-01-15', 100000.00, 68000.00, 32000.00),
('2026-02-15', 110000.00, 75000.00, 35000.00),
('2026-03-15', 105000.00, 71000.00, 34000.00),
('2026-04-15', 120000.00, 82000.00, 38000.00),
('2026-05-15', 130000.00, 90000.00, 40000.00),
('2026-06-15', 135000.00, 93000.00, 42000.00);
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
