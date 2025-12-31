USE LibraryDB;
GO

CREATE TABLE Books (
    BookId INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Author NVARCHAR(150) NOT NULL,
    Category NVARCHAR(100) NOT NULL,
    TotalCopies INT NOT NULL CHECK (TotalCopies >= 0),
    AvailableCopies INT NOT NULL CHECK (AvailableCopies >= 0),
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);
GO
