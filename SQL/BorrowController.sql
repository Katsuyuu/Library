
-- tylko przy 1 uzyciu - tworzenie bazy danych
create database Library
--

use Library

create table BorrowController
(
BorrowID			int primary key identity(1,1) not null,
"Index"				int foreign key references Users("Index") not null,
BookID				int foreign key references Books(BookID) not null,
"From"				datetime not null,
"To"				datetime not null
);

drop table BorrowController