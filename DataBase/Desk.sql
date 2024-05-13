/*-------------------- table Desk -------------------*/	
use dbBilliardsManagement
go
	-- drop table Desk
	create table Desk
	(
			id			bigint primary key,
			name		nvarchar(500),
			style		int,
			description	nvarchar(1000),
			fee			float,
			status		int
	)
	go
	-- drop function fcgeneralDeskId
	Create function fcgeneralDeskId()
		returns bigint
		As
		Begin
			Declare @Id bigint
			Declare @MaxId bigint
			
			Select @MaxId = MAX(id) from Desk
							
			if exists (select id from Desk)
				set @Id = @MaxId+1
			else
				set @Id = 1
			return @Id
	End
	go
	-- drop procedure spInsertDesk
	create procedure spInsertDesk
	( 
			@id				bigint,
			@name			nvarchar(500),
			@style			int,
			@description	nvarchar(1000),
			@status			int,
			@fee			float
	)
	as
	Begin
		insert into Desk(id, name, style, description, status, fee)
		values(@id, @name, @style, @description, @status, @fee)
	End
	go
	-- drop procedure spUpdateDesk
	create procedure spUpdateDesk
	(
			@id				bigint,
			@name			nvarchar(500),
			@style			int,
			@description	nvarchar(1000),
			@status			int,
			@fee			float
	)
	as
	Begin
		update Desk set 
			style = @style,
			name =@name,
			description =@description,
			status =@status,
			fee =@fee
		where id =@id
	End
	go
	--drop procedure spDeleteDesk
	create procedure spDeleteDesk
	(
			@id		bigint
	)
	as
	Begin
		delete from Desk where id=@id
	End
	go
	-- drop procedure spFindDesk
	create procedure spFindDesk
	as
	Begin
	select id, name, description,
		CASE
			WHEN style = 0 THEN N'Bida lỗ'
			ELSE N'Bida france'
		END AS style,
		CASE
			WHEN status = 0 THEN N'Đang nâng cấp'
			WHEN status = 1 THEN N'Đang sử dụng'
			ELSE N'Chưa sử dụng'
		END AS status,
		(select format(fee,'#,0')) as fee
    from Desk
	End
	go
	-- drop procedure spFindByStatusDesk
	create procedure spFindByStatusDesk
	(
			@status		int
	)
	as
	Begin
		select * from Desk where status=@status
	End
	go
	--drop procedure spUpdateStatusDesk
	create procedure spUpdateStatusDesk
	(
			@id		bigint,
			@status int
	)
	as
	Begin
		update Desk set status = @status where id=@id
	End
	go
	-- drop procedure spFindAllDesk
	create procedure spFindAllDesk
	as
	Begin
		select * from Desk
	End
	go
	-- drop procedure spFindByDeskid
	create procedure spFindByDeskid
	(
		@id				bigint
	)
	as
	Begin
		select * from Desk where id = @id;
	End
	go
