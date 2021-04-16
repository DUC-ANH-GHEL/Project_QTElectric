USE QTElectric
GO
--CRUD OF tbl_user
CREATE PROC Insert_User(@user_name varchar(10),	@password char(32),	@mobile char(10),@email varchar(50),@gender bit,@full_name nvarchar(50),@status bit,@date_create datetime)
AS
BEGIN
INSERT INTO tbl_user(user_name, password, mobile, email, gender, full_name, status, date_create) VALUES (@user_name ,	@password ,	@mobile ,@email ,@gender ,@full_name ,@status ,@date_create )
END
GO

exec Insert_User @user_name = 'd',	@password = '3' ,	@mobile = 99 ,@email = 9 ,@gender = 0 ,@full_name = 'd' ,@status = 1 ,@date_create = '2020-01-12'
GO
CREATE PROC Get_User
AS
BEGIN
SELECT * FROM tbl_user
END
GO
CREATE PROC Update_User(@id int ,@user_name varchar(10),	@password char(32),	@mobile char(10),@email nvarchar(50),@gender bit,@full_name nvarchar(50),@status bit,@date_create datetime)
AS
BEGIN
UPDATE tbl_user
SET [user_name] = @user_name, [password] = @password, mobile = @mobile, email = @email, gender = @gender, full_name = @full_name, [status] = @status, date_create = @date_create
WHERE u_id = @id;
END
GO
exec Update_User @id = 6, @user_name = 'k', @password = 'k', @mobile = jjj, @email = 'jj', @gender = true, @full_name = 'kk', @status = true, @date_create = '2000-2-2'
CREATE PROC Delete_User(@id int)
AS
BEGIN
DELETE FROM tbl_user WHERE u_id = @id
END
GO
--CRUD OF tbl_values
CREATE PROC Insert_Values(@val_name varchar(50),@type_id int,@status bit,@date_create datetime)
AS
BEGIN
INSERT INTO [values](val_name, type_id,  status, date_create) VALUES (@val_name,@type_id ,@status ,@date_create )
END
GO
CREATE PROC Get_Values
AS
BEGIN
SELECT * FROM [values]
END
GO
CREATE PROC Update_Values(@id int,@val_name nvarchar(50), @type_id int , @status bit, @date_create datetime)
AS
BEGIN
UPDATE [values]
SET val_name = @val_name,[type_id] = @type_id, [status] = @status, date_create = @date_create
WHERE val_id = @id
END
GO

