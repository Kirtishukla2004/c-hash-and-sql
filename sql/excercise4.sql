select * from Sales.SalesOrderDetail;
select * from Sales.CurrencyRate;

create function show_order_detail (
@saleorderid int,
@currencycode varchar(4),
@dateoforder date
)
returns table 
as 
return (
select sod.Salesorderid,sod.OrderQty as quantity ,  sod.UnitPrice,
        sod.UnitPrice * COALESCE(cr.EndOfDayRate, 1) AS ConvertedUnitPrice,sod.productid ,cr.ToCurrencyCode,cr.FromCurrencyCode
from Sales.SalesOrderDetail sod left join Sales.CurrencyRate cr on 
cr.FromCurrencyCode ='USD'
  AND cr.ToCurrencyCode = @currencycode
        AND cr.CurrencyRateDate = @dateoforder
		 WHERE sod.SalesOrderID = @saleorderid

);
select * from dbo.show_order_detail (43853,'CAD','2011-05-31');