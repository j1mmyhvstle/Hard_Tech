/*----------------- Bang Userlogin --------------------------*/
use dbBilliardsManagement
go
--drop table Userlogin
create table Userlogin
	(
		username	varchar(100) primary key,
		password	nvarchar(250),
		screenname	nvarchar(250),
		status		int
	)
Go
--insert default userlogin ('admin','123','', 1)
insert into Userlogin values('admin','a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3','', 1);
Go

--drop procedure spUpdateUserlogin
create procedure spUpdateUserlogin
(
		@username		varchar(100),
		@password		varchar(250)				
)
as
Begin
		update Userlogin set 
		username=@username,
		password=@password
		where username = @username
End
go
--drop procedure spCheckLogin
create procedure spCheckLogin
(
		@username		varchar(100),
		@password		varchar(250)
)
	as
	Begin
				select	* from Userlogin
				where	username= @username
				and		password=@password				
	End
Go