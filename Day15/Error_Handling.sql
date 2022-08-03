--Errors handling----------
begin try
declare @num INT
----Divide by Zero to generate error---
Set @num=6/0
Print 'Thsi is will not execute'
End try
begin catch
Select ERROR_MESSAGE() as ErrorMessage,
ERROR_NUMBER() as ErrorNumber,
ERROR_SEVERITY() as ErrorSeverity ,ERROR_PROCEDURE() as ErrorProcedure ,ERROR_STATE() as ErrorState ,
ERROR_LINE() as ErrorLine;

End Catch;

select * from master.dbo.sysmessages
where severity=16 and error=8134