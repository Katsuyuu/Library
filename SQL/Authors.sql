
-- tylko przy 1 uzyciu - tworzenie bazy danych
create database Library
--


create table Authors
(
AuthorID			int primary key identity(1,1) not null,
FirstName			varchar(255) not null,
LastName			varchar(255) not null,
BirthDate			date,
Sex					varchar(2) not null check(Sex in('M','K')),
Country				varchar(255),
City				varchar(255),
);

drop table Authors


select * from Authors

insert into Authors(FirstName, LastName, Sex, Country, City)
values ('Jerzy', 'Bartoszek', 'M', 'Polska', 'Poznan')
