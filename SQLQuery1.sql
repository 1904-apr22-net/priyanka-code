create table Customers(Id int not null identity,FirstName varchar(15)not null,LastName varchar(15) not null,Cardnumber varchar(10)not null,constraint Pk_Id primary key(Id));
create table Products(ProdId int not null,Name varchar(10)not null,Price decimal(6,3)not null,constraint Pk_ProdId primary key(ProdId));
insert into Products(ProdId,Name,Price) values(10,'iphone',200);
insert into Products(ProdId,Name,Price) values(11,'iphone x',300);
--create table Orders(,Id)
--insert into Customers(Id,FirstName,LastName,Cardnumber) values(1,'Priya','Sunny',100);
create table Customerss(CId int not null,FirstName varchar(15)not null,LastName varchar(15) not null,Cardnumber varchar(10)not null,constraint Pk_CId primary key(CId));
insert into Customerss(CId,FirstName,LastName,Cardnumber) values(1,'Priya','Sunny',100);
insert into Customerss(CId,FirstName,LastName,Cardnumber) values(2,'Priyanka','Sunny',101);
--create table Orders(OId int not null,ProduId int not null,Constraint FK_ProduId(ProduId) references Products(ProdId),CId int not null,Constraint FK_(ProduId) references Products(ProdId) );
select * from Products;
select * from Customerss;
insert into Customerss(CId,FirstName,LastName,Cardnumber) values(3,'Tina','Smith',102);
insert into Products(ProdId,Name,Price) values(12,'iphone xs',400);
update Products set Price='250' where Price='200'



