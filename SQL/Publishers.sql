
-- tylko przy 1 uzyciu - tworzenie bazy danych
create database Library
--


create table Publishers
(
PublisherID			int primary key identity(1,1) not null,
Name				varchar(255) not null,
City				varchar(255),
Street				varchar(255),
HouseNumber			varchar(10),
ApartmentNumber		int,
);