CREATE PROC Delete_Values(@id int)
AS
BEGIN
DELETE FROM tbl_differenced WHERE val_id = @id
DELETE FROM tbl_product WHERE val_id = @id
DELETE FROM [values] WHERE val_id = @id
END
GO
exec Delete_Values @id = 5
--CRUD OF [tbl_differenced]
CREATE PROC Insert_Differenced(@diff_name varchar(3), @val_id int, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_differenced(diff_name, val_id, [status], date_create) VALUES (@diff_name, @val_id, @status, @date_create)
END
GO
CREATE PROC Get_Differenced
AS
BEGIN
SELECT * FROM tbl_differenced
END
GO
CREATE PROC Update_Differenced(@id int,@diff_name varchar(3), @val_id int, @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_differenced
SET diff_name = @diff_name, val_id = @val_id, [status] = @status, date_create = @date_create
WHERE diff_id = @id;
END
GO
CREATE PROC Delete_Differenced(@id int)
AS
BEGIN
DELETE FROM tbl_differenced WHERE diff_id = @id;
DELETE FROM tbl_product WHERE diff_id = @id;
END
GO

--CRUD OF tbl_types
CREATE PROC Insert_Types(@type_name nvarchar(50), @cat_id int, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_types([type_name] , cat_id, [status], date_create) VALUES (@type_name, @cat_id, @status, @date_create)
END
GO
CREATE PROC Get_Types
AS
BEGIN
SELECT * FROM tbl_types
END
GO
CREATE PROC Update_Types(@id int,@type_name nvarchar(50), @cat_id int, @status bit, @date_create datetime )
AS
BEGIN
UPDATE tbl_types
SET type_name = @type_name, cat_id = @cat_id, [status] = @status, date_create = @date_create
WHERE type_id = @id;
END
GO
CREATE PROC Delete_Types(@id int)
AS
BEGIN
DELETE FROM tbl_types WHERE type_id = @id
DELETE FROM tbl_product WHERE type_id = @id
DELETE FROM [values] WHERE type_id = @id
END
GO

--CRUD OF thb_customer
CREATE PROC Insert_Customer(@fullname nvarchar(50), @mobile nchar(10), @email varchar(50), @address nvarchar(250), @gender bit, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_customer(fullName, mobile, email,[address], gender, [status], date_create) VALUES (@fullname, @mobile, @email, @address, @gender, @status, @date_create) 
END
GO
CREATE PROC Get_Customer
AS
BEGIN
SELECT * FROM tbl_customer
END
GO
CREATE PROC Update_Customer(@id int, @fullname nvarchar(50), @mobile nchar(10), @email varchar(50), @address nvarchar(250), @gender bit, @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_customer
SET fullName = @fullname, mobile = @mobile, email = @email, address = @address, gender = @gender, [status] = @status, date_create = @date_create
WHERE cus_id = @id
END
GO
CREATE PROC Delete_Customer(@id int)
AS
BEGIN
DELETE FROM tbl_customer WHERE cus_id = @id
DELETE FROM tbl_order WHERE cus_id = @id
END
GO
--CRUD OF tbl_order
CREATE PROC Insert_Order(@cus_id int, @or_name nvarchar(100), @status bit, @date_create datetime )
AS
BEGIN
INSERT INTO tbl_order(cus_id, or_name, status, date_create) VALUES (@cus_id, @or_name, @status, @date_create)
END
GO
CREATE PROC Get_Order
AS
BEGIN
SELECT * FROM tbl_order
END
GO
CREATE PROC Update_Order(@id int, @cus_id int, @or_name nvarchar(100), @status bit, @date_create datetime )
AS
BEGIN
UPDATE tbl_order
SET cus_id = @cus_id, or_name = @or_name, status = @status, date_create = @date_create
WHERE or_id = @id
END
GO
CREATE PROC Delete_Order(@id int)
AS
BEGIN
DELETE FROM tbl_order WHERE or_id = @id
DELETE FROM tbl_orderDetail WHERE order_id = @id
END
GO
Create proc getOrderByCus @cus_id int
as
begin
	select * from tbl_order
	where cus_id = @cus_id
end
GO
--CRUD OF tbl_orderDetail
CREATE PROC Insert_OrderDetail(@orderDetail_id varchar(100), @order_id varchar(max), @pro_id int,  @amount_in int, @amount_out int, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_orderDetail(or_detail_id, order_id, pro_id, amount_in, amount_out, status, date_create) VALUES (@orderDetail_id, @order_id, @pro_id, @amount_in, @amount_out, @status, @date_create)
END
GO

CREATE PROC Get_OrderDetail
AS
BEGIN
SELECT * FROM tbl_orderDetail
END
GO
CREATE PROC Update_OrderDetail(@id varchar(max), @order_id int, @pro_id int,   @amount_in int, @amount_out int, @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_orderDetail
SET order_id = @order_id, pro_id = @pro_id,  amount_in = @amount_in, amount_out = @amount_out, status = @status, date_create = @date_create
WHERE or_detail_id = @id
END
GO

CREATE PROC Delete_OrderDetail(@id int)
AS
BEGIN
DELETE FROM tbl_orderDetail WHERE or_detail_id = @id
END
GO
--CRUD OF tbl_category
CREATE PROC Insert_Category(@cat_name nvarchar(50), @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_category(cat_name, status, date_ceate) VALUES (@cat_name, @status, @date_create)
END
GO
CREATE PROC Get_Category
AS
BEGIN
SELECT * FROM tbl_category
END
GO
CREATE PROC Update_Category(@id int, @cat_name nvarchar(50), @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_category
SET cat_name = @cat_name, status = @status, date_ceate = @date_create
WHERE cat_id = @id
END
GO
CREATE PROC Delete_Category(@id int)
AS
BEGIN
DELETE FROM tbl_category WHERE cat_id = @id
DELETE FROM tbl_product WHERE cat_id = @id
DELETE FROM tbl_types WHERE cat_id = @id
END
GO
--CRUD OF tbl_Product
CREATE PROC Insert_Product(@cat_id int, @type_id int, @val_id int, @diff_id int,@qrname varchar(50), @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_product(cat_id, [type_id], val_id, diff_id, qrname, [status], date_create) VALUES (@cat_id , @type_id , @val_id , @diff_id ,@qrname , @status , @date_create)
END
GO
CREATE PROC Select_Product
AS
BEGIN
SELECT * FROM tbl_product
END
GO
CREATE PROC Update_Product(@id int , @cat_id int, @type_id int, @val_id int, @diff_id int, @qrname varchar(50), @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_product
SET cat_id = @cat_id, type_id = @type_id, val_id = @val_id, diff_id = @diff_id,qrname = @qrname, status = @status, date_create = @date_create
WHERE pro_id = @id
END
GO
CREATE PROC Delete_Product(@id int)
AS
BEGIN
DELETE FROM tbl_product WHERE pro_id = @id
DELETE FROM tbl_orderDetail WHERE pro_id = @id
END
GO
--GET VALUES
CREATE PROC GetValues
AS
BEGIN
SELECT val_id, val_name FROM [values]
END
GO

drop proc GetByValues
SELECT  *  From [values]  INNER JOIN tbl_types  ON [values].type_id = tbl_types.type_id
select * from [values]
select * from tbl_types

CREATE PROC GetByCat(@cat_id int)
AS
BEGIN
SELECT * FROM tbl_types WHERE cat_id = @cat_id
END
go
CREATE PROC GetByType(@type_id int)
AS
BEGIN
SELECT * FROM [values] WHERE type_id = @type_id
END
GO
CREATE PROC GetByValues(@val_id int)
AS
BEGIN
SELECT * FROM tbl_differenced WHERE val_id = @val_id
END
GO
exec GetByCat @cat_id = 13

--CHECK PASSWORD
CREATE PROC CheckPass(@user_name varchar(10), @password char(32))
AS
BEGIN
SELECT * FROM tbl_user WHERE user_name = @user_name AND password = @password
END
GO

exec CheckPass @user_name = 'duc',  @password = '827ccb0eea8a706c4c34a16891f84e7b'

-- Proc Search
Create proc GetCusBySearch @search Nvarchar(100)
as
begin
select * from tbl_customer 
where fullName like '%'+@search+'%' OR email like '%'+@search+'%' OR mobile like '%'+@search+'%'
end
go

Create proc GetCatBySearch @search Nvarchar(100)
as
begin
select * from tbl_category 
where cat_name like '%'+@search+'%' 
end
go

Create proc GetDiffBySearch @search Nvarchar(100)
as
begin
select * from tbl_differenced
where diff_name like '%'+@search+'%' 
end
go
Create proc GetTypeBySearch @search Nvarchar(100)
as
begin
select * from tbl_types
where type_name like '%'+@search+'%' 
end
go

Create proc GetUserBySearch @search Nvarchar(100)
as
begin
select * from tbl_user 
where full_name like '%'+@search+'%' OR user_name like '%'+@search+'%' OR email like '%'+@search+'%' OR mobile like '%'+@search+'%'
end
go

Create proc GetValueBySearch @search Nvarchar(100)
as
begin
select * from [values]
where val_name like '%'+@search+'%' 
end
go

Create proc CheckProduct(@cat_id int, @type_id int, @value_id int , @diff_id int)
as
begin
select * from tbl_product where cat_id = @cat_id and type_id = @type_id and val_id = @value_id and diff_id = @diff_id
end
go

Create proc Select7tbl
as
begin
select tbl_category.cat_name, tbl_types.type_name, tbl_differenced.diff_name, [values].val_name, tbl_orderDetail.amount_in, tbl_orderDetail.amount_out, tbl_order.or_id, tbl_order.date_create from tbl_category, tbl_types, tbl_differenced, [values], tbl_orderDetail, tbl_order
INNER JOIN tbl_product ON tbl_category.cat_id =tbl_product.cat_id ON tbl_types.type_id = tbl_product.type_id
INNER JOIN tbl_product ON tbl_differenced.diff_id = tbl_product.diff_id
INNER JOIN tbl_product ON [values].val_id = tbl_product.val_id
INNER JOIN tbl_product ON tbl_orderDetail.pro_id = tbl_product.pro_id
INNER JOIN tbl_order ON tbl_orderDetail.order_id = tbl_order.or_id
end
go

Create proc GetOrderDetailbyorid(@or_id int)
as
begin
select c.cat_name, t.type_name, d.diff_name, v.val_name, cus.cus_id, cus.fullName,
	oDetail.or_detail_id, oDetail.amount_in, oDetail.amount_out, oDetail.pro_id, oDetail.status
from tbl_orderDetail as oDetail 
	join tbl_order as o on oDetail.order_id = 1
	join tbl_product as p on oDetail.pro_id = p.pro_id
	join tbl_category as c on p.cat_id = c.cat_id
	join tbl_types as t on p.type_id = t.type_id
	join tbl_differenced as d on p.diff_id = d.diff_id
	join [values] as v on p.val_id = v.val_id 
	join tbl_customer as cus on o.cus_id = cus.cus_id 
	group by oDetail.or_detail_id, oDetail.amount_in, oDetail.amount_out , oDetail.pro_id, oDetail.status, 
	c.cat_name, t.type_name, d.diff_name, v.val_name, cus.cus_id, cus.fullName
end
go

Create proc GetOrderbyId(@id int)
as
begin
select * from tbl_order where or_id = @id
end
go

