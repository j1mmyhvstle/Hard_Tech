/*-------------------- table Menu -------------------*/	
use dbBilliardsManagement
go
	-- drop table Menu
	create table Menu
	(
			id			bigint primary key,
			name		nvarchar(500),
			unit		nvarchar(500),
			price		float,
			description	nvarchar(1000)
	)
	go
	-- drop function fcgetIdMenu
	Create function fcgetIdMenu()
		returns bigint
		As
		Begin
			Declare @Id bigint
			Declare @MaxId bigint
			
			Select @MaxId = MAX(id) from Menu
							
			if exists (select id from Menu)
				set @Id = @MaxId+1
			else
				set @Id = 1
			return @Id
	End
	go
	
	-- drop procedure spInsertMenu
	create procedure spInsertMenu
	( 
			@id			bigint,
			@name		nvarchar(500),
			@unit		nvarchar(500),
			@price		float,
			@description	nvarchar(1000)
	)
	as
	Begin
		insert into Menu(id, name, unit, price, description)
		values(@id, @name, @unit, @price, @description)
	End
	go
	-- drop procedure spUpdateMenu
	create procedure spUpdateMenu
	(
			@id			bigint,
			@name		nvarchar(500),
			@unit		nvarchar(500),
			@price		float,
			@description	nvarchar(1000)
	)
	as
	Begin
		update Menu set 
			name =@name,
			unit =@unit,
			price =@price,
			description =@description
		where id =@id
	End
	go
	--drop procedure spDeleteMenu
	create procedure spDeleteMenu
	(
			@id		bigint
	)
	as
	Begin
		delete from Menu where id=@id
	End
	go
	-- drop procedure spFindViewMenu
	create procedure spFindViewMenu
	as
	Begin
		select id, name, unit, (select format(price,'#,0')) as price, description from Menu
	End
	Go
