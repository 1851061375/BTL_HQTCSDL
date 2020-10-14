CREATE DATABASE QL_quan_net
GO

USE QL_quan_net
GO

CREATE TABLE Account
(
	UserName VARCHAR(50) NOT NULL PRIMARY KEY,
	DisplayName NVARCHAR(50) NOT NULL DEFAULT N'Tên người dùng',
	Password VARCHAR(100) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 0: staff, 1: admin
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
	Id INT IDENTITY NOT NULL PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
)
GO

CREATE TABLE Food
(
	Id INT IDENTITY NOT NULL PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
	IDCategory INT NOT NULL,
	Unit NVARCHAR(50) NOT NULL,
	Price INT,

	FOREIGN KEY(IDCategory) REFERENCES dbo.FoodCategory(Id)
)
GO


CREATE TABLE Bill
(
	Id INT IDENTITY NOT NULL PRIMARY KEY,
	Date DATE NOT NULL,
	TimeCheckIn TIME NOT NULL,
	TimeCheckOut TIME,
	idComputer INT,
	Status INT  DEFAULT 0 -- 0: Chưa thanh toán , 1: Đã thanh toán

	FOREIGN KEY (idComputer) REFERENCES dbo.Computer(Id)
)
GO

CREATE TABLE BillInfor
(
	Id INT IDENTITY NOT NULL PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	Quantity INT NOT NULL DEFAULT 0,

	FOREIGN KEY(idBill) REFERENCES dbo.Bill(Id),
	FOREIGN KEY(idFood) REFERENCES dbo.Food(Id)
)
GO

INSERT INTO Account(UserName,DisplayName,Password,Type)
VALUES
('admin','admin','123456',1),
('staff','staff','123456',0)

CREATE PROC GetAccountByUserName
@username NVARCHAR(50)
AS
BEGIN
	SELECT* FROM dbo.Account WHERE UserName = @username
END

EXEC GetAccountByUserName @username = 'admin'

SELECT UserName,Password FROM dbo.Account WHERE UserName = 'admin' AND Password ='' OR 1 = 1 --
GO

--them may tram
DECLARE @i INT = 1
WHILE @i < =10
BEGIN
	IF (@i % 2 = 0)
	INSERT INTO dbo.Computer(Name) VALUES(N'Máy '+ CAST(@i AS nvarchar(50)))
	ELSE
	INSERT INTO dbo.Computer(Name, Status) VALUES(N'Máy '+ CAST(@i AS nvarchar(50)), N'Có người')
	SET @i = @i + 1
END
GO

--proc lay may tram
CREATE PROC GetComputer AS
BEGIN
    SELECT *FROM dbo.Computer
END
GO

EXEC dbo.GetComputer


--them loai thuc pham
INSERT INTO FoodCategory(Name)
VALUES
(N'Đồ uống'),
(N'Đồ ăn'),
(N'Thuốc lá')

INSERT INTO Food(IDCategory,Name,Unit,Price)
VALUES
(1,N'Trà đào',N'chai',15000),
(1,N'Trà ô long',N'chai',15000),
(1,N'Bò húc',N'lon',18000),
(2,N'Mì tôm',N'bát',10000),
(2,N'Trứng',N'quả',8000),
(2,N'Xúc xích',N'cái',8000),
(3,N'Vina',N'bao',30000),
(3,N'Thăng long',N'bao',15000)


INSERT INTO Bill(Date,idComputer,TimeCheckIn,TimeCheckOut,Status)
VALUES
('20201011',12,'12:12',NULL,0),
('20201011',13,'13:13','15:15',1),
('20201011',14,'14:14',NULL,0)


INSERT INTO Billinfor(idBill,idFood,Quantity)
VALUES
(8,1,1),
(8,4,1),
(8,5,1),
(8,6,1)

SELECT F.Name,F.Unit,BI.Quantity,F.Price
FROM dbo.Bill AS B,dbo.BillInfor AS BI,dbo.Food AS F,dbo.Computer AS C
WHERE B.Id = BI.idBill AND F.Id = BI.idFood AND C.Id = B.idComputer AND C.Id = 12

SELECT F.Name,F.Unit,F.Price
FROM dbo.Food AS F,dbo.FoodCategory AS FC
WHERE F.IDCategory = FC.Id AND f.IDCategory IN (1,2,3)
