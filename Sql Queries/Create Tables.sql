CREATE DATABASE JNHS_LIBRARYMS

USE JNHS_LIBRARYMS 


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

create table Books
(
	BookID int identity(1001,1) primary key,
	ISBN varchar(50),
	Category varchar(50),
	Title varchar(50),
	Author varchar(50),
	Abstract varchar(255),

)

create table BookSupplyTransaction
(
	SupplyTransID int identity(1001,1) primary key,
	BookID int,
	Supplies numeric

)

create table BorrowingTransaction
(
	BorrowTransID int identity(1001,1) primary key,
	BookID int,
	UserID int,
	Quantity numeric
	
)

create table BookReturnTransaction
(
	BookReturnTransID int identity(1001,1) primary key,
	BookID int,
	UserID int,
	Quantity numeric
)