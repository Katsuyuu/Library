use Library

create table Users
(
"UserID"		int primary key identity(1,1) not null,
"FirstName"		varchar(255) not null,
"LastName"		varchar(255) not null,
"BirthDate"		date,
"Address"		varchar(255),
"City"			varchar(255),
"IndexNumber"	int not null,
"IsAdmin"		bit not null,
);

select * from Users