CREATE DATABASE SHOPTEST
GO
USE SHOPTEST


GO
-- Tạo bảng Category
CREATE TABLE Category (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL UNIQUE,
    Img VARCHAR(MAX),
);
GO
-- Tạo bảng Product
CREATE TABLE Product (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500) NULL,
    Price DECIMAL(18, 2) NOT NULL,
    Stock INT NULL,
	Img VARCHAR (MAX),
    CategoryId INT,
    FOREIGN KEY (CategoryId) REFERENCES Category(Id)
);
GO
-- Tạo bảng Order
CREATE TABLE [Order] (
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderDate DATETIME NOT NULL,
    TotalAmount DECIMAL(18, 2) NOT NULL
);
GO
-- Tạo bảng OrderDetail
CREATE TABLE OrderDetail (
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT,
    ProductId INT,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES [Order](Id),
    FOREIGN KEY (ProductId) REFERENCES Product(Id)
);

-- Tạo bảng User
CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Username VARCHAR(255) UNIQUE,
	Password VARCHAR(30),
	Email VARCHAR(50),
	Role VARCHAR(50)
)

-- INSERT CATEGORIES
GO
SET IDENTITY_INSERT Category ON;
GO
INSERT INTO Category(Id, Name, Img)
VALUES
(1, N'Món ngon phải thử', 'https://jollibee.com.vn/media/catalog/category/web-12_1_1.png'),
(2, N'Gà giòn vui vẻ', 'https://jollibee.com.vn/media/catalog/category/web-05_1.png'),
(3, N'Mì Ý Jolly', 'https://jollibee.com.vn/media/catalog/category/web-06.png'),
(4, N'Gà sốt cay', 'https://jollibee.com.vn/media/catalog/category/web-07.png'),
(5, N'Burger/Cơm', 'https://jollibee.com.vn/media/catalog/category/cat_burger_1.png'),
(6, N'Phần ăn phụ', 'https://jollibee.com.vn/media/catalog/category/phananphu.png'),
(7, N'Món tráng miệng', 'https://jollibee.com.vn/media/catalog/category/trangmieng.png'),
(8, N'Thức uống', 'https://jollibee.com.vn/media/catalog/category/thucuong.png');
GO
SET IDENTITY_INSERT Category OFF;

GO
INSERT INTO Product (Name, Price, Img, CategoryId)
VALUES
( N'DEAL CỰC ĐÃ - ĂN THẢ GA 79K', 79000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/c/o/combo_79k-15.jpg', 1),
( N'COMBO MỘT MÌNH ĂN NGON', 78000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_1.png', 1),
( N'CẶP ĐÔI ĂN Ý', 145000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_2_2__1.png', 1),
( N'COMBO CẢ NHÀ NO NÊ', 185000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_3.png', 1),
( N'COMBO BẠN BÈ TỤ TẬP', 322000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_4_2.png', 1),
( N'TIỆC KIỂU MỚI, QUÀ CHUẨN GU 1', 499000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_5.png', 1),
( N'TIỆC KIỂU MỚI, QUÀ CHUẨN GU 2', 599000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_6.png', 1),
( N'TIỆC KIỂU MỚI, QUÀ CHUẨN GU 3', 699000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_7.png', 1);

GO
INSERT INTO Product (Name, Price, Img, CategoryId)
VALUES
( N'DEAL CỰC ĐÃ - ĂN THẢ GA 100K', 100000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/c/o/combo_79k-15.jpg', 2),
( N'COMBO MỘT MÌNH ĂN NGON', 100000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_1.png', 2),
( N'CẶP ĐÔI ĂN Ý', 145000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_2_2__1.png', 2),
( N'COMBO CẢ NHÀ NO NÊ', 185000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_3.png', 2),
( N'COMBO BẠN BÈ TỤ TẬP', 322000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_4_2.png', 2),
( N'TIỆC KIỂU MỚI, QUÀ CHUẨN GU 4', 499000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_5.png', 2),
( N'TIỆC KIỂU MỚI, QUÀ CHUẨN GU 5', 599000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_6.png', 2),
( N'TIỆC KIỂU MỚI, QUÀ CHUẨN GU 6', 799000, 'https://jollibee.com.vn/media/catalog/product/cache/9011257231b13517d19d9bae81fd87cc/m/_/m_n_ngon_ph_i_th_-_7.png', 2);

GO
INSERT INTO Users (Username, Password, Email, Role) 
VALUES 
('user1', 'password123', 'user1@example.com', 'admin'),
('user2', 'pass456', 'user2@example.com', 'user'),
('user3', 'mypassword', 'user3@example.com', 'user'),
('user4', 'pass789', 'user4@example.com', 'user'),
('user5', 'pass012', 'user5@example.com', 'admin'),
('user6', 'passwordabc', 'user6@example.com', 'admin'),
('user7', 'passxyz', 'user7@example.com', 'user'),
('user8', 'pass1234', 'user8@example.com', 'admin'),
('user9', 'securepass', 'user9@example.com', 'user'),
('user10', 'pass5678', 'user10@example.com', 'admin')
