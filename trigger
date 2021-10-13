alter  trigger t1 
on categories
 after insert, update,delete
 as 
 begin
 
  if  exists(select 1 from inserted i)
  begin
  insert into auditCategories values ('New Record',getdate(),SUSER_NAME())
  end 
  else if exists (select 1 from deleted i)
  begin
  insert into auditCategories values ('Deleted record',getdate(),SUSER_NAME())
  end
  else
  begin
  insert into auditCategories values ('UpdatedRecord',getdate(),SUSER_NAME())
  end
   end
 --------------------------------------------
 select * from categories
 -------------------------------------------------
 update Categories
 set CategoryName='Sp Seafood'
 where CategoryID=8
 ------------------------------------------------

 insert into Categories(CategoryName,Description) values('new category','something')
 delete from categories 
 where CategoryID=10


 create table auditCategories
 (operationPerformed varchar(20))

 alter table auditCategories
 add dateOfChange datetime,
 changedBy varchar(50)

 sp_help auditCategories

 select USER_NAME()
 select SUSER_NAME()
 select * from auditCategories
