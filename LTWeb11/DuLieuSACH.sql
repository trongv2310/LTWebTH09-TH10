
INSERT INTO [dbo].[ChuDe] VALUES
(1, N'Công nghệ thông tin'),
(2, N'Văn học nghệ thuật'),
(3, N'Kinh tế'),
(4, N'Sách thiếu nhi'),
(5, N'Kỹ năng sống');
GO

INSERT INTO [dbo].[NhaXuatBan] VALUES
(1, N'NXB Trẻ', N'TP. Hồ Chí Minh', '02839316289'),
(2, N'NXB Kim Đồng', N'Hà Nội', '02439434730'),
(3, N'NXB Tổng hợp TPHCM', N'TP. Hồ Chí Minh', '02838225340'),
(4, N'NXB Lao Động', N'Hà Nội', '02438515380');
GO

INSERT INTO [dbo].[TacGia] VALUES
(1, N'Nguyễn Ngọc Ánh', N'Quảng Nam'),
(2, N'Robert C M', N'USA'),
(3, N'Dale C', N'USA'),
(4, N'J.K.Rowling', N'UK');
GO

INSERT INTO [dbo].[KhachHang] VALUES
(1, N'Nguyễn Văn An', '1995-10-20', N'Nam', '0909123456', 'annguyen', 'e10adc3949ba59abbe56e057f20f883e', 'an.nguyen@example.com', N'123 Lê Lợi, Quận 1, TP. HCM'),
(2, N'Trần Thị Bình', '2000-01-30', N'Nữ', '0987654321', 'binhtran', 'e10adc3949ba59abbe56e057f20f883e', 'binh.tran@example.com', N'456 Hai Bà Trưng, Quận 3, TP. HCM'),
(3, N'Lê Minh Cường', '1988-05-15', N'Nam', '0912345678', 'cuongle', 'e10adc3949ba59abbe56e057f20f883e', 'cuong.le@example.com', N'789 Nguyễn Trãi, Quận 5, TP. HCM');
GO

INSERT INTO [dbo].[Sach] VALUES
(1, N'Clean Code', 150000.00, N'Sách về lập trình sạch', '2025-01-10', 'cleancode.jpg', 50, 1, 4, N'Mới'),
(2, N'Cho tôi xin một vé đi tuổi thơ', 85000.00, N'Truyện dài của Nguyễn Nhật Ánh', '2024-11-20', 'vedituoitho.jpg', 100, 2, 1, N'Mới'),
(3, N'Đắc nhân tâm', 99000.00, N'Sách kỹ năng giao tiếp', '2025-02-01', 'dacnhantam.jpg', 200, 5, 3, N'Cũ'),
(4, N'Harry Potter và Hòn đá Phù thủy', 120000.00, N'Tập 1 series Harry Potter', '2025-01-15', 'harrypotter1.jpg', 80, 4, 2, N'Mới'),
(5, N'Lập trình Python', 180000.00, N'Sách học Python từ cơ bản', '2025-03-01', 'python.jpg', 60, 1, 3, N'Mới');
GO

INSERT INTO [dbo].[ThamGia] VALUES
(1, 2, N'Tác giả chính', N'Bìa sách'),
(2, 1, N'Tác giả chính', N'Bìa sách'),
(3, 3, N'Tác giả', N'Bìa sách'),
(4, 4, N'Tác giả chính', N'Bìa sách');
GO

INSERT INTO [dbo].[DonHang] VALUES
(1, '2025-10-28', '2025-10-25', 235000.00, N'Đã giao hàng', 1),
(2, NULL, '2025-10-30', 0.00, N'Đang xử lý', 2),
(3, '2025-11-05', '2025-11-01', 99000.00, N'Đã thanh toán', 1);
GO

INSERT INTO [dbo].[ChiTietDonHang] VALUES
(1, 1, 1, 150000.00),
(1, 2, 1, 85000.00),
(2, 4, 2, 120000.00),
(3, 3, 1, 99000.00);
GO

-- 1. Bảng Chủ Đề
PRINT N'--- Kết quả Bảng: ChuDe ---'
SELECT * FROM [dbo].[ChuDe];
GO

-- 2. Bảng Nhà Xuất Bản
PRINT N'--- Kết quả Bảng: NhaXuatBan ---'
SELECT * FROM [dbo].[NhaXuatBan];
GO

-- 3. Bảng Tác Giả
PRINT N'--- Kết quả Bảng: TacGia ---'
SELECT * FROM [dbo].[TacGia];
GO

-- 4. Bảng Khách Hàng
PRINT N'--- Kết quả Bảng: KhachHang ---'
SELECT * FROM [dbo].[KhachHang];
GO

-- 5. Bảng Sách
PRINT N'--- Kết quả Bảng: Sach ---'
SELECT * FROM [dbo].[Sach];
GO

-- 6. Bảng Tham Gia (Tác giả viết sách nào)
PRINT N'--- Kết quả Bảng: ThamGia ---'
SELECT * FROM [dbo].[ThamGia];
GO

-- 7. Bảng Đơn Hàng
PRINT N'--- Kết quả Bảng: DonHang ---'
SELECT * FROM [dbo].[DonHang];
GO

-- 8. Bảng Chi Tiết Đơn Hàng
PRINT N'--- Kết quả Bảng: ChiTietDonHang ---'
SELECT * FROM [dbo].[ChiTietDonHang];
GO