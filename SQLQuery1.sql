SELECT ProductName AS [Ürün], SUM([Order Details].UnitPrice * Quantity)
AS [Kazanç] FROM [Order Details] 
inner join Products ON [Order Details].ProductID=Products.ProductID 
GROUP BY ProductName ORDER BY ProductName



select ProductName AS [ ÜRÜN ], SUM([Order Details].UnitPrice*Quantity) AS [Kazanç]
from [Order Details]
inner join Products on [Order Details].ProductID=Products.ProductID
group by ProductName order by [Kazanç] desc

