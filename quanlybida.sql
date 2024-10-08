USE [master]
GO
/****** Object:  Database [QuanLyQuanBiDaFinal1]    Script Date: 6/6/2024 12:18:14 AM ******/
CREATE DATABASE [QuanLyQuanBiDaFinal1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanBiDaFinal1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QuanLyQuanBiDaFinal1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyQuanBiDaFinal1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QuanLyQuanBiDaFinal1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanBiDaFinal1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyQuanBiDaFinal1', N'ON'
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyQuanBiDaFinal1]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attendance]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendance](
	[AccountName] [nvarchar](50) NOT NULL,
	[EmployeeName] [nvarchar](100) NOT NULL,
	[WorkDate] [date] NOT NULL,
	[CheckInTime] [time](7) NULL,
	[CheckOutTime] [time](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [datetime] NOT NULL,
	[DateCheckOut] [datetime] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[idcustomer] [varchar](100) NOT NULL,
	[name] [nvarchar](100) NULL,
	[gender] [nvarchar](100) NULL,
	[phonenumber] [nvarchar](100) NULL,
	[daycheckin] [varchar](100) NULL,
	[idcategorycustomer] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idcustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableBida]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableBida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablePlayTime]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablePlayTime](
	[TableID] [int] NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Staff') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableBida] ADD  DEFAULT (N'Bàn chưa có tên') FOR [name]
GO
ALTER TABLE [dbo].[TableBida] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableBida] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDashboardData]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_GetDashboardData]
AS
BEGIN
    -- Tính tổng số lượng bàn
    DECLARE @TotalTables INT
    SELECT @TotalTables = COUNT(*) FROM TableBida
    
    -- Tính tổng số lượng hóa đơn
    DECLARE @TotalBills INT
    SELECT @TotalBills = COUNT(*) FROM Bill
    
    -- Tính tổng doanh thu
    DECLARE @TotalRevenue MONEY
    SELECT @TotalRevenue = SUM(totalPrice) FROM Bill WHERE status = 1
    
    -- Tính tổng số lượng món ăn đã được đặt
    DECLARE @TotalFoodOrdered INT
    SELECT @TotalFoodOrdered = SUM(count) FROM BillInfo
    
    -- Tính số lượng khách hàng
    DECLARE @TotalCustomers INT
    SELECT @TotalCustomers = COUNT(*) FROM Customer
    
    -- Tính số lượng nhân viên
    DECLARE @TotalStaff INT
    SELECT @TotalStaff = COUNT(*) FROM Account WHERE Type = 0
    
    -- Trả về kết quả
    SELECT @TotalTables AS TotalTables, 
           @TotalBills AS TotalBills, 
           @TotalRevenue AS TotalRevenue, 
           @TotalFoodOrdered AS TotalFoodOrdered, 
           @TotalCustomers AS TotalCustomers, 
           @TotalStaff AS TotalStaff
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDashboardDataByDay]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_GetDashboardDataByDay]
    @SelectedDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TotalTables INT;
    DECLARE @TotalBills INT;
    DECLARE @TotalRevenue MONEY;
    DECLARE @TotalFoodOrdered INT;
    DECLARE @TotalCustomers INT;
    DECLARE @TotalStaff INT;

    -- Lấy tổng số bàn
    SELECT @TotalTables = COUNT(*) FROM TableBida;

    -- Lấy tổng số hóa đơn cho ngày được chọn
    SELECT @TotalBills = COUNT(*) FROM Bill WHERE CONVERT(DATE, DateCheckIn) = @SelectedDate;

    -- Lấy tổng doanh thu cho ngày được chọn
    SELECT @TotalRevenue = SUM(TotalPrice) FROM Bill WHERE CONVERT(DATE, DateCheckIn) = @SelectedDate AND Status = 1;

    -- Lấy tổng số món ăn đã đặt cho ngày được chọn
    SELECT @TotalFoodOrdered = SUM(bi.count) FROM BillInfo bi INNER JOIN Bill b ON bi.idBill = b.id WHERE CONVERT(DATE, b.DateCheckIn) = @SelectedDate;

    -- Lấy tổng số khách hàng đã đến vào ngày được chọn
    SELECT @TotalCustomers = COUNT(DISTINCT id) FROM Bill WHERE CONVERT(DATE, DateCheckIn) = @SelectedDate;

    -- Lấy tổng số nhân viên
    SELECT @TotalStaff = COUNT(*) FROM Account WHERE Type = 0;

    -- Trả về kết quả
    SELECT @TotalTables AS TotalTables,
           @TotalBills AS TotalBills,
           @TotalRevenue AS TotalRevenue,
           @TotalFoodOrdered AS TotalFoodOrdered,
           @TotalCustomers AS TotalCustomers,
           @TotalStaff AS TotalStaff;
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetDashboardDataByMonth]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_GetDashboardDataByMonth]
    @SelectedMonth INT,
    @SelectedYear INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @StartDate DATE;
    DECLARE @EndDate DATE;

    SET @StartDate = DATEFROMPARTS(@SelectedYear, @SelectedMonth, 1);
    SET @EndDate = EOMONTH(@StartDate);

    DECLARE @TotalTables INT;
    DECLARE @TotalBills INT;
    DECLARE @TotalRevenue MONEY;
    DECLARE @TotalFoodOrdered INT;
    DECLARE @TotalCustomers INT;
    DECLARE @TotalStaff INT;

    -- Lấy tổng số bàn
    SELECT @TotalTables = COUNT(*) FROM TableBida;

    -- Lấy tổng số hóa đơn trong tháng được chọn
    SELECT @TotalBills = COUNT(*) FROM Bill WHERE DateCheckIn >= @StartDate AND DateCheckIn <= @EndDate;

    -- Lấy tổng doanh thu trong tháng được chọn
    SELECT @TotalRevenue = SUM(TotalPrice) FROM Bill WHERE DateCheckIn >= @StartDate AND DateCheckIn <= @EndDate AND Status = 1;

    -- Lấy tổng số món ăn đã đặt trong tháng được chọn
    SELECT @TotalFoodOrdered = SUM(bi.count) FROM BillInfo bi INNER JOIN Bill b ON bi.idBill = b.id WHERE DateCheckIn >= @StartDate AND DateCheckIn <= @EndDate;

    -- Lấy tổng số khách hàng đã đến trong tháng được chọn
    SELECT @TotalCustomers = COUNT(DISTINCT id) FROM Bill WHERE DateCheckIn >= @StartDate AND DateCheckIn <= @EndDate;

    -- Lấy tổng số nhân viên
    SELECT @TotalStaff = COUNT(*) FROM Account WHERE Type = 0;

    -- Trả về kết quả
    SELECT @TotalTables AS TotalTables,
           @TotalBills AS TotalBills,
           @TotalRevenue AS TotalRevenue,
           @TotalFoodOrdered AS TotalFoodOrdered,
           @TotalCustomers AS TotalCustomers,
           @TotalStaff AS TotalStaff;
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableBida AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate1]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_GetListBillByDate1]
    @checkIn DATETIME,
    @checkOut DATETIME
AS
BEGIN
    SELECT * 
    FROM dbo.BILL 
    WHERE DateCheckIn BETWEEN @checkIn AND @checkOut
    ORDER BY DateCheckIn DESC; -- Sắp xếp các hóa đơn theo thứ tự mới nhất
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetTableList]
AS SELECT * FROM dbo.TableBida
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertBill]
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status,
	          discount
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,  -- status - int
	          0
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertBillInfo]
@idBill INT, @idFood INT, @count INT
AS
BEGIN
DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTabel]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[USP_SwitchTabel]
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	
	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableBida SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableBida SET status = N'Trống' WHERE id = @idTable1
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 6/6/2024 12:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_UpdateAccount]
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanBiDaFinal1] SET  READ_WRITE 
GO
