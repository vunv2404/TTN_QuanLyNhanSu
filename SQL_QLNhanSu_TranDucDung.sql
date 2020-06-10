
--Viết Code , query Thao tác vơi dữ liệu tại đây.
create proc GetDanhSachNhanSuFilter @str1 nvarchar(50), @str2 nvarchar(50)
as
begin
	if(@str1 = N'Mã Nhân Viên')
	begin
		select * from HoSoNhanSu where MaNV like '%'+@str2+'%'
	end
	else if(@str1 = N'Tên Nhân Viên')
	begin
		select * from HoSoNhanSu where HoTenNV like '%'+@str2+'%'
	end
	else if(@str1 = N'Bộ Phận')
	begin
		select * from HoSoNhanSu where BoPhan like '%'+@str2+'%'
	end
	else if(@str1 = N'None')
	begin
		select * from HoSoNhanSu
	end
end

go

create proc GetMaNS
as
begin
	select count(MaNV) from HoSoNhanSu 
end

go

create proc GetBoPhan
as
begin
	select * from BoPhan
end

go

create proc GetPhongBan
as
begin
	select * from PhongBan
end

go

create proc AddNhanSu @manv varchar(10),@hotennv nvarchar(250),@ngaysinh datetime , @gioitinh nvarchar(10),@chucvu nvarchar(100),@bophan nvarchar(250),
	@maphongban varchar(10),@ngayvaocoquan datetime,@anhdaidien varbinary(max),@quequan nvarchar(250),@email varchar(250),@sdt varchar(20),@hocvi nvarchar(250),
	@hocham nvarchar(250) , @chungchi nvarchar(250),@chuyenmon nvarchar(100)
as
begin
	insert HoSoNhanSu(MaNV,HoTenNV,NgaySinh,GioiTinh,ChucVu,BoPhan,MaPhongBan,NgayVaoCoQuan,AnhDaiDien,QueQuan,Email,SoDienThoai,HocVi,HocHam,ChungChi,chuyenMon)
	values(@manv,@hotennv,@ngaysinh,@gioitinh,@chucvu,@bophan,@maphongban,@ngayvaocoquan,@anhdaidien,@quequan,@email,@sdt,@hocvi,@hocham,@chungchi,@chuyenmon)
end

go

create proc AddNhanSuWithOutImage @manv varchar(10),@hotennv nvarchar(250),@ngaysinh datetime , @gioitinh nvarchar(10),@chucvu nvarchar(100),@bophan nvarchar(250),
	@maphongban varchar(10),@ngayvaocoquan datetime,@quequan nvarchar(250),@email varchar(250),@sdt varchar(20),@hocvi nvarchar(250),
	@hocham nvarchar(250) , @chungchi nvarchar(250),@chuyenmon nvarchar(100)
as
begin
	insert HoSoNhanSu(MaNV,HoTenNV,NgaySinh,GioiTinh,ChucVu,BoPhan,MaPhongBan,NgayVaoCoQuan,QueQuan,Email,SoDienThoai,HocVi,HocHam,ChungChi,chuyenMon)
	values(@manv,@hotennv,@ngaysinh,@gioitinh,@chucvu,@bophan,@maphongban,@ngayvaocoquan,@quequan,@email,@sdt,@hocvi,@hocham,@chungchi,@chuyenmon)
end

go

create proc GetTenNS @mans varchar(10)
as
begin
	select HoTenNV from HoSoNhanSu where MaNV = @mans
end

go 

create proc GetMaHopDong
as
begin
	select count(SoHopDong) from HopDongNhanSu
end

go

create proc AddHopDong @sohd varchar(20), @manv varchar(10), @tennv nvarchar(250), @loaihd nvarchar(250), @trangthai nvarchar(50), @ngayhieuluc datetime, @ngayhethan datetime, @noidung ntext
as
begin
	insert HopDongNhanSu(SoHopDong,MaNV,HoTenNV,LoaiHopDong,TrangThai,NgayHieuLuc,NgayHetHan,NoiDung)
	values(@sohd,@manv,@tennv,@loaihd,@trangthai,@ngayhieuluc,@ngayhethan,@noidung)
end

go

create proc GetDanhSachHopDongFilter @str1 nvarchar(50), @str2 nvarchar(50)
as
begin
	if(@str1 = N'Số Hợp Đồng')
	begin
		select * from HopDongNhanSu where SoHopDong like '%'+@str2+'%'
	end
	else if(@str1 = N'Tên Nhân Viên')
	begin
		select * from HopDongNhanSu where HoTenNV like '%'+@str2+'%'
	end
	else if(@str1 = N'Loại Hợp Đồng')
	begin
		select * from HopDongNhanSu where LoaiHopDong like '%'+@str2+'%'
	end
	else if(@str1 = N'None')
	begin
		select * from HopDongNhanSu
	end
end

go 

create proc EditHopDong @sohd varchar(20), @manv varchar(10), @tennv nvarchar(250), @loaihd nvarchar(250), @trangthai nvarchar(50), @ngayhieuluc datetime, @ngayhethan datetime, @noidung ntext
as
begin
	update HopDongNhanSu
	set MaNV = @manv,
	HoTenNV = @tennv,
	LoaiHopDong = @loaihd,
	TrangThai = @trangthai,
	NgayHieuLuc = @ngayhieuluc,
	NgayHetHan = @ngayhethan,
	NoiDung = @noidung
	where SoHopDong = @sohd
end

go

create proc GetDanhSachToanBoNhanSu
as
begin
	select MaNV,HoTenNV,Format( NgaySinh,'MM/dd/yyyy') as NgaySinh,GioiTinh,ChucVu,BoPhan,MaPhongBan,Format( NgayVaoCoQuan,'MM/dd/yyyy') as NgayVaoCoQuan,QueQuan,Email,SoDienThoai,HocVi,HocHam,ChungChi,chuyenMon from HoSoNhanSu
end

go

create proc GetDanhSachToanBoHopDong
as
begin
	select HoTenNV,SoHopDong,MaNV,LoaiHopDong,TrangThai,Format( NgayHieuLuc,'MM/dd/yyyy') as NgayHieuLuc, Format( NgayHetHan,'MM/dd/yyyy') as NgayHetHan,NoiDung from HopDongNhanSu
end