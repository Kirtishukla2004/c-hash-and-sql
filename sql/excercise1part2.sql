SELECT AVG(AverageRate) AS OverallAverageRate
FROM Sales.CurrencyRate
WHERE FromCurrencyCode = 'USD' 
  AND ToCurrencyCode = 'GBP' 
  and ModifiedDate like '2005%';
select  averagerate,FromCurrencyCode ,ToCurrencyCode
from Sales.CurrencyRate;
select * 
from Sales.CurrencyRate;
select  ROW_NUMBER() OVER (ORDER BY FirstName) AS RowNumber,
    FirstName,
    LastName
from Person.Person
where FirstName like '%ss%';
select AVG(CommissionPct)
from Sales.SalesPerson;
select * from Sales.SalesPerson;
select  
BusinessEntityID,
CommissionPct,
Case 
 when CommissionPct =0 then 'band0'
 when CommissionPct between 0.1 and 1 then 'band1'
 when CommissionPct between 1.1 and 1.5 then 'band2'
 else 'band3'
End as commisionband 
 from Sales.SalesPerson;

EXEC sp_helptext 'dbo.uspGetEmployeeManagers';

declare @i int =10
WHILE @i <= 30
BEGIN
    EXEC dbo.uspGetEmployeeManagers @BusinessEntityID = @i;
    set @i =@i+1
	end;
SELECT BusinessEntityID,FirstName,LastName
FROM Person.Person 
WHERE FirstName = 'James' and LastName='Hamilton' ;
EXEC dbo.uspGetEmployeeManagers @BusinessEntityID = 1011;

declare @empid  int;
set @empid =( select MIN(BusinessEntityID)
from Person.Person
where FirstName='Ruth' and LastName='Ellerbrock');
EXEC dbo.uspGetEmployeeManagers @BusinessEntityID = @empid;
declare @pid int;
set @pid =(select MAX(ProductID )
from Production.Product);

EXEC dbo.ufnGetStock @productid = @pid;
