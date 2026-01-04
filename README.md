# Library Management System

## Project Description
A desktop application built with Windows Forms (C#) and SQL Server for managing library operations including book borrowing, returns, user management, and administrative functions.

## Features

### User Features
- User registration and login
- Search books by title, author, or category
- Add books to cart for borrowing
- Borrow selected books from cart
- Return borrowed books
- View personal borrowing history

### Admin Features
- Manage books (add, edit, delete)
- Manage library users
- View reports and statistics
- Configure system settings

## Technology Stack
- **Frontend**: Windows Forms (C#)
- **Backend**: .NET Framework
- **Database**: SQL Server
- **Architecture**: Three-tier (Presentation-Business-Data)

## Installation

### Prerequisites
1. Visual Studio 2019 or later
2. SQL Server 2012 or later
3. .NET Framework 4.7.2

### Setup Steps
1. Clone the repository
2. Open the solution in Visual Studio
3. Restore NuGet packages
4. Run SQL scripts to create database:
   - Users.sql
   - Books.sql
   - Borrows.sql
5. Update connection string in app.config
6. Build and run the application

## Database Structure

### Users Table
- Stores user information and credentials

### Books Table
- Stores book details and inventory

### Borrows Table
- Tracks borrowing records and fees

## Usage Instructions

### User Flow
1. Register new account or login
2. Search for books using search form
3. Add books to cart
4. Go to Borrow From Cart to select books
5. Enter password and accept terms
6. Books are borrowed and removed from cart
7. Return books through Return Book form
8. View history through My Borrow History

### Admin Flow
1. Login with admin account (UserID = 1)
2. Access admin dashboard
3. Use Manage Books for book operations
4. Use Manage Users for user management
5. View Reports for system analytics
6. Configure System Settings

## Project Structure

### Services
- AuthService.cs - User authentication and management
- BookService.cs - Book operations and search
- BorrowService.cs - Borrowing and return operations

### User Forms
- LoginForm - User authentication
- RegisterForm - New user registration
- UserDashboardForm - Main user interface
- UserSearchBooksForm - Book search and cart
- BorrowFromCartForm - Cart-based borrowing
- ReturnBookForm - Book returns
- MyBorrowHistoryForm - Borrowing history

### Admin Forms
- AdminDashboardForm - Admin control panel
- ManageBooksForm - Book management
- ManageUsersForm - User management
- ReportsForm - System reports
- SystemSettingsForm - System configuration

## Fee Calculation
- First day: 20 EGP
- Each additional day: 40 EGP
- Fees calculated automatically on return

## Building the Project
1. Open solution in Visual Studio
2. Restore NuGet packages
3. Build solution (Ctrl+Shift+B)
4. Run application (F5)

## Troubleshooting

### Common Issues
1. Database connection errors: Check connection string
2. Missing NuGet packages: Restore packages
3. EDMX model issues: Update model from database

### Testing
- Test user registration and login
- Test book search and borrowing
- Test admin functions
- Verify fee calculations

## Future Enhancements
1. Email notifications
2. Advanced reporting
3. Multi-branch support
4. Online reservations

## Notes
- This is a prototype version
- For educational purposes
- Not for commercial use

## Support
For technical issues, consult the troubleshooting section or contact the development team.
