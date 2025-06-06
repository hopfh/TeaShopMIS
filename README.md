# Beverage Shop Ordering and Billing System

## Overview
This .NET Windows Forms application is a comprehensive ordering and billing system designed for small beverage shops. It supports both customer self-ordering and staff-assisted ordering modes, streamlining operations from menu management to payment processing.

- The Main Window:
  - ![Screenshot 2025-06-06 190937.png](https://s2.loli.net/2025/06/06/lIMrKWeqTJ5hFUH.png)

## Key Features
- **Dual Ordering Modes**: Self-service kiosk for customers + Staff-assisted POS interface
- **Inventory Management**: Track beverages with size/price variations and statuses (Available/Sold Out/Discontinued)
- **Dynamic Pricing**: Historical price tracking with effective date ranges
- **Membership System**: Customer management with membership benefits
- **Sales Analytics**: Revenue statistics visualized through charts
- **Multimedia Support**: Background music player for shop ambiance
- **Role-Based Access**: Different permissions for admins vs staff

## System Modules
### 1. System Management
- **Beverage Management**: CRUD operations for drinks with image support
- **Pricing History**: Track price changes with effective dates
- **Member Management**: Add/edit customer profiles and membership status
- **Staff Management**: User accounts with role-based permissions (Admin/Staff)

### 2. Ordering Service
- **Interactive Menu**: Visual drink display with size/price options
- **Order Modification**: Adjust quantities/specifications in real-time
- **Payment Processing**: Supports cash, card, Alipay, WeChat Pay
- **Auto-Calculation**: Instant discounts and final amount computation
- **Order Tracking**: Save orders to database with timestamps

### 3. Query & Statistics
- **Beverage Query**: Filter drinks by price range/availability
- **Member Lookup**: Search by name/card number/phone
- **Sales Reports**: Daily revenue statistics with date filters
- **Performance Analytics**: Visual charts for business metrics

## Database Schema
Core tables include:
- `Tea_Info` (Beverage master data)
- `Tea_Price` (Historical pricing)
- `Member_Info` (Customer profiles)
- `User_Info` (Staff accounts)
- `Order_Info` (Transaction records)
- `Order_Items` (Order details)

## Getting Started

### Prerequisites
- .NET Framework 4.5.2+
- SQL Server
- Visual Studio 2015+

### Installation
1. Clone repository:
   ```bash
   git clone https://github.com/your-repo/beverage-shop-system.git

2. Restore database:
  - Execute TeaShopDB.sql script

3. Configure connection:
  - Update App.config with your SQL Server credentials:
  ```xml
  <add key="DBConn" value="Data Source=YOUR_SERVER;database=TeaShopDB;Integrated Security=SSPI"/>

4. Build solution in Visual Studio
