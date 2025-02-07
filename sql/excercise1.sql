/*Excersize 1*/
select firstname ,lastname 
from DimEmployee
where FirstName Like 'B%';
SELECT FirstName, LastName
FROM DimEmployee
WHERE Title = 'Design Engineer' 
   OR Title = 'Tool Designer' 
   OR Title = 'Marketing Assistant';

SELECT table_name, column_name
FROM information_schema.columns
WHERE column_name IN ('Name', 'Color', 'Weight');
select englishproductname ,weight,color
from DimProduct
where Weight= (select MAX(weight)
from DimProduct);
SELECT table_name, column_name
FROM information_schema.columns
WHERE column_name IN ('Description', 'MaxQty');

SELECT 
    ISNULL(MaxQty, 0.00) AS MaxQty
FROM 
    DimPromotion;

SELECT  ProductDescription AS Description
FROM 
    FactAdditionalInternationalProductDescription;
