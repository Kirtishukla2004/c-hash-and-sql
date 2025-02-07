select * from Sales.SalesOrderHeader;
select top 5 AccountNumber , subtotal,ModifiedDate
from Sales.SalesOrderHeader 
where SubTotal >=70000;

