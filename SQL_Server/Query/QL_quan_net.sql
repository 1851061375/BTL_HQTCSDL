CREATE DATABASE QL_quan_net
GO

USE QL_quan_net
GO

CREATE TABLE AccountType
(
	Type INT NOT NULL PRIMARY KEY DEFAULT 0,
	Name VARCHAR(10) NOT NULL DEFAULT 'staff',
)
GO 

CREATE TABLE Account
(
	UserName VARCHAR(50) NOT NULL PRIMARY KEY,
	DisplayName NVARCHAR(50) NOT NULL DEFAULT N'Tên người dùng',
	Password VARCHAR(100) NOT NULL DEFAULT 0,
	Type INT NOT NULL,
	CONSTRAINT FK_Type FOREIGN KEY(Type) REFERENCES AccountType(Type)
) 
GO


CREATE TABLE Computer
(
	Id INT IDENTITY NOT NULL PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
	Status NVARCHAR(50) NOT NULL DEFAULT N'Trống'
)
GO

CREATE TABLE FoodCategory
(
	CategoryName NVARCHAR(50) NOT NULL PRIMARY KEY
)
GO


CREATE TABLE Food
(
	FoodName NVARCHAR(50) NOT NULL PRIMARY KEY,
	CategoryName NVARCHAR(50) NOT NULL,
	Unit NVARCHAR(50) NOT NULL,
	Price INT,
	CurrentQuantity INT DEFAULT 0,
	FOREIGN KEY(CategoryName) REFERENCES dbo.FoodCategory(CategoryName)
)
GO


CREATE TABLE Bill
(
	Id INT IDENTITY NOT NULL PRIMARY KEY,
	Date DATE NOT NULL,
	TimeCheckIn TIME(0) NOT NULL,
	TimeCheckOut TIME(0) DEFAULT '00:00:00',
	TotalTime NVARCHAR(50) DEFAULT N'0 giờ 0 phút',
	TimePrice INT DEFAULT 0,
	TotalFoodPrice INT DEFAULT 0,
	idComputer INT,
	Status INT  DEFAULT 0 -- 0: Chưa thanh toán , 1: Đã thanh toán

	FOREIGN KEY (idComputer) REFERENCES dbo.Computer(Id)
)
GO

CREATE TABLE BillInfo
(
	Id INT IDENTITY NOT NULL PRIMARY KEY,
	idBill INT NOT NULL,
	FoodName NVARCHAR(50) NOT NULL,
	Quantity INT NOT NULL DEFAULT 0,
	FOREIGN KEY(idBill) REFERENCES dbo.Bill(Id),
	FOREIGN KEY(FoodName) REFERENCES dbo.Food(FoodName),
)
GO

INSERT INTO dbo.AccountType(Type,NAME)
VALUES
(0, 'staff'),
(1, 'admin')

INSERT INTO Account(UserName,DisplayName,Password,Type)
VALUES
('admin','admin','123456',1),
('staff','staff','123456',0)
GO 

INSERT INTO FoodCategory(CategoryName)
VALUES
(N'Đồ uống'),
(N'Đồ ăn'),
(N'Thuốc lá')

INSERT INTO Food(CategoryName,FoodName,Unit,Price,CurrentQuantity)
VALUES
(N'Đồ uống',N'Trà đào',N'chai',15000,24),
(N'Đồ uống',N'Trà ô long',N'chai',15000,24),
(N'Đồ uống',N'Bò húc',N'lon',18000,24),
(N'Đồ uống',N'Coca',N'lon',15000,24),
(N'Đồ uống',N'247',N'chai',17000,24),
(N'Đồ uống',N'Trà đá',N'cốc',5000,50),
(N'Đồ ăn',N'Mì tôm',N'bát',10000,30),
(N'Đồ ăn',N'Trứng',N'quả',8000,30),
(N'Đồ ăn',N'Xúc xích',N'cái',8000,30),
(N'Thuốc lá',N'Vina',N'bao',30000,10),
(N'Thuốc lá',N'Thăng long',N'bao',15000,10)
GO 



--Insert computer
DECLARE @i INT = 1
WHILE @i < =10
BEGIN
	INSERT INTO dbo.Computer(Name) VALUES(N'Máy '+ CAST(@i AS nvarchar(50)))
	SET @i = @i + 1
END
GO


GO 

CREATE PROC USP_InsertBill @idComputer INT
AS
BEGIN
	INSERT INTO dbo.Bill(Date,TimeCheckIn,idComputer,Status)	
	VALUES
	(   GETDATE(),  -- Date - date
	    cast(getdate() as time), -- TimeCheckIn - time(7)
	    @idComputer,          -- idComputer - int
	    0           -- Status - int
	)
END
GO

/*EXEC dbo.USP_InsertBill @idComputer = 1
SELECT * FROM dbo.Bill*/

CREATE PROC USP_InsertBill_Info 
@idBill INT, @foodName NVARCHAR(50), @quantity INT 
AS
BEGIN
	DECLARE @checkFood INT
	DECLARE @fquantity INT = 1
	SELECT @checkFood = Id,@fquantity = Quantity FROM dbo.BillInfo WHERE idBill = @idBill AND FoodName = @foodName

	IF (@checkFood > 0)
	BEGIN
		UPDATE dbo.BillInfo SET Quantity = @fquantity + @quantity WHERE idBill = @idBill AND FoodName = @foodName
	END
	ELSE
	BEGIN
		INSERT INTO BillInfo(idBill,FoodName,Quantity)
		VALUES
		(@idBill,@foodName,@quantity)
	END
