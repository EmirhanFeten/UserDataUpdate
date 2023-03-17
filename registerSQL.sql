create database registerdb
use registerdb

create table registertbl 
(sNo int primary key identity,
fName nvarchar(50) not null,
lName nvarchar(50)not null,
usName nvarchar(50)not null,
mail nvarchar(50)not null,
psw nvarchar(50)not null)