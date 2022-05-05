create database atmP;
go

use atmP;
go


create table userTable(
	UserName varchar(25),
	UserLName varchar(25),
	AccNumber  varchar(5),
	AccPinNumber varchar(5),
	Balance money
);
go

create table machine(
machineID varchar(5) primary key,
twentyBills int,
tenBills int,
);
go

insert into machine values ('001', 100, 100);
go

insert into userTable values ('John', 'Doe', '12345', '12345', $1500);
go