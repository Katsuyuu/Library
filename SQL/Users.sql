
-- tylko przy 1 uzyciu - tworzenie bazy danych
create database Library
--

use Library

create table Users
(
"Index"				int primary key not null,
"Password"			varchar(255) not null,
FirstName			varchar(255) not null,
LastName			varchar(255) not null,
BirthDate			date,
Sex					varchar(2) not null check(Sex in('M','K')),
Email				varchar(255) not null,
City				varchar(255),
Street				varchar(255),
HouseNumber			varchar(10),
ApartmentNumber		int,
IsAdmin				bit not null,
);

drop table BorrowController
drop table Users

select * from Users

insert into Users
values (116925, 'aaa', 'Adrian', 'Borowiec', '05-11-1994', 'M', 'adrian.borowiec@student.put.poznan.pl', 'Poznan', 'os.Batorego', '82M', '15', 1)





