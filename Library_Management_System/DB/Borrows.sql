USE LibraryDB;
GO

CREATE TABLE Borrows (
    BorrowId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    BookId INT NOT NULL,
    BorrowDate DATETIME NOT NULL,
    ReturnDate DATETIME NULL,
    IsReturned BIT NOT NULL DEFAULT 0,

    CONSTRAINT FK_Borrows_Users
        FOREIGN KEY (UserId)
        REFERENCES Users(UserId),

    CONSTRAINT FK_Borrows_Books
        FOREIGN KEY (BookId)
        REFERENCES Books(BookId)
);
GO
