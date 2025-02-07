
select * from Sales.Customer;

select CustomerID  from Sales.SalesOrderHeader where CustomerID =1;
SELECT c.CustomerID 
FROM Sales.Customer as c
left JOIN Sales.SalesOrderHeader as soh
    ON c.CustomerID = soh.CustomerID;

select customerid 
from Sales.Customer
where  CustomerID not in (select CustomerID from Sales.SalesOrderHeader );

