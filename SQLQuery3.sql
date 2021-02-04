--Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City='Berlin'

--case insensitive
Select * from Products where CategoryID=1 or CategoryID=3
Select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by ProductName
select * from Products order by CategoryID,ProductName
select * from Products order by UnitPrice asc   ---ascending(Artan)
select * from Products order by UnitPrice desc  ---descending(Düşen)
select * from Products where CategoryID=1 order by UnitPrice desc 

Select count(*) from Products
Select count(*) Adet from Products where CategoryID=2


select CategoryID,count(*) from Products group by CategoryID

--Ürün sayısı 10dan az olan kategorileri listele
select CategoryID,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10


select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID

select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID


select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null







