create database ProductManager
go

use ProductManager
go

drop table Category

Create table Product
(
	id INT PRIMARY KEY identity(1,1),
	Name nvarchar(255),
	Price DECIMAL (18,2),
	Image nvarchar(max),
	CategoryId int,
	CreateDate datetime,
	UpdatedDate datetime,
	CreatBy nvarchar(255),
	UpdateBy nvarchar(255),
	IsDeleted bit,
)

Create table Category
(
	Id INT PRIMARY KEY identity(1,1),
	Name nvarchar(255),
	CreateDate datetime,
	UpdatedDate datetime,
	CreatBy nvarchar(255),
	UpdateBy nvarchar(255),
	IsDeleted bit,

)

alter table Product 
add Unit varchar(50)

select * from Product
select * from Category
Insert into Category (Name, CreateDate, UpdatedDate, CreatBy, UpdateBy, IsDeleted)
values
( N'Rau củ', GETDATE(), GETDATE(), 'khai','khai',0  ),
( N'Hoa quả', GETDATE(), GETDATE(), 'khai','khai',0  ),
( N'Nước ép', GETDATE(), GETDATE(), 'khai','khai',0  )

insert into Product(Name, Price, Image, CategoryId, CreateDate, UpdatedDate, CreatBy, UpdateBy, IsDeleted, Unit)
values
(N'Rau cải thảo', 10000, '/images/product1.pg',1, GETDATE(), GETDATE(), 'khai','khai',0,'Kg'  ),
(N'Rau muống', 21000, '/images/product2.pg',1, GETDATE(), GETDATE(), 'khai','khai',0,'Kg'  ),
(N'Rau xà lách', 11000, '/images/product3.pg',1, GETDATE(), GETDATE(), 'khai','khai',0,'Kg'  ),
(N'Vải thiều', 99000, '/images/product4.pg',2, GETDATE(), GETDATE(), 'khai','khai',0 ,'Kg' ),
(N'Sầu riêng', 11000, '/images/product5.pg',2, GETDATE(), GETDATE(), 'khai','khai',0 ,'Kg' ),
(N'Dưa hấu', 33000, '/images/product6.pg',2, GETDATE(), GETDATE(), 'khai','khai',0 ,'Kg' ),
(N'Sinh tố bơ', 33000, '/images/product7.pg',3, GETDATE(), GETDATE(), 'khai','khai',0 ,'Ly' ),
(N'Trà chanh', 33000, '/images/product8.pg',3, GETDATE(), GETDATE(), 'khai','khai',0 ,'Ly' ),
(N'Trà quất', 33000, '/images/product9.pg',3, GETDATE(), GETDATE(), 'khai','khai',0 ,'Ly' )

update Product 
set Image = '~/images/Chan dung-khai.png'
where IsDeleted = 0