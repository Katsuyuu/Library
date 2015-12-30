
-- tylko przy 1 uzyciu - tworzenie bazy danych
create database Library
--

use Library

create table Books
(
BookID				int primary key identity(1,1) not null,
AuthorID			int foreign key references Authors(AuthorID) not null,
Title				varchar(255) not null,
PublisherID			int foreign key references Publishers(PublisherID) not null,
PublishYear			int not null,
Quantity			int not null default(1),
BorrowLimit			int not null default(14),
);

drop table Books

