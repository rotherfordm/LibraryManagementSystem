/* CREATE DATABASE JNHS_LIBRARYMS */

/* USE JNHS_LIBRARYMS */

/*
create table Users
(
	UserID int identity(1001,1) primary key,
	FirstName varchar(50),
	MiddleName varchar(50),
	LastName varchar(50),
	Address varchar(50),
	ContactNumber varchar(50),
	Email varchar(50),
	
	UserName varchar(50),
	Password varchar(50),
	IsAdmin varchar(50)
)
*/

/*

INSERT INTO Users
(FirstName, MiddleName, LastName, Address, ContactNumber, Email, UserName, Password, IsAdmin) 
VALUES
('', '', '', '','','', '', '','1')

SELECT * FROM Users

SELECT UserName, Password From Users where UserID = 1003

*/

/*
create table Books
(
	BookID int identity(1001,1) primary key,
	ISBN varchar(50),
	Category varchar(50),
	Title varchar(50),
	Author varchar(50),
	Abstract varchar(255),

)
*/

/*
SELECT * FROM Books

INSERT INTO Books
(ISBN, Category, Title, Author, Abstract)
VALUES
('123','re','ty','ev','very long')
*/

create table BookSupplyTransaction
(
	SupplyTransID int identity(1001,1) primary key,
	BookID int,
	Supplies numeric

)

INSERT INTO BookSupplyTransaction
(BookID, Supplies)
VALUES
('1001','10')

SELECT * FROM BookSupplyTransaction

create table BorrowingTransaction
(
	BorrowTransID int identity(1001,1) primary key,
	BookID int,
	UserID int,
	Quantity numeric
	
)

INSERT INTO BorrowingTransaction
(BookID, UserID, Quantity)
VALUES
('1001','1001','1')

SELECT * FROM BorrowingTransaction

Select BorrowTransID, BorrowingTransaction.BookID, BorrowingTransaction.UserID, Quantity
            From BorrowingTransaction
           Inner join Users on Users.UserID = BorrowingTransaction.UserID
		   Inner join Books on Books.BookID = BorrowingTransaction.BookID


/* CURRENT STOCKS*/
Select TotalBorrowTrans.BookID, Title, TSupply - TBorrow AS CurrentStocks FROM
(SELECT BookID, sum(Quantity) AS TBorrow FROM BorrowingTransaction GROUP BY BookID) As TotalBorrowTrans
INNER JOIN
(SELECT BookID, sum(Supplies) AS TSupply FROM BookSupplyTransaction GROUP BY BookID) As TotalSupplyTrans
INNER JOIN
(SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NTotal
ON NTotal.BookID = TotalSupplyTrans.BookID ON TotalBorrowTrans.BookID = NTotal.BookID
Where TotalBorrowTrans.BookID = '1001'


SELECT BookID, ISBN, Category, Title, Author, Abstract FROM Books
SELECT UserID, FirstName, MiddleName, LastName FROM Users



SELECT Title from Books where BookID = '1002'


/* borrow trans  */
SELECT BorrowTrans.BookID, BorrowTrans.UserID, NBooks.Title, BorrowTrans.BTQuantity - ReturnBookTrans.BRTQuantity AS 'Current Book Borrowed'
FROM
(SELECT BookID, UserID, SUM(Quantity) AS BTQuantity FROM BorrowingTransaction GROUP BY BookID, UserID) AS BorrowTrans
INNER JOIN
(SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NBooks
INNER JOIN
(SELECT BookID, UserID, SUM(Quantity) AS BRTQuantity FROM BookReturnTransaction GROUP BY BookID, USERID) AS ReturnBookTrans
on NBooks.BookID = ReturnBookTrans.BookID on BorrowTrans.BookID = ReturnBookTrans.BookID
Where BorrowTrans.UserID = '1001'  

/* return form */
SELECT ReturnBookTrans.BookID, ReturnBookTrans.UserID, NBooks.Title, ReturnBookTrans.BRTQuantity AS 'Books Returned'
FROM
(SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NBooks
INNER JOIN
(SELECT BookID, UserID, SUM(Quantity) AS BRTQuantity FROM BookReturnTransaction GROUP BY BookID, USERID) AS ReturnBookTrans
on NBooks.BookID = ReturnBookTrans.BookID
Where ReturnBookTrans.UserID = '1006' 

SELECT * FROM BookReturnTransaction
	
INSERT INTO BookReturnTransaction
(BookID, UserID, Quantity)
VALUES
('1001','1001','2')

INSERT INTO BorrowingTransaction
(BookID, UserID, Quantity)
VALUES
('1001','1001','2')

SELECT * FROM BorrowingTransaction where UserID = '1001'
SELECT * FROM BookReturnTransaction 

SELECT Users.UserID, FirstName + ' ' + MiddleName +' '+ LastName AS FullName  FROM Users where Users.UserName = 'admin'

SELECT UserID, FirstName, MiddleName, Lastname, Address, ContactNumber, Email, isAdmin FROM Users

SELECT * FROM Users



SELECT BorrowTrans.BookID, BorrowTrans.UserID, NBooks.Title, BorrowTrans.Quantity
            FROM
            (SELECT BookID, UserID, SUM(Quantity) AS Quantity FROM BorrowingTransaction GROUP BY BookID, UserID) AS BorrowTrans
            INNER JOIN
            (SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NBooks
            on NBooks.BookID = BorrowTrans.BookID


			Select TotalBorrowTrans.BookID, Title, TotalSupply , TotalBorrows FROM
            (SELECT BookID, sum(Quantity) AS TotalBorrows FROM BorrowingTransaction GROUP BY BookID) As TotalBorrowTrans
            INNER JOIN
            (SELECT BookID, sum(Supplies) AS TotalSupply FROM BookSupplyTransaction GROUP BY BookID) As TotalSupplyTrans
            INNER JOIN
            (SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NTotal
            ON NTotal.BookID = TotalSupplyTrans.BookID ON TotalBorrowTrans.BookID = NTotal.BookID