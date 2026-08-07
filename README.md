Library Management System — Desktop Application

A full-stack desktop application built in C# WinForms following a clean 3-layer architecture (Data Access → Business Logic → UI), designed to digitize the day-to-day operations of a library branch.

The system covers the complete library workflow: member registration with role-based access control (Admin / Librarian / Member) using a bitmask permissions system, book and copy inventory management, a full loan lifecycle (issue → extend → return) with automatic fine calculation via SQL Server triggers, and a fines management module with pay/waive actions tied to the user's permission level.

Tech stack: C# · WinForms · SQL Server · ADO.NET · Stored Procedures · SunnyUI · MaterialSkin.2

Key highlights:

Normalized database schema (3NF) with 9 tables, triggers for auto-fine calculation, views for reporting queries, and a sequence-based membership numbering system
Stored procedures for all CRUD operations with guard logic (e.g., blocks loan issuance for members with unpaid fines or suspended accounts)
Business layer cleanly separates Add vs Update modes and exposes domain-meaningful operations (Issue(), Return(), Extend(), Pay(), Waive()) rather than generic Save()
Card-based grid UI architecture replacing traditional data tables with a catalog-style browsable interface