END
GO

/*EXEC dbo.USP_InsertBill_Info @idBill = 1, @foodName = N'Bò húc', @quantity = 2 
EXEC dbo.USP_InsertBill_Info @idBill = 1, @foodName = N'Coca', @quantity = 1 
SELECT* FROM dbo.BillInfo*/

CREATE PROC GetFoodByCategory
@categoryname NVARCHAR(50)
AS
BEGIN
	SELECT* FROM dbo.Food WHERE CategoryName = @categoryname
END
GO 

--EXEC dbo.GetFoodByCategory @categoryname = N'Đồ uống'

CREATE PROC USP_DecreaseFood
@idBill INT, @foodName NVARCHAR(50), @quantity INT 
AS
BEGIN
	DECLARE @fquantity INT = 1

	SELECT @fquantity = Quantity FROM dbo.BillInfo WHERE idBill = @idBill AND FoodName = @foodName

	IF (@fquantity > 1)
	BEGIN
		UPDATE dbo.BillInfo SET Quantity = @fquantity - @quantity WHERE idBill = @idBill AND FoodName = @foodName
	END
	ELSE
	BEGIN
		DELETE dbo.BillInfo WHERE idBill = @idBill AND FoodName = @foodName
	END
END
GO

/*EXEC dbo.USP_DecreaseFood @idBill = 1, @foodName = N'Bò húc', @quantity = 1 
SELECT * FROM dbo.BillInfo*/


CREATE PROC USP_DeleteFood
@idBill INT, @foodName NVARCHAR(50) 
AS
BEGIN
	DELETE dbo.BillInfo WHERE FoodName = @foodName AND idBill = @idBill
END
GO

/*EXEC dbo.USP_DeleteFood @idBill = 1, @foodName = N'Bò húc'
SELECT* FROM dbo.BillInfo*/

CREATE PROC USP_GetListBillByDate 
@date DATE
AS 
BEGIN
	SELECT C.Name AS [Tên máy], B.TimeCheckIn AS [Giờ vào], B.TimeCheckOut AS [Giờ ra], B.TotalTime AS [Tổng giờ],
	B.TimePrice AS [Tiền giờ], B.TotalFoodPrice AS [Tiền nước], TimePrice + TotalFoodPrice  AS [Tổng tiền]
	FROM Computer AS C, Bill AS B
	WHERE C.Id = B.idComputer AND B.Date = @date AND B.Status = 1
END
GO

--EXEC USP_GetListBillByDate @date = '20201106'

CREATE PROC USP_GetAccountType @username VARCHAR(50)
AS
BEGIN
	DECLARE @type int
	SELECT @type = Type FROM dbo.Account WHERE UserName = @username
	SELECT * FROM dbo.AccountType WHERE Type = @type
END
GO 

--EXEC USP_GetAccountType @username = 'staff'



CREATE FUNCTION UF_RevenueByDate (@date DATE)
RETURNS INT
AS
BEGIN
	DECLARE @revenue INT
	SELECT @revenue = SUM(TimePrice + TotalFoodPrice) FROM Bill WHERE Status = 1 AND Date = @date
	RETURN @revenue
END 
GO 

SELECT dbo.UF_RevenueByDate('20201106')

CREATE VIEW UV_GetAllFood AS
SELECT* FROM dbo.Food
GO

--SELECT* FROM UV_GetAllFood

CREATE VIEW UV_GetAllComputer AS 
SELECT* FROM dbo.Computer

--SELECT* FROM UV_GetAllComputer

CREATE TRIGGER UT_UpdateBill
ON dbo.Bill FOR INSERT
AS 
BEGIN
	DECLARE @idBill INT 
	SELECT @idBill = ID FROM Inserted

	DECLARE @idComputer INT
	SELECT @idComputer = idComputer FROM dbo.Bill WHERE Id = @idBill AND Status = 0
	UPDATE dbo.Computer SET Status = N'Có người' WHERE Id = @idComputer
END
GO 

CREATE TRIGGER UT_CheckOut
ON dbo.Bill FOR UPDATE
AS 
BEGIN
	DECLARE @idBill INT 
	SELECT @idBill = Inserted.Id FROM Inserted
	

	DECLARE @idComputer INT
	SELECT @idComputer = idComputer FROM dbo.Bill WHERE Id = @idBill AND Status = 1

	UPDATE dbo.Computer SET Status = N'Trống' WHERE Id = @idComputer

END
GO 



--Tạo login

SP_addlogin 'admin', '1'
GO 
SP_addlogin 'staff', '1'

-- Tạo database user
USE QL_quan_net 
EXEC sp_grantdbaccess 'admin','admin'

USE QL_quan_net
EXEC sp_grantdbaccess 'staff','staff'

--Cấp quyền cho user admin
GRANT ALL ON dbo.Account TO admin
GRANT ALL ON dbo.AccountType TO admin
GRANT ALL ON dbo.Computer TO admin
GRANT ALL ON dbo.FoodCategory TO admin
GRANT ALL ON dbo.Food TO admin
GRANT ALL ON dbo.Bill TO admin
GRANT ALL ON dbo.BillInfo TO admin

--Cấp quyền cho user staff
GRANT SELECT, INSERT, UPDATE ON dbo.Food TO staff
GRANT SELECT, INSERT, UPDATE ON dbo.Bill TO staff
GRANT SELECT, INSERT, UPDATE ON dbo.BillInfo TO staff












