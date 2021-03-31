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
CREATE PROC Update_User(@id int ,@user_name varchar(10),	@password char(32),	@mobile char(10),@email varbinary(50),@gender bit,@full_name nvarchar(50),@status bit,@date_create datetime)
AS
BEGIN
UPDATE tbl_user
SET [user_name] = @user_name, [password] = @password, mobile = @mobile, email = @email, gender = @gender, full_name = @full_name, [status] = @status, date_create = @date_create
WHERE u_id = @id;
END
GO
CREATE PROC Delete_User(@id int)
AS
BEGIN
DELETE FROM tbl_user WHERE u_id = @id
END
GO
--CRUD OF tbl_values
CREATE PROC Insert_Values(@val_name varchar(10),@type_id int,@status bit,@date_create datetime)
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
CREATE PROC Update_Values(@id int,@val_name nvarchar, @type_id int , @status bit, @date_create datetime)
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
DELETE FROM tbl_orderDetail WHERE value_id = @id
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
DELETE FROM tbl_orderDetail WHERE defference_id = @id;
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
DELETE FROM tbl_orderDetail WHERE type_id = @id
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
--CRUD OF tbl_orderDetail
CREATE PROC Insert_OrderDetail(@order_id int, @cat_id int, @type_id int, @value_id int, @defference_id int, @amount_in int, @amount_out int, @status bit, @date_create datetime)
AS
BEGIN
INSERT INTO tbl_orderDetail(order_id, cat_id, type_id, value_id, defference_id, amount_in, amount_out, status, date_create) VALUES (@order_id, @cat_id, @type_id, @value_id, @defference_id, @amount_in, @amount_out, @status, @date_create)
END
GO
CREATE PROC Get_OrderDetail
AS
BEGIN
SELECT * FROM tbl_orderDetail
END
GO
CREATE PROC Update_OrderDetail(@id int, @order_id int, @cat_id int, @type_id int, @value_id int, @defference_id int, @amount_in int, @amount_out int, @status bit, @date_create datetime)
AS
BEGIN
UPDATE tbl_orderDetail
SET order_id = @order_id, cat_id = @cat_id, type_id = @type_id, value_id = @value_id, defference_id = @defference_id, amount_in = @amount_in, amount_out = @amount_out, status = @status, date_create = @date_create
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
DELETE FROM tbl_orderDetail WHERE cat_id = @id
DELETE FROM tbl_types WHERE cat_id = @id
END
GO
--GET BY VALUES
CREATE PROC GetByValues
AS
BEGIN
SELECT v.val_name, t.type_name, c.cat_name, d.diff_name From [values] as v INNER JOIN tbl_types as t  ON v.val_id = t.type_id INNER JOIN tbl_category as c ON t.cat_id = c.cat_id INNER JOIN tbl_differenced as d ON v.val_id = d.val_id
END
GO
--CHECK PASSWORD
CREATE PROC CheckPass(@user_name varchar(10), @password char(32))
AS
BEGIN
SELECT * FROM tbl_user WHERE user_name = @user_name AND password = @password
END
GO

exec CheckPass @user_name = 'duc',  @password = '827ccb0eea8a706c4c34a16891f84e7b'

