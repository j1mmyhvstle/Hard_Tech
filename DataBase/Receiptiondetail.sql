	/*-------------------- table Receiptiondetail -------------------*/	
	use dbBilliardsManagement
go
	-- drop table Receiptiondetail
	create table Receiptiondetail
	(
			id			bigint primary key,
			receiptionid		bigint foreign key references Receiption(id),
			name			nvarchar(500),
			unit		nvarchar(500),
			price		float,
			quantum		int,
			total		float
	)
	go
	-- drop function fcgetIdReceiptiondetail
	Create function fcgetIdReceiptiondetail()
		returns bigint
		As
		Begin
			Declare @Id bigint
			Declare @MaxId bigint
			
			Select @MaxId = MAX(id) from Receiptiondetail
							
			if exists (select id from Receiptiondetail)
				set @Id = @MaxId+1
			else
				set @Id = 1
			return @Id
	End
	go
	-- drop procedure spInsertReceiptiondetail
	create procedure spInsertReceiptiondetail
	( 
			@id			bigint,
			@receiptionid		bigint,
			@name			nvarchar(100),
			@unit		nvarchar(100),
			@price		float,
			@quantum		int,
			@total		float
	)
	as
	Begin
		insert into Receiptiondetail(id, receiptionid, name, unit, price, quantum, total)
		values(@id, @receiptionid, @name, @unit, @price, @quantum, @total)
	End
	go
	-- drop procedure spUpdateReceiptiondetail
	create procedure spUpdateReceiptiondetail
	(
			@id			bigint,
			@name			nvarchar(100),
			@unit		nvarchar(100),
			@price		float,
			@quantum		int,
			@total		float
	)
	as
	Begin
		update Receiptiondetail set 
			name = @name,
			unit = @unit,
			price = @price,
			quantum = @quantum,
			total =@total
		where id =@id
	End
	go
	--drop procedure spDeleteReceiptiondetail
	create procedure spDeleteReceiptiondetail
	(
			@id		bigint
	)
	as
	Begin
		delete from Receiptiondetail where id=@id
	End
	go
	-- drop procedure spFindByReceiptionid
	create procedure spFindByReceiptionid
	(
			@receiptionid		bigint
	)
	as
	Begin
		select id, name, unit, (select format(price,'#,0')) as price, 
		quantum, (select format(total,'#,0')) as total  
		from Receiptiondetail where receiptionid = @receiptionid
	End
	go