/*-------------------- table Receiption -------------------*/
use dbBilliardsManagement
go
	-- drop table Receiption
	create table Receiption
	(
			id			bigint primary key,
			deskid		bigint,
			deskname		nvarchar(500),
			deskfee		float,
			timebegin		datetime,
			timefinish		datetime,
			totalminute		int,
			fee		float,
			total		float,
			status		int
	)
	go
	-- drop function fcgetIdReceiption
	Create function fcgetIdReceiption()
		returns bigint
		As
		Begin
			Declare @Id bigint
			Declare @MaxId bigint
			
			Select @MaxId = MAX(id) from Receiption
							
			if exists (select id from Receiption)
				set @Id = @MaxId+1
			else
				set @Id = 1
			return @Id
	End
	go
	-- drop procedure spInsertReceiption
	create procedure spInsertReceiption
	( 
			@id			bigint,
			@deskid		bigint,
			@deskname		nvarchar(500),
			@deskfee		float,
			@timebegin		datetime,
			@status		int
	)
	as
	Begin
		insert into Receiption(id, deskid, deskname, deskfee, timebegin, status)
		values(@id, @deskid, @deskname, @deskfee, @timebegin, @status)
	End
	go
	-- drop procedure spUpdateTimebeginReceiption
	create procedure spUpdateTimebeginReceiption
	(
			@id				bigint,
			@timebegin		datetime
	)
	as
	Begin
		update Receiption set 
			timebegin = @timebegin
		where id =@id
	End
	go
	-- drop procedure spUpdateReceiptionFinish
	create procedure spUpdateReceiptionFinish
	(
			@id				bigint,
			@timefinish		datetime,
			@totalminute		int,
			@fee		float,
			@total		float,
			@status		int
	)
	as
	Begin
		update Receiption set 
			timefinish = @timefinish,
			totalminute =@totalminute,
			fee =@fee,
			total =@total,
			status =@status
		where id =@id
	End
	go
	-- drop procedure spFindReceiptionByDeskid
	create procedure spFindReceiptionByDeskid
	(
			@deskid		bigint
	)
	as
	Begin
		select id, deskid, deskname, (select format(deskfee,'#,0')) as deskfee,
		(SELECT FORMAT(timebegin,'HH:mm dd/MM/yyyy')) as timebegin,
		(SELECT FORMAT(timefinish,'HH:mm dd/MM/yyyy')) as timefinish,
		totalminute, (select format(fee,'#,0')) as fee, 
		(select format(total,'#,0')) as total, 
		CASE
			WHEN status = 0 THEN N'Đang chơi'
			ELSE N'Hoàn thành'
		END AS status 
		from Receiption where deskid = @deskid and status =0 order by id desc
	End
	go
	-- drop procedure spTransferReceiption
	create procedure spTransferReceiption
	( 
			@id			bigint,
			@deskid		bigint,
			@deskname		nvarchar(500),
			@deskfee		float,
			@timebegin		datetime
	)
	as
	Begin
		update Receiption set 
			deskid = @deskid,
			deskname =@deskname,
			deskfee =@deskfee,
			timebegin =@timebegin
		where id =@id
	End
	go