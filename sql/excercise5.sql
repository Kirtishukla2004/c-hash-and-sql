create procedure getpersondetails (
@firstname  varchar(20)=NUll
)
as 
begin 
set @firstname=coalesce(@firstname,'JHON')
select firstname,lastname 
from Person.Person
where FirstName =@firstname
END;
go
exec dbo.getpersondetails ;