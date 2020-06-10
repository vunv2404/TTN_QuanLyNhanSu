--Viết Code , query Thao tác vơi dữ liệu tại đây.

---------------------------------------------------------------------------------
create proc PROC_XemTatCaPB
as
begin
	select * from PhongBan
end
go

---------------------------------------------------------------------------------
create proc PROC_XemTatCaTruongPhong
as
begin
	SELECT MaNV 
	FROM HoSoNhanSu
	WHERE not EXISTS (	SELECT * 
						FROM PhongBan
						WHERE HoSoNhanSu.MaNV = PhongBan.MaTruongPhong)
end
go

---------------------------------------------------------------------------------
create proc PROC_TaoPhongBan 
(@maPB varchar(10), @ten nvarchar(50), @ngayTL datetime, @maTP varchar(10), @email varchar(250), @sdt varchar(20), @fax varchar(20))
as
begin 
	insert into PhongBan
	values (@maPB, @ten, @ngayTL, @maTP, @email, @sdt, @fax)	
end
go

---------------------------------------------------------------------------------
create proc PROC_XemChiTietPB (@maPB varchar(10))
as
begin 
	select * from PhongBan
	where MaPhongBan = @maPB
end
go

---------------------------------------------------------------------------------
create proc PROC_SuaPhongBan 
(@maPB varchar(10), @ten nvarchar(50), @ngayTL datetime, @maTP varchar(10), @email varchar(250), @sdt varchar(20), @fax varchar(20))
as
begin 
	update PhongBan
	set TenPB = @ten, NgayThanhLap = @ngayTL, MaTruongPhong = @maTP, Email = @email, SoDienThoai = @sdt, Fax = @fax
	where MaPhongBan = @maPB
end
go


---------------------------------------------------------------------------------
create proc PROC_XemTatCaBoPhanNS
as
begin
	select * from BoPhan
end
go

---------------------------------------------------------------------------------
create proc PROC_SuaPhongBoPhanNS
(@maBoPhan varchar(10), @ten nvarchar(250), @maPhongBan varchar(10), @email varchar(50), @sdt varchar(20), @fax varchar(20))
as
begin 
	update BoPhan
	set TenBoPhan = @ten, MaPhongban = @maPhongBan, Email = @email, DienThoai = @sdt, Fax = @fax
	where MaBoPhan = @maBoPhan
end
go

---------------------------------------------------------------------------------
create proc PROC_TaoBoPhanNS 
(@maBoPhan varchar(10), @ten nvarchar(250), @maPhongBan varchar(10), @email varchar(50), @sdt varchar(20), @fax varchar(20))
as
begin 
	insert into BoPhan
	values (@maBoPhan, @ten, @maPhongBan, @email, @sdt, @fax)	
end
go

---------------------------------------------------------------------------------
create proc PROC_XemChiTietBoPhanNS (@maBoPhan varchar(10))
as
begin 
	select * from BoPhan
	where MaBoPhan = @maBoPhan
end
go

---------------------------------------------------------------------------------
create proc PROC_TatCaLuongNV 
as
begin 
	select * from Luong
end
go

---------------------------------------------------------------------------------
create proc PROC_XemChiTietLuongNV (@maNV varchar(10))
as
begin 
	select * from Luong
	where MaNV = @maNV
end
go

--A = (Mức Lương * Hệ SỐ * tổng ngầy công) + công làm thêm giờ 
--Tổng Lương nhận = A + Tiền phụ cấp - A*5%(Đây là thuế thu nhập) - 500.000(tiền bảo hiểm).
---------------------------------------------------------------------------------
create proc PROC_TinhLuongNV (@maNV varchar(10))
as
begin 
	declare @MucLuong money, @HeSo float, @TongNgayCong int, @OT money, @PhuCap money, @Thue money, @TongLuongNhan money, @BH money
	set @MucLuong = (select MucLuong from Luong where MaNV = @maNV)
	set @HeSo = (select HeSo from Luong where MaNV = @maNV)
	set @TongNgayCong = (select TongNgayCong from Luong where MaNV = @maNV)
	set @OT = (select CongLamThemGio from Luong where MaNV = @maNV)
	set @PhuCap = (select PhuCap from Luong where MaNV = @maNV)
	set @BH = '500000'

	set @Thue = ((@MucLuong*@HeSo*@TongNgayCong + @OT)*5)/100
	set @TongLuongNhan = ((@MucLuong*@HeSo*@TongNgayCong + @OT)*95)/100  + @PhuCap - @BH

	update Luong
	set ThueThuNhap = @Thue, TongLuongNhan = @TongLuongNhan
	where MaNV = @maNV
end
go

---------------------------------------------------------------------------------
create proc PROC_ThemLuongNV
(@maNV varchar(10), @SoQuyetDinh varchar(15), @NgayKi datetime, @NgayHieuLuc datetime, @MucLuong money, @HeSo float, @TongNgayCong int, @OT money, @PhuCap money)
as
begin 
	insert into Luong
	values (@maNV, @SoQuyetDinh, @NgayKi, @NgayHieuLuc, @MucLuong, @HeSo, @TongNgayCong, @OT, @PhuCap, 0, 0)	

	exec PROC_TinhLuongNV @maNV
end
go

---------------------------------------------------------------------------------
create proc PROC_SuaLuongNV
(@maNV varchar(10), @SoQuyetDinh varchar(15), @NgayKi datetime, @NgayHieuLuc datetime, @MucLuong money, @HeSo float, @TongNgayCong int, @OT money, @PhuCap money)
as
begin 
	update Luong
	set MaNV = @maNV, SoQuyetDinh = @SoQuyetDinh, NgayKi = @NgayKi, NgayHieuLuc = @NgayHieuLuc, MucLuong = @MucLuong, HeSo = @HeSo, TongNgayCong = @TongNgayCong, CongLamThemGio = @OT, PhuCap = @PhuCap

	exec PROC_TinhLuongNV @maNV
end
go

---------------------------------------------------------------------------------
create proc PROC_XemNV 
as
begin 
	SELECT MaNV 
	FROM HoSoNhanSu
	WHERE not EXISTS (	SELECT * 
						FROM Luong
						WHERE HoSoNhanSu.MaNV = Luong.MaNV)
end
go

exec PROC_ThemLuongNV '4', 'G', '2020-05-19 00:00:00.000', '2020-05-19 00:00:00.000', '5000000', 1, 10, '500000', '500000'
exec PROC_TatCaLuongNV