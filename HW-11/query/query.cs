//using HW_11.Entities;
//using System.Diagnostics.Metrics;
//using System.Diagnostics;
//using System.Xml.Linq;

//--ALTER TABLE Customers
//--ALTER COLUMN id int NOT NULL;

//--ALTER TABLE Customers
//--ALTER COLUMN name nvarchar(50) NOT NULL;

//--alter table customers
//--ADD PRIMARY KEY (ID);

//--ALTER TABLE products
//--ALTER COLUMN ID int NOT NULL;

//--alter table products
//--ADD PRIMARY KEY (ID);

//--ALTER TABLE categories
//--ALTER COLUMN ID int NOT NULL;

//--alter table categories
//--ADD PRIMARY KEY (ID);

//--ALTER TABLE orders
//--ALTER COLUMN ID int NOT NULL;

//--alter table orders
//--ADD PRIMARY KEY (ID);

//--ALTER TABLE products
//--ADD FOREIGN KEY (categoryid) REFERENCES categories(id);

//--ALTER TABLE OrDERS
//--ADD FOREIGN KEY (customerid) REFERENCES customers(id);

//--ALTER TABLE orders
//--ADD FOREIGN KEY (productid) REFERENCES products(id);

//--select[Name],Price from Products
//--where Price>500;

//--select year(Orders.OrderDate),sum(Products.Price * Orders.TotalAmount)
//--from dbo.Orders
//--inner
//  join Products on Orders.ProductId = Products.Id
//--group by year(OrderDate)

//--select Categories.[Name],sum(Products.Price * Orders.TotalAmount)
//--from dbo.Orders
//--inner
//  join Products on Orders.ProductId = Products.Id
//--inner
//  join Categories on Products.CategoryId = Categories.Id
//--group by Categories.[Name]

//--select[Name], Price from Products
//--order by Price desc

//--select Customers.[Name] ,COUNT(*)
//--from Orders
//--inner
//  join Customers on Orders.CustomerId = Customers.Id
//--group by Customers.[Name]



//--select Categories.[Name] ,avg(Products.Price)
//--from dbo.Products
//--inner
//  join Categories on Products.CategoryId = Categories.Id
//--group by Categories.[Name]

//--select Products.[Name], Categories.[Name]
//--from Products
//--inner
//  join Categories on Products.CategoryId = Categories.Id
//--order by Categories.[Name], products.[Name]

//--select Categories.[Name],sum(Products.Price * Orders.TotalAmount)
//--from dbo.Orders
//--inner
//  join Products on Orders.ProductId = Products.Id
//--inner
//  join Categories on Products.CategoryId = Categories.Id
//--where year(OrderDate) = 2023
//--
//  group by Categories.[Name]

//--select year(OrderDate) as [year] ,month(Orders.OrderDate) as [month],sum(Products.Price * Orders.TotalAmount) as [sum]
//--from dbo.Orders
//--inner
//  join Products on Orders.ProductId = Products.Id
//--group by year(OrderDate), month(OrderDate)

//--select Customers.[Name] ,sum(Products.Price * Orders.TotalAmount)
//--from Orders
//--inner
//  join Products on Orders.ProductId = Products.Id
//--inner
//  join Customers on Orders.CustomerId = Customers.Id
//--group by Customers.[Name]

//--select Categories.[Name], COUNT(*)
//--from Orders
//--inner
//  join Products on Orders.ProductId = Products.Id
//--inner
//  join Categories on Products.CategoryId = Categories.Id
//--group by Categories.[Name]

//--select Customers.[Name] ,COUNT(*) as orders
//--from Orders
//--inner
//  join Customers on Orders.CustomerId = Customers.Id
//--group by Customers.[Name]
//--order by orders desc

//--select YEAR(OrderDate) as [year], COUNT(*)
//--from Orders
//--group by YEAR(OrderDate)

//select Products.[Name], COUNT(*) as quantity
//from Orders
//inner join Products on Orders.ProductId = Products.Id
//group by Products.[Name]
